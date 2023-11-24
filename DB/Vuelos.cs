using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class Ciudad
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string Nombre { get; set; }
        public string ImagenUrl { get; set; }
        public string ZipCode { get; set; }
    }

    public class Vuelo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int CiudadOrigenId { get; set; }
        public int CiudadDestinoId { get; set; }
        public DateTime FechaIda { get; set; }
        public DateTime FechaVuelta { get; set; }
        public decimal Precio { get; set; }
        public DateTime HoraSalida { get; set; }
        public DateTime HoraLlegada { get; set; }
        public string CiudadDestinoImg { get; set; }

        public virtual Ciudad CiudadOrigen { get; set; }
        public virtual Ciudad CiudadDestino { get; set; }
    }

    //public class TarjetaVuelo
    //{
    //    [Key]
    //    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    //    public int id { get; set; }
    //    public int VueloId { get; set; }
    //    public string CiudadDestinoImgUrl { get; set; }
    //    public decimal Precio { get; set; }
    //    public DateTime HoraSalida { get; set; }
    //    public DateTime HoraLlegada { get; set; }

    //    public virtual Vuelo Vuelo { get; set; }
    //}

}
