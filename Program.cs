namespace MVCDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            app.UseRouting();
            app.UseStaticFiles();
            #region MyRegion
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/home", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello World! => home");
            //    });
            //    //endpoints.MapGet("/products", async context =>
            //    //{
            //    //    await context.Response.WriteAsync("Hello World! => products");
            //    //});
            //    endpoints.MapGet("/products/{id:int?}", async context =>
            //    {
            //        var idData = context.Request.RouteValues["id"];
            //        if (idData is not null)
            //        {
            //            int data = Convert.ToInt32(idData);
            //            await context.Response.WriteAsync($"Hello World! => products id => {data}");
            //        }
            //        else
            //        {
            //            await context.Response.WriteAsync("you are at product page");
            //        }

            //    });
            //    // parameters
            //    endpoints.MapGet("/books/{id}/{Auther:alpha:minlength(5):maxlength(20)}", async context =>
            //    {
            //        int id = Convert.ToInt32(context.Request.RouteValues["id"]);
            //        string name = context.Request.RouteValues["Auther"].ToString();
            //        await context.Response.WriteAsync($"Hello World! => products {id} , {name}");
            //    });
            //});
            #endregion
            app.MapControllerRoute
                (
                    name : "default",
                    pattern : "/{Controller=Home}/{Action=Privacy}",
                    defaults : new { Controller = "Home" , Action = "Privacy" }
                );

            //app.MapGet("/", () => "Hello World!");
            //////app.Run(async (HttpContent) => { await HttpContent.Response.WriteAsync("hello"); });
            app.Run();
        }
    }
}
