using System.ComponentModel.DataAnnotations;

namespace SegundoExamen.Data.Entity
{
    public class Pantas
    {
        public int Id { get; set; }
        [Display(Name = "Nombre de la planta")]
        [MaxLength(200, ErrorMessage = "En el campo {0} el maximo permitido son de 200 caracteres}")]
        public string Name { get; set; } = null!;

        [Display(Name = "Tipo de la planta")]
        [MaxLength(20, ErrorMessage = "En el campo {0} el maximo permitido son de 20  caracteres}")]
        public string type { get; set; } = null!;

        [Display(Name = "Años de la planta")]
        [MaxLength(8, ErrorMessage = "En el campo {0} el maximo permitido son de 8   caracteres}")]
        public DateTime years { get; set; } 

        [Display(Name = "Costo de la planta")]
         public decimal cost { get; set; } 

        [Display(Name = "Fecha de plantación")]
         public DateTime Date { get; set; } 

       [Display(Name = "Si la planta se vendió o no ")]
       public string yon { get; set; } = null!;


        [Display(Name = "Color de la Planta ")]
    
        public string color { get; set; } 

        [Display(Name = "Tamaño de la Planta ")]
 
        public string size { get; set; } 

        [Display(Name = "Es aromatisante ")]
     
        public string flavoring { get; set; }

        [Display(Name = "Es interior o Exterior ")]
       
        public string inside { get; set; }

    }
}
