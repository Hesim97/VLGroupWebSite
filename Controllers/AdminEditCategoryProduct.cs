namespace VLGroupWebSite.Controllers
{
    internal class AdminEditCategoryProduct
    {
        public AdminEditCategoryProduct()
        {
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Image { get; set; }
        public bool IsActiv { get; set; }
        public bool IsHome { get; set; }
    }
}