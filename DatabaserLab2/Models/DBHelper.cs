using DatabaserLab2.Data;


namespace DatabaserLab2.Models
{
    public static class DBHelper
    {
        static StoreDBContext dbContext = new StoreDBContext();
        public static List<string> Languages = new List<string> { "English", "Spanish", "Mandarin", "Hindi", "Arabian",
            "Bengali", "Portugese", "Russian", "Japanese", "French", "Swedish" };

        public static async Task AddBook(Book newBook)
        {
            if(newBook.ImagePath == null)
            {
                newBook.ImagePath = "https://files.oaiusercontent.com/file-V8pSLpg43WZXsar3ksCMlRP8?se=2023-11-19T21%3A20%3A25Z&sp=r&sv=2021-08-06&sr=b&rscc=max-age%3D31536000%2C%20immutable&rscd=attachment%3B%20filename%3D0ffcee22-0e76-4b93-bc6e-ec3cbd88f901.webp&sig=n3no6i9fj1jzM%2BmT93GLKZOst9G8Vzq6%2B%2B/03RBnoX0%3D";
            }
            
            dbContext.Books.Add(newBook);
            await dbContext.SaveChangesAsync();
        }
        public static async Task AddAuthor(Author newAuthor)
        {
            dbContext.Authors.Add(newAuthor);
            await dbContext.SaveChangesAsync();    
        }
        public static async Task AddCategory(Category newCategory)
        {
            dbContext.Categories.Add(newCategory);
            await dbContext.SaveChangesAsync();
        }
        public static async Task AddPublisher(Publisher newPublisher)
        {
            dbContext.Publishers.Add(newPublisher);
            await dbContext.SaveChangesAsync();
        }
        public static async Task AddBookToStore(Inventory newInventory)
        {
            dbContext.Inventories.Add(newInventory);
            await dbContext.SaveChangesAsync();
        }
        public static async Task DeleteBook(Inventory inventory)
        {
            dbContext.Inventories.Remove(inventory);
            await dbContext.SaveChangesAsync();
        }
        public static async Task RemoveAuthor(Author removeAuthor)
        {
            var changeAuthor = dbContext.Books.Where(b => b.AuthorId == removeAuthor.AuthorId);
            var newAuthor = dbContext.Authors.FirstOrDefault(a => a.FirstName == "Unknown");

            foreach(var book in changeAuthor)
            {
                book.AuthorId = newAuthor.AuthorId; 
            }
            
            dbContext.Authors.Remove(removeAuthor);
            await dbContext.SaveChangesAsync();
        }
        public static async Task UpdateBook(Book editBook)
        {
            dbContext.Books.Update(editBook);
            await dbContext.SaveChangesAsync();
        }
    }
}
