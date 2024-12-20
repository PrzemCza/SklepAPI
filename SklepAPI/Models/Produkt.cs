namespace SklepAPI.Models
{
    public class Produkt
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public string Marka { get; set; }
        public int Rozmiar { get; set; }
        public string Kolor { get; set; }
        public decimal Cena { get; set; }
    }
}