using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace websit
{
    public class createview
    {
        [Required(ErrorMessage = "resim yukleyin!")]
        [Display(Name ="resim")]
        public HttpPostedFileBase file { get; set; }


        [Required(ErrorMessage =  "alanı doldurun")]
        public string cv { get; set; }
        [Required(ErrorMessage =  "alanı doldurun")]
        public string Name { get; set; }

        [Required(ErrorMessage =  "alanı doldurun")]
        public string username { get; set; }
        
        [Required(ErrorMessage =  "alanı doldurun!")]
        public string password { get; set; }
        [EmailAddress(ErrorMessage ="duzgun email girin")]
        [Required(ErrorMessage =  "alanı doldurun!")]
        public string email { get; set; }
        [Required(ErrorMessage =  "alanı doldurun!")]
        public string description { get; set; }



    }
}