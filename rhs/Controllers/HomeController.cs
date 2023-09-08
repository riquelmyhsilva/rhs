using rhs.Models;
using System;
using System.Web.Mvc;

namespace rhs.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AboutMe()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult DolbyCinema()
        {
            return View();
        }

        public ActionResult Calculator()
        {
            return View();
        }

        public ActionResult Bdc()
        {
            return View();
        }
        public ActionResult PhraseRewriter()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RegistrarEmail(string EmailAddress)
        {
            if (ModelState.IsValid)
            {
                // Crie uma instância do seu contexto de banco de dados
                using (var db = new EmailContext())
                {
                    try
                    {
                        // Crie uma nova instância do modelo Email e defina o email
                        var email = new Email { EmailAddress = EmailAddress, SentDate = DateTime.Now };

                        // Adicione o email ao contexto e salve as alterações no banco de dados
                        db.Email.Add(email);
                        db.SaveChanges();

                        // Redirecione para uma página de sucesso ou faça outra ação
                        return RedirectToAction("EmailRegistradoComSucesso");
                    }
                    catch (Exception ex)
                    {
                        // Lidar com erros, por exemplo, registrar em log
                        return RedirectToAction("ErroNoRegistroDeEmail" + ex);
                    }
                }
            }

            // Se o modelo não for válido, volte para a página de contato
            return View("Contact");
        }

    }
}