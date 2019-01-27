using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Security;
using System.Web;
using System.Web.Mvc;
using WebApplication2.FirstWCFService;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        FirstWebServiceClient client = new FirstWebServiceClient();
   
        public ActionResult Index()
        {
            client.ClientCredentials.UserName.UserName = "Intesar";
            client.ClientCredentials.UserName.Password = "123456";
            //certificate exe link https://www.codeproject.com/Articles/96028/WCF-Service-with-custom-username-password-authenti
            client.ClientCredentials.ServiceCertificate.Authentication.CertificateValidationMode = X509CertificateValidationMode.None;
            ViewBag.Message=client.Message();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}