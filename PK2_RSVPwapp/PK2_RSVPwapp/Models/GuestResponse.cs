using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// USADO PARA VALIDAR
using System.ComponentModel.DataAnnotations;

namespace PK2_RSVPwapp.Models
{
    public class GuestResponse
    {
        //public string Name { get; set; }
        //public string Email { get; set; }
        //public string Phone { get; set; }
        //public bool? WillAttend { get; set; }

        [Required(ErrorMessage = "Porfavor ingrese su nombre.")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Porfavor ingrese su correo electonico.")]
        [RegularExpression(".+\\@.+\\..+",
            ErrorMessage="Porfavor ingresa un correo valido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Porfavor ingrese su numero telefono.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Porfavor especifique si asistira o no.")]
        public bool? WillAttend { get; set; }

    }
}