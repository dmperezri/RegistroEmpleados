
Empleado[] empleados = new Empleado[10];

int menu()
{
    Console.WriteLine("1. Agregar empleado \n2. Mostrar empleados \n3. Eliminar empleado " +
        "\n4. Salir \nEscriba su opción: ");

    int op;
    if (!int.TryParse(Console.ReadLine(), out op))
    {
        return 0; // Invalid option
    }
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
}
 
void mostrarEmpleados()
{
    Console.WriteLine("\nLista de empleados registrados:");
    for (int i = 0; i < empleados.Length; i++)
    {
        if (!string.IsNullOrEmpty(empleados[i].nombres))
        {
            Console.WriteLine($"Empleado {i + 1}: {empleados[i].nombres} {empleados[i].apellidos}, Cargo: {empleados[i].cargo}, Salario: {empleados[i].salario}");
        }
    }
}

void eliminarEmpleado()
{
    Console.Write("\nIngrese el número del empleado a eliminar: ");
    int num;
    if (int.TryParse(Console.ReadLine(), out num) && num > 0 && num <= empleados.Length)
    {
        int index = num - 1;
        if (!string.IsNullOrEmpty(empleados[index].nombres))
        {
            empleados[index] = new Empleado(); // Reset the employee record
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nEmpleado eliminado satisfactoriamente");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nNo existe un empleado registrado en esa posición");
            Console.ResetColor();
        }
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nNúmero inválido, por favor intente nuevamente");
        Console.ResetColor();
    }
}

int main() 
{
    int op = 0, i = 0;

    do
    {
        Console.WriteLine("Registro de empleados");

        op = menu();
        switch (op)
        {
            case 1:
                agregarEmpleado(i++);
                break;
            case 2:
                mostrarEmpleados();
                break;
            case 3:
                eliminarEmpleado();
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