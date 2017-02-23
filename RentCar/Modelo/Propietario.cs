using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentCar.Modelo
{
    [Table("Propietarios")]
    class Propietario
    {
        [Key]
        public int pkPropietario { get; set; }

        [Required(ErrorMessage = "Nombre Requerido")]

        [StringLength(150)]

        public String sNombreCompleto { get; set; }
        [StringLength(240)]

        [Required(ErrorMessage = "Direccion Requerida")]

        public String sDireccion { get; set; }
        [StringLength(240)]

        [Required(ErrorMessage = "Telefono Requerido")]

        public String sTelefono { get; set; }
        [StringLength(240)]
        [Required(ErrorMessage = "Correo Requerido")]

        public String sCorreo { get; set; }
        [StringLength(240)]

        [Required(ErrorMessage = "Foto Requerida")]

        public String sFotoPropietario { get; set; }
        [StringLength(240)]


        public String sIfe { get; set; }

        public Boolean bStatus { get; set; }


        public Propietario()
        {
            this.bStatus = true;
        }


    }
}
