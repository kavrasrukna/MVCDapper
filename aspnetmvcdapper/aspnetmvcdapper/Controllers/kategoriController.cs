using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using aspnetmvcdapper.Models;//EKLE
using Dapper;//EKLE
using System.Web.Mvc;

namespace aspnetmvcdapper.Controllers
{
    public class kategoriController : Controller
    {
        // GET: kategori
        public ActionResult Index()
        {

            return View(DP.ReturnList<kategorimodel>("kategorilistele")); //listeleme işlemi kategorimodel de kolonlarımız var
        }
        [HttpGet]
        public ActionResult ekle(int id = 0)
        {
            if (id == 0)
                return View();
            else
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@kategoriid", id);

                return View(DP.ReturnList<kategorimodel>("kategorisirala", param).FirstOrDefault<kategorimodel>());
            }
        }
        [HttpPost]
        public ActionResult ekle(kategorimodel ekle)
        {
            //view oluştururken edit olanı seçiyoruz
            DynamicParameters param = new DynamicParameters();
            param.Add("@kategoriid", ekle.kategoriid);
            param.Add("@kategoriad", ekle.kategoriad);
            DP.ExecuteWithoutReturn("kategoriekle", param);
            return RedirectToAction("Index");

        }
        public ActionResult Delete(int id = 0)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("kategoriid", id);
            DP.ExecuteWithoutReturn("kategorisilno", param);
            return RedirectToAction("Index");
        }
    }
}