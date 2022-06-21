using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using aspnetmvcdapper.Models;//EKLE
using Dapper;//EKLE
using System.Web.Mvc;

namespace aspnetmvcdapper.Controllers
{
    public class satisController : Controller
    {
        // GET: satis
        public ActionResult Index()
        {
            return View(DP.ReturnList<satismodel>("satislistele")); //listeleme işlemi satismodel de kolonlarımız var
        }
        [HttpGet]
        public ActionResult ekle(int id = 0)
        {
            if (id == 0)
                return View();
            else
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@satisid", id);

                return View(DP.ReturnList<satismodel>("satissirala", param).FirstOrDefault<satismodel>());
            }
        }
        [HttpPost]
        public ActionResult ekle(satismodel ekle)
        {
            //view oluştururken edit olanı seçiyoruz
            DynamicParameters param = new DynamicParameters();
            param.Add("@satisid", ekle.satisid);
            param.Add("@urunid", ekle.urunid);
            param.Add("@musteriid", ekle.musteriid);
            param.Add("@adet", ekle.adet);
            param.Add("@fiyat", ekle.fiyat);
            DP.ExecuteWithoutReturn("satisekle", param);
            return RedirectToAction("Index");

        }
        public ActionResult Delete(int id = 0)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("satisid", id);
            DP.ExecuteWithoutReturn("satissilno", param);
            return RedirectToAction("Index");
        }
    }
}