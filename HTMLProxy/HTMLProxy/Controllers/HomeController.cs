using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace HTMLProxy.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public static string UrlEscaper(Match match)
        {
            var url = match.Groups["url"].Value;
            var processedUrl = string.Format("/proxy?url={0}", Uri.EscapeDataString(url));

            return processedUrl;
        }

        public ActionResult Proxy(string url)
        {
            var uri = new Uri(url, UriKind.RelativeOrAbsolute);
            var request = WebRequest.Create(uri);

            var task = Task.Factory.StartNew<string>(() =>
            {
                using (var stream = request.GetResponse().GetResponseStream())
                {
                    using (var reader = new StreamReader(stream))
                    {
                        return reader.ReadToEnd();
                    }
                }
            });
            task.Wait();

            var originalHtml = task.Result;

            var hrefPattern = "(?<=href=\")(?<url>.*?)(?=\")";
            //var replacement = "/proxy?url=${url}";

            var processedHtml = Regex.Replace(originalHtml, hrefPattern, new MatchEvaluator(UrlEscaper));

            var result = new ContentResult();
            result.Content = processedHtml;

            return result;
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
