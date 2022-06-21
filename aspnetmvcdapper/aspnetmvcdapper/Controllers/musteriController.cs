using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using aspnetmvcdapper.Models;//EKLE
using Dapper;//EKLE
using System.Web.Mvc;

namespace aspnetmvcdapper.Controllers
{
    public class musteriController : Controller
    {
        // GET: musteri
        public ActionResult Index()
        {
            return View(DP.ReturnList<musterimodel>("musterilistele")); //listeleme işlemi musterimodel de kolonlarımız var
        }
        [HttpGet]
        public ActionResult ekle(int id = 0)
        {
            if (id == 0)
                return View();
            else
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@musteriid", id);

                return View(DP.ReturnList<musterimodel>("musterisirala", param).FirstOrDefault<musterimodel>());
            }
        }
        [HttpPost]
        public ActionResult ekle(musterimodel ekle)
        {
            //view oluştururken edit olanı seçiyoruz
            DynamicParameters param = new DynamicParameters();
            param.Add("@musteriid", ekle.musteriid);
            param.Add("@musteriad", ekle.musteriad);
            param.Add("@musterisoyad", ekle.musterisoyad);
            DP.ExecuteWithoutReturn("musteriekle", param);
            return RedirectToAction("Index");

        }
        public ActionResult Delete(int id = 0)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("musteriid", id);
            DP.ExecuteWithoutReturn("musterisilno", param);
            return RedirectToAction("Index");
        }
    }
}