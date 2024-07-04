using Newtonsoft.Json;

namespace Nuget.Quickstart {
    public class Usuario {
        public string? Nombre {get; set;}
        public string? Email {get; set;}
        public DateTime? Fecha {get; set;}
    }

    internal class Program {
        static void Main(string[] args) {
            Usuario usuario = new Usuario {
                Nombre = "Juan",
                Email = "juan@123.cl",
                Fecha = new DateTime(1980, 12, 25, 0, 0, 0, DateTimeKind.Utc)
            };
            string json = JsonConvert.SerializeObject(usuario, Formatting.Indented);
            Console.WriteLine(json);
        }
    }
}
