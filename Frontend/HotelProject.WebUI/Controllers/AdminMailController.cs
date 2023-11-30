using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MailKit.Net.Smtp;
using System.Threading.Tasks;
using HotelProject.WebUI.Models.Mail;

namespace HotelProject.WebUI.Controllers
{
    public class AdminMailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(AdminMailViewModel model)
        {
            // MimeMessage nesnesi oluşturun
            MimeMessage mimeMessage = new MimeMessage();

            // Gönderen bilgilerini ekleyin
            mimeMessage.From.Add(new MailboxAddress("ResidenseaAdmin", "emreylmz.07k@gmail.com"));

            // Alıcı bilgilerini ekleyin
            mimeMessage.To.Add(new MailboxAddress("User", model.ReceiverMail));

            // E-posta gövdesini oluşturun
            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = model.Body;
            mimeMessage.Body = bodyBuilder.ToMessageBody();

            // Konu bilgisini ekleyin
            mimeMessage.Subject = model.Subject;

            // SmtpClient oluşturun
            using (SmtpClient client = new SmtpClient())
            {
                // Gmail SMTP sunucusuna bağlanın
                await client.ConnectAsync("smtp.gmail.com", 587, false);

                // Gmail kimlik bilgilerinizi kullanarak oturum açın
                await client.AuthenticateAsync("emreylmz.07k@gmail.com", "ewia opwn qsbf duoe");

                // E-postayı gönderin
                await client.SendAsync(mimeMessage);

                // Bağlantıyı kapatın
                await client.DisconnectAsync(true);
            }

            return View();
        }
    }
}
