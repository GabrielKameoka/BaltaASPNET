var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
var app = builder.Build();

app.UseHttpsRedirection();//redirecionador automático de requisições HTTP para HTTPS, garantindo que toda a comunicação entre o cliente e o servidor seja criptografada
app.UseStaticFiles();//procura arquivos estáticos na pasta wwwroot

//mapeamento das paginas
app.UseRouting();
app.MapRazorPages();

app.Run();
