namespace Labwork1.Models
{
    public class Product
    {
        // ID товару
        public int Id { get; set; }
        // назва товару
        public string Title { get; set; }
        // ціна
        public int Price { get; set; }
    }
    public class Purchase
    {

        // ID покупки
        public int PurchaseId { get; set; }
        // ім’я і прізвище покупця
        public string Person { get; set; }
        // адреса покупця
        public string Address { get; set; }
        // ID товару
        public int ProductId { get; set; }
        // дата покупки
        public DateTime Date { get; set; }
    }

}
