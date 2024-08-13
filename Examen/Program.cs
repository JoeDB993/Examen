using Examen;


class Program
{
    static void Main(string[] args)
    {
        Asignatura asignatura = new Asignatura();

        Console.Write("Ingrese el nombre del alumno: ");
        asignatura.NombreAlumno = Console.ReadLine();

        Console.Write("Ingrese el número de cuenta: ");
        asignatura.NumeroCuenta = Console.ReadLine();

        Console.Write("Ingrese el email: ");
        asignatura.Email = Console.ReadLine();

        Console.Write("Ingrese el nombre de la asignatura: ");
        asignatura.NombreAsignatura = Console.ReadLine();

        Console.Write("Ingrese el horario de la asignatura: ");
        asignatura.Horario = Console.ReadLine();

        Console.Write("Ingrese el nombre del docente: ");
        asignatura.NombreDocente = Console.ReadLine();

        asignatura.N1 = LeerNota("Ingrese la nota del primer parcial (0-30): ", 30);
        asignatura.N2 = LeerNota("Ingrese la nota del segundo parcial (0-30): ", 30);
        asignatura.N3 = LeerNota("Ingrese la nota del tercer parcial (0-40): ", 40);

        asignatura.Imprimir();
    }

    static int LeerNota(string mensaje, int maximo)
    {
        int nota;

        Console.Write(mensaje);
        while (!int.TryParse(Console.ReadLine(), out nota) || nota < 0 || nota > maximo)
        {
            Console.WriteLine($"Error: La nota debe ser un número entre 0 y {maximo}. Por favor, intente nuevamente.");
            Console.Write(mensaje);
        }

        return nota;
    }
}

