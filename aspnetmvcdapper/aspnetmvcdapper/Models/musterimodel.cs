using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;/*required mesajı için ekledik*/
namespace aspnetmvcdapper.Models
{
    public class musterimodel
    {
        public int musteriid { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur.")] /*ekle.cshtml deki required olan alanların sabit mesajını değiştirmek için*/
        public string musteriad { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public string musterisoyad { get; set; }
    }
}