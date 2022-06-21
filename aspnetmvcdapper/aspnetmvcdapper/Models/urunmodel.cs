using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;/*required mesajı için ekledik*/
namespace aspnetmvcdapper.Models
{
    public class urunmodel
    {
        public int urunid { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur.")] /*ekle.cshtml deki required olan alanların sabit mesajını değiştirmek için*/
        public string urunad { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public string marka { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public int kategoriid { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur. Fiyat alanı tam sayı olmalıdır.")]
        public decimal fiyat { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public int stok { get; set; }
    }
}