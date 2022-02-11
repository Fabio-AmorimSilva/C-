//Setup response
context.Response.ContentType = "text/html";

//Create actors
var target = new Ninja("The Unseen Mirage");
var ninja  = new Ninja("The Blue Phantom");

//First Attack (Sword)
ninja.EquippedWeapon = new Sword();
var result1 = ninja.Attack(target);
await PrintAttackResult(result1);

//Second Attack (Shuriken)
ninja.EquippedWeapon = new Shuriken();
var result2 = ninja.Attack(target);
await PrintAttackResult(result2);

//Write the outcome of an AttackResult to the response stream
async Task PrintAttackResult(Attackresult attackResult)
{
    await context.Response.WriteAsync(
        $"'{attackResult.Attacker}', 
        attacked '{attackResult.Target}' 
        using '{attackResult.Weapon}'<br>");
}

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

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
