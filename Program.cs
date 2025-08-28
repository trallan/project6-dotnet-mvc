using Application.Data;
using Application.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// THIS WILL ADD DATA TO THE BOOK TABLE and Author table

// var author = context.Authors.FirstOrDefault(a => a.Name == "Andrew Hunt");
// if (author == null)
// {
//     // Optionally, create the author if not found
//     author = new Author { Name = "Robert C. Martin" };
//     context.Authors.Add(author);
//     context.SaveChanges();
// }

// var addBook = new Book
// {
//     Title = "Clean Code",
//     Year = 2008,
//     AuthorId = author.Id  // <--- important
// };

// context.MyBooks.Add(addBook);
// context.SaveChanges();


app.Run();
