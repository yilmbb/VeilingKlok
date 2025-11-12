namespace VeilingKlok.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public string Omschrijving { get; set; }
        public decimal StartPrijs { get; set; }
        public DateTime AuctionEndTime { get; set; }

        public Product(int id, string naam, decimal startPrijs, DateTime AuctionEndTime)
        {
            Id = id;
            Naam = naam;
            StartPrijs = startPrijs;
            Omschrijving = string.Empty;
            AuctionEndTime = DateTime.Now.AddDays(7); // Default auction end time set to 7 days from now
        }

        public static List<Product> Products  = new List<Product>
        {
            new Product(1, "Vintage Klok", 50.00m, DateTime.Now.AddDays(7)),
            new Product(2, "Antieke Stoel", 75.00m, DateTime.Now.AddDays(7)),
            new Product(3, "Schilderij", 100.00m, DateTime.Now.AddDays(7))
        };
    }
}