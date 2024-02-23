var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//enable endpointa
app.UseRouting();

//creating endpoints
app.UseEndpoints(endpoints =>
{
    //addiciona os endpoints    
});

app.Run();
