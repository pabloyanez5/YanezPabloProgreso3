using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_Aeropuertos.Models
{
    public class Airport
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        
        public string Nombre { get; set; } = string.Empty;

        public string Pais { get; set; } = string.Empty;
        public double Latitud { get; set; }
        public double Longitud { get; set; }

      
        public string Email { get; set; } = string.Empty;

        public string PYanez { get; set; } = string.Empty;
        public string FormattedDetails =>
        $"País: {Pais}, Latitud: {Latitud}, Longitud: {Longitud}, Correo: {Email}, PYanez: {PYanez}";

    }
}
