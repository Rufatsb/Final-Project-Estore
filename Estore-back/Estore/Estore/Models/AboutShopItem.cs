namespace Estore.Models
{
    public class AboutShopItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Img { get; set; }
        public virtual AboutShopInfo Info { get; set; }
        public int AboutShopInfoId { get; set; }
    }
}
