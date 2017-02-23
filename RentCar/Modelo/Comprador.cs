using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentCar.Modelo
{
    [Table("Compradores")]
    class Comprador
    {
        [Key]
        public int pkComprador { get; set; }

        [Required(ErrorMessage = "Nombre Requerido")]

        [StringLength(150)]
        
        public String sNombreCompleto { get; set; }
        [StringLength(240)]

        [Required(ErrorMessage = "Direccion Requerida")]

        public String sDireccionCompleta { get; set; }
        [StringLength(240)]

    

        public Boolean bStatus { get; set; }


        public Comprador()
        {
            this.bStatus = true;
        }
    }
}
