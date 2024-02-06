using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

using System.Threading.Tasks;

namespace web1.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }

        public async Task<ActionResult> ApiEntegrasyon()
        {

            using (HttpClient client = new HttpClient())
            {
                string apiUrl = "https://jsonplaceholder.typicode.com/todos/1";

                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string responseData = await response.Content.ReadAsStringAsync();
                    return View((object)responseData);
                }
                else
                {
                    ViewBag.Error = "Hata Kodu: " + response.StatusCode;
                }
            }
            return View();
        }
    }

    }



