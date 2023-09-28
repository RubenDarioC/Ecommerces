namespace Ecommerce.Models
{
	public class ProductSectionModel
	{
		public string Title { get; set; }
		public string Paragraph { get; set; }
		public string Buttom { get; set; }
		public List<ProductSectionRightModel> Products { get;}
		
	}

	public class ProductSectionRightModel 
	{
		public string RoutePhoto { get; set; }
		public string NameProduct { get; set; }
		public int Price { get; set; }
	}
}
