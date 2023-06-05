using Microsoft.AspNetCore.Mvc;
using Teach.Models;

namespace Teach.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var kitap = new List<KitapModalView>
            {
                new KitapModalView {Id=15182, Name="İnsan Ne İle Yaşar",Author="Tolstoy"},
                new KitapModalView {Id=12575, Name="Sefiller",Author="Victor Hugo"},
                new KitapModalView {Id=17974, Name="Suç Ve Ceza",Author="Dostoyevski"},
                new KitapModalView {Id=11239, Name="Gurur Ve Önyargı",Author="Jane Austen"}
            };
            return View(kitap);
        }
    }
}
