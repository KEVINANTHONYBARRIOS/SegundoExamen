using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SegundoExamen.Data.Entity
{
    public class Riego
    {

        public int Id { get; set; }

        [Display(Name = "Costo de la Regadera")]
        public decimal cost { get; set; }

        [Display(Name = "Fecha de Riego")]
        public DateTime Date { get; set; }

        [Display(Name = "La Planta se esta secando ")]
        public string ps { get; set; } = null!;


        [Display(Name = "Se riega con poca agua o mucha")]

        public string irrigation { get; set; }
    }
}
