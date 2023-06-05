using Microsoft.AspNetCore.Mvc;
using Teach.Models;

namespace Teach.ViewComponents
{
    public class NewBooks : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var booklists = new List<KitapModalView> 
            {
                new KitapModalView {Id=12482,Name="Hayvan Çiftliği",Author="George Orwell"},
                new KitapModalView {Id=15694,Name="Çocukluk",Author="Tolstoy"},
                new KitapModalView {Id=10281,Name="Babaya Mektup",Author="Kafka"}
            };
            return View(booklists);
        }
    }
}
