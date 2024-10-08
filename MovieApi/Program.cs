namespace MovieApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //add services
            builder.Services.AddControllers();

            var app = builder.Build();

            //add mapping
            app.MapControllers();
            app.MapGet("/", () =>
            {
                return Results.Redirect("/api/movies");
            });

            app.Run();
        }
    }
}
