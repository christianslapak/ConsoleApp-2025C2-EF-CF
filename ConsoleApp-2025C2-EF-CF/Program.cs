namespace ConsoleApp_2025C2_EF_CF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new EscuelaContext())
            {
                var std = new Estudiante()
                {
                    Nombre = "Daniela",
                    Apellido = "Suarez"
                };
                context.Estdiante.Add(std);
                context.SaveChanges();


                Console.WriteLine("Nuevo Estudiante Agregada");            }
        }
    }
}
