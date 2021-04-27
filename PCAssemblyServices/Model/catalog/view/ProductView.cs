namespace PCAssemblyServices.Model.catalog.view
{
    public abstract class ProductView
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public int CalculateTotalPrice(int count)
        {
            return Price * count;
        }
    }
}
