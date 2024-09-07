namespace MVC_Assm1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
               endpoints.MapGet("/Home", async context =>
               {
                   await context.Response.WriteAsync("You are at home page");
               });
               

               endpoints.MapGet("/Products/{ID:int?}", async context =>
               {
                   var idData = context.Request.RouteValues["ID"];

                   if(idData is not null)
                   {
                       int data = Convert.ToInt32(idData);
                       await context.Response.WriteAsync($"you are at Products id => {idData}");
                   }
                   else
                   {
                       await context.Response.WriteAsync($"you are at Products ");

                   }
               });
               
                
                endpoints.MapGet("/Books/{ID}/{Auther:alpha:minlength(5):maxlength(10)}", async context =>
               {
                   int id = Convert.ToInt32(context.Request.RouteValues["ID"]);
                   string name = context.Request.RouteValues["Auther"].ToString();
                   await context.Response.WriteAsync($"you are at Books id = {id} , At Auther => {name}");
               });
            });

            app.Run(async(HttpContext) => await HttpContext.Response.WriteAsync("NOT Found"));
            //app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}
