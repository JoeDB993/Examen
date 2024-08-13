
namespace Examen
{
    public class Asignatura : Alumno, IAsignatura
    {
        public int N1; 
        public int N2; 
        public int N3; 
        public string NombreAsignatura { get; set; }
        public string Horario { get; set; }
        public string NombreDocente { get; set; }

        public double CalcularNotaFinal()
        {
            return N1 + N2 + N3;
        }

        public double CalcularNotaFinal(int n1, int n2, int n3)
        {
            return n1 + n2 + n3;
        }

        public string MensajeNotaFinal(double notaFinal)
        {
            if (notaFinal <= 59)
                return "Reprobado";
            else if (notaFinal <= 79)
                return "Bueno";
            else if (notaFinal <= 89)
                return "Muy Bueno";
            else
                return "Sobresaliente";
        }

        public void Imprimir()
        {
            double notaFinal = CalcularNotaFinal();
            Console.WriteLine($"Nombre del Alumno: {NombreAlumno}");
            Console.WriteLine($"Número de Cuenta: {NumeroCuenta}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Asignatura: {NombreAsignatura}");
            Console.WriteLine($"Horario: {Horario}");
            Console.WriteLine($"Docente: {NombreDocente}");
            Console.WriteLine($"Nota Final: {notaFinal} - {MensajeNotaFinal(notaFinal)}");

            
            double notaFinalConParametros = CalcularNotaFinal(N1, N2, N3);
            Console.WriteLine($"Nota Final con parámetros: {notaFinalConParametros} - {MensajeNotaFinal(notaFinalConParametros)}");
        }
    }

}
