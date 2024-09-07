namespace MVC_Assm1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.UseRouting();

            app.UseEndpoints(endpoints => {
               endpoints.MapGet("/Home", async context =>
               {
                   await context.Response.WriteAsync("You are at home page");
               });
               
               endpoints.MapGet("/Products", async context =>
               {
                   await context.Response.WriteAsync("you are at Products");
               });
            });

            app.Run(async(HttpContext) => await HttpContext.Response.WriteAsync("NOT Found"));
            //app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}
