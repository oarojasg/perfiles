using System;
namespace Perfiles.Models
{
    public class PerfilModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public long? Telefono { get; set; }
        public string Profesion { get; set; }
        public int? ExperienciaAnos { get; set; }
        public int? ExperienciaMeses { get; set; }
        public string Ciudad { get; set; }
        public int? Edad { get; set; }
    }
}
