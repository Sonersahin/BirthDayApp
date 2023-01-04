using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using BirthDayApp.Models;

namespace BirthDayApp.Controllers
{
    public class DavetiyeController : ApiController
    {
        public IEnumerable<DavetiyeModel> GetKatilanlar()
        {
            return Veritabani.Liste.Where(i => i.KatilmaDurumu == true);
        }
        
        public IEnumerable<DavetiyeModel> GetKatilmayanlar()
        {
            return Veritabani.Liste.Where(i => i.KatilmaDurumu == false);
        }
        
        public void Ekle(DavetiyeModel model)
        {
            if (ModelState.IsValid)
            {
                Veritabani.Add(model);
            }
        }
    } 
    
}    