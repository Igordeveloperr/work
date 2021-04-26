namespace PCAssemblyServices.Model.catalog.view
{
    public abstract class ProductView
    {
        public int Id { get; }
        public int Price { get; }
        public int CalculateTotalPrice(int count)
        {
            return Price * count;
        }
    }
}
