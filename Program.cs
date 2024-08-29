namespace ExpenseTrackerWebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddAuthorization();
            builder.Services.AddAuthentication("Bearer").AddJwtBearer();
            
            var app = builder.Build();



            app.MapGet("/", () => "Hello World!");
            app.MapGet("/protected", () => "Hello World!")
                .RequireAuthorization();

            app.Run();
        }
    }
}
