using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;/*required mesajı için ekledik*/
using System.Linq;
using System.Web;

namespace aspnetmvcdapper.Models
{
    public class kategorimodel
    {
        public int kategoriid { get; set; }

        [Required(ErrorMessage="Bu alan zorunludur.")] /*ekle.cshtml deki required olan alanların sabit mesajını değiştirmek için*/
        public string kategoriad { get; set; }
      
    }
}