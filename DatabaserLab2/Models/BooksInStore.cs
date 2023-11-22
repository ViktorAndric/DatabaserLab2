namespace DatabaserLab2.Models
{
	public partial class BooksInStore
	{
		public int StoreId { get; set; }
		public string Title { get; set; }
		public int AuthorId { get; set; }
		public int CategoryId { get; set; }
		public int StockLevel { get; set; }
		public decimal Price { get; set; }
		public string Language { get; set; }
		public string ImagePath { get; set; }
		public string Isbn13 { get; set; }
		public virtual Author? Author { get; set; }

		public virtual Category? Category { get; set; }
		



	}
}
