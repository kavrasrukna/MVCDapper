using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using aspnetmvcdapper.Models;//EKLE
using Dapper;//EKLE
using System.Web.Mvc;

namespace aspnetmvcdapper.Controllers
{
    public class urunController : Controller
    {
        // GET: urun
        public ActionResult Index()
        {
            return View(DP.ReturnList<urunmodel>("urunlistele")); //listeleme işlemi musterimodel de kolonlarımız var
        }
        [HttpGet]
        public ActionResult ekle(int id = 0)
        {
            if (id == 0)
                return View();
            else
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@urunid", id);

                return View(DP.ReturnList<urunmodel>("urunsirala", param).FirstOrDefault<urunmodel>());
            }
        }
        [HttpPost]
        public ActionResult ekle(urunmodel ekle)
        {
            //view oluştururken edit olanı seçiyoruz
            DynamicParameters param = new DynamicParameters();
            param.Add("@urunid", ekle.urunid);
            param.Add("@urunad", ekle.urunad);
            param.Add("@marka", ekle.marka);
            param.Add("@kategoriid", ekle.kategoriid);
            param.Add("@fiyat", ekle.fiyat);
            param.Add("@stok", ekle.stok);
            DP.ExecuteWithoutReturn("urunekle", param);
            return RedirectToAction("Index");

        }
        public ActionResult Delete(int id = 0)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("urunid", id);
            DP.ExecuteWithoutReturn("urunsilno", param);
            return RedirectToAction("Index");
        }
    }
}