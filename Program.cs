
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



struct Empleado //struct sirve para almacenar datos de un mismo contexto para poder usarlas de manera más sencilla
{
    public string nombres;
    public string apellidos;
    public string cargo;
    public double salario;
}