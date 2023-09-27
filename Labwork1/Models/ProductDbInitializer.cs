using System.Data.Entity;

namespace Labwork1.Models
{
    public class ProductDbInitializer : DropCreateDatabaseAlways<ProductContext>
    {
        protected override void Seed(ProductContext db)
        {
            db.Products.Add(new Product
            {
                Title = "Добрива",
                Price = 144 });
            db.Products.Add(new Product
            {
                Title = "Насіння",
                Price = 137 });
            db.Products.Add(new Product
            {
                Title = "Горшики",
                Price = 120
            });
            base.Seed(db);
        }
    }
}
