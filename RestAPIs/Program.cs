
using zNpgsqlClient;
using zWorkRelatedLibrary;

var builder = WebApplication.CreateBuilder(args);

if (builder.Environment.IsDevelopment())
{
    //Allen Home
    if (System.IO.File.Exists(@"C:\Users\Yohoo\Desktop\key.json"))
    {
        builder.Configuration.AddJsonFile(@"C:\Users\Yohoo\Desktop\key.json", optional: true, reloadOnChange: true);
    }
    //Allen company
    if (System.IO.File.Exists(@"C:\Users\Yohoo\OneDrive\орн▒\key.json"))
    {
        builder.Configuration.AddJsonFile(@"C:\Users\Yohoo\OneDrive\орн▒\key.json", optional: true, reloadOnChange: true);
    }

}
if (builder.Environment.IsProduction())
{
    builder.Configuration.AddJsonFile(@"D:\home\key.json", optional: true, reloadOnChange: true);

}
// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddNpgsql(builder.Configuration["SQL:NpqSQLConn3"]);
builder.Services.AddWorkedRelatedService(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
