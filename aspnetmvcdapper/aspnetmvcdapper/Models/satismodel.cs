using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;/*required mesajı için ekledik*/
namespace aspnetmvcdapper.Models
{
    public class satismodel
    {
        public int satisid { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur.")] /*ekle.cshtml deki required olan alanların sabit mesajını değiştirmek için*/
        public int urunid { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur.")] 
        public int musteriid { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur.")] 
        public int adet { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur.Fiyat alanı tam sayı olmalıdır.")] 
        public decimal fiyat { get; set; }
    }
}