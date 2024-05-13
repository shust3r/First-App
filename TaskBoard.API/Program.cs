using TaskBoard.API.DbContexts;
using TaskBoard.API.Services;

string CORSOpenPolicy = "OpenCORSPolicy";

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(options =>
{
    options.ReturnHttpNotAcceptable = true;
}).AddNewtonsoftJson();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<TaskBoardContext>();

builder.Services.AddScoped<IBoardRepository, BoardRepository>();
builder.Services.AddScoped<IListRepository, ListRepository>();
builder.Services.AddScoped<ICardRepository, CardRepository>();
builder.Services.AddScoped<IActivityRepository, ActivityRepository>();
builder.Services.AddScoped<ActivityService>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddCors(options =>
{
    options.AddPolicy(
      name: CORSOpenPolicy,
      builder => {
          builder.WithOrigins("*").AllowAnyHeader().AllowAnyMethod();
      });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseCors(CORSOpenPolicy);
app.MapControllers();
app.MapDefaultControllerRoute();

app.Run();