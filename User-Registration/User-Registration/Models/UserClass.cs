using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace User_Registration.Models
{
    public class UserClass
    {
        [Key]
        public int UserId { get; set; }
        [Required(ErrorMessage ="Please Enter UserName..")]
        [Display(Name =" Name")]

        public String Username { get; set; }

        [Required(ErrorMessage = "Please Enter The Password..")]

        [DataType(DataType.Password)]
        [Display(Name ="Password")]
        public String pwd { get; set; }

        [Required(ErrorMessage = "Please Enter The Confirm Password..")]

        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("pwd")]
        public String Confirmpwd { get; set; }


        [Required(ErrorMessage = "Please Enter Email..")]
        [Display(Name = "Email")]

        public String Umail { get; set; }

        [Required(ErrorMessage = "Please Enter Your Gender..")]
        [Display(Name = "Gender")]

        public String Gender { get; set; }

        [Required(ErrorMessage = "Please Enter The Matial Status..")]
        [Display(Name = "Matial Status")]

        public String Matialstatus { get; set; }



    }
}
