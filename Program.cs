
Empleado[] empleados = new Empleado[10]; 

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

int menu()
{
    Console.WriteLine("1. Agregar empleado \n2. Mostrar empleados \n3. Eliminar empleado " +
        "\n4. Salir \nEscriba su opción: ");

    int op;
    if (!int.TryParse(Console.ReadLine(), out op))
    {
        return 0; 
    }
    return 0;
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
                
            case 3:
                
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