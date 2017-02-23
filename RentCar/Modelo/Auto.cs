using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentCar.Modelo
{
    [Table("Autos")]
    class Auto
    {
        [Key]
        public int pkAuto { get; set; }

        

        [StringLength(150)]

        public String sMarca { get; set; }
        [StringLength(240)]

        public String sModelo { get; set; }
       

        public int  iAnio { get; set; }

        [StringLength(240)]

        public String sPlaca { get; set; }
        
        public Double dPrecio { get; set; }


        [StringLength(240)]

        public String sColor { get; set; }
        [StringLength(240)]

        public String sNacionalidad { get; set; }

         [StringLength(240)]

        public String sObervaciones { get; set; }
        [StringLength(240)]
        public String sFotoAutoUno { get; set; }
        [StringLength(240)]
        public String sFotoAutoDos { get; set; }
        [StringLength(240)]
        public String sFotoAutoTres { get; set; }


        public Boolean bStatus { get; set; }



        public Auto()
        {
            this.bStatus = true;
        }



    }
}
