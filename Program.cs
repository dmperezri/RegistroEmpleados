
Empleado[] empleados = new Empleado[10];

int menu()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.Write("1. Agregar empleado \n2. Mostrar empleados \n3. Guardar empleados " +
        "\n4. Salir \nEscriba su opción: ");
    Console.ForegroundColor = ConsoleColor.Yellow;
    int op;
    if (!int.TryParse(Console.ReadLine(), out op))
    {
        return 0; 
    }
    Console.WriteLine();
    Console.ResetColor();
    return op;
}

void agregarEmpleado(int pos)
{
    Console.Write("Nombres: ");
    empleados[pos].nombres = Console.ReadLine()!;
    Console.Write("Apellidos: ");
    empleados[pos].apellidos = Console.ReadLine()!;
    Console.Write("Cargo: ");
    empleados[pos].cargo = Console.ReadLine()!;
    Console.Write("Salario: ");
    empleados[pos].salario = double.Parse(Console.ReadLine()!);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("\nRegistro guardado satisfactoriamente");
    Console.ResetColor();

    Console.WriteLine("\nPresiona una tecla para continuar...");
    Console.ReadKey();
}
 
void mostrarEmpleados(int pos)
{
    if (pos == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nNo hay empleados registrados");
        Console.ResetColor();
        Console.WriteLine("\nPresiona una tecla para continuar...");
        Console.ReadKey();
        return;
    }   

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("\nLista de empleados registrados:");
    Console.ResetColor();
    for (int i = 0; i < pos; i++)
    {
        if (!string.IsNullOrEmpty(empleados[i].nombres))
        {
            Console.WriteLine($"Empleado [{i + 1}]: \n{empleados[i].nombres} " +
                $"{empleados[i].apellidos} \nCargo: {empleados[i].cargo}" +
                $"\nSalario: {empleados[i].salario}\n");
        }
    }

    Console.WriteLine("\nPresiona una tecla para continuar...");
    Console.ReadKey();
}


void guardarDatos(int pos)
{
    StreamWriter archivo = new StreamWriter("C:\\Users\\danni\\OneDrive\\Documents\\UAM\\Introduccion_a_la_Programacion\\empleados.csv");
    for (int i = 0; i < pos; i++)
    {
        if (!string.IsNullOrEmpty(empleados[i].nombres))
        {
            archivo.WriteLine($"{empleados[i].nombres}" +
                $"; {empleados[i].apellidos}" +
                $"; {empleados[i].cargo}" +
                $"; {empleados[i].salario}");
        }
    }
    archivo.Close();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("\nRegistros guardados satisfactoriamente");
    Console.ResetColor();
    Console.WriteLine("\nPresiona una tecla para continuar...");
    Console.ReadKey();

}

int main() 
{
    int op = 0, i = 0;

    Console.Write("Cargando...");
    for (int j = 0; j < 10; j++)
    {
        Thread.Sleep(1000);
        Console.Write(".");
    }

    do
    {
        Console.Clear();
        Console.WriteLine("Registro de empleados\n=====================\n");

        op = menu();
        switch (op)
        {
            case 1:
                agregarEmpleado(i++);
                break;
            case 2:
                mostrarEmpleados(i);
                break;
            case 3:
                guardarDatos(i);
                break;
            case 4:
                Console.WriteLine("\nSaliendo del programa...");
                break;
            default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nOpción inválida, por favor intente nuevamente");
                Console.ResetColor();
                break;
        }
    }
    while (op != 4);

    return 0;
}

main();

struct Empleado //struct sirve para almacenar datos de un mismo contexto para poder usarlas de manera más sencilla
{
    public string nombres;
    public string apellidos;
    public string cargo;
    public double salario;
}