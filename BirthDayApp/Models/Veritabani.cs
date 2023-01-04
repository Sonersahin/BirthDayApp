using System.Collections.Generic;
using System.Web;
using System;
using System.Linq;


namespace BirthDayApp.Models
{
    public class Veritabani
    {
        private static Dictionary<string, DavetiyeModel> _liste;
        
        static Veritabani()
        {
            _liste = new Dictionary<string, DavetiyeModel>();
            
            _liste.Add("Hasan", new DavetiyeModel {
                Ad ="Hasan",
                Eposta ="Hasan@gmail.com",
                KatilmaDurumu = true
            });
            
            _liste.Add("Mehmet", new DavetiyeModel {
                Ad ="Mehmet",
                Eposta ="Mehmet@gmail.com",
                KatilmaDurumu = false
            });
        }
        
        public static void Add(DavetiyeModel model) {
            string key = model.Ad.ToLower();
            if (_liste.ContainsKey(key)){
                _liste[key] = model;
            }
            else 
            {
                _liste.Add(key, model);
            }
        }
        
        public static IEnumerable<DavetiyeModel> Liste
        {
            get {return _liste.Values;}    
        }
        
    }
}