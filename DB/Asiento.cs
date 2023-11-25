using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class Asiento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int Numero { get; set; }
        public string Clase { get; set; }
        public bool Reservado { get; set; }
        public User? user { get; set; }
        public Vuelo Vuelo { get; set; }
        public int? UserId { get; set; }
        public int VueloId { get; set; }

        //public Asiento(int numero, string clase, bool reservado, Vuelo vuelo)
        //{
        //    Numero = numero;
        //    Clase = clase;
        //    Reservado = reservado;
        //    Vuelo = vuelo;
        //}
    }
}
