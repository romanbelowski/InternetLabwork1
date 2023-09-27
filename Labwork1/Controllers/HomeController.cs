using Labwork1.Models;
using Microsoft.AspNetCore.Mvc;


namespace Labwork1.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        ProductContext db = new ProductContext();
        public ActionResult Index()
        {
            // Отримуємо всі об'єкти Product з бази даних
            IEnumerable<Product> Products = db.Products;
            // Передаємо всі об'єкти в динамічну властивість Products в ViewBag
            ViewBag.Products = Products;
            // Повертаємо представлення
            return View();
        }

        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.ProductId = id;
            return View();
        }
        [HttpPost]
        public IActionResult Buy(Purchase purchase)
        {
            purchase.Date = DateTime.Now;
            // Додаємо інформацію про покупку в базу даних
            db.Purchases.Add(purchase);
            // Зберігаємо в БД всі зміни
            db.SaveChanges();
            
            return View("Confirm", purchase);
        }

    }
}