using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanguageFeatures.Model;
using Microsoft.AspNetCore.Mvc;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            List<string> results = new List<string>();

            foreach (Product item in Product.GetProducts())
            {
                string name = item?.Name ?? "<No Name>";
                decimal? price = item?.Price ?? 0;
                string category = item?.Cartegory ?? "<No Category>";
                
                if (item?.InStock==true)
                {
                    results.Add(string.Format("Name : {0},Category :{1}, Price : {2}", name, category, price));
                }
                
            }


            return View(results);
        }
    }
}