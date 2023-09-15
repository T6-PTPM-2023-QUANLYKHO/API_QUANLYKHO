using API_QuanLyKho.Repository;
using API_QuanLyKho.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
#region DI
builder.Services.AddScoped<IChiTietXHRepository, ChiTietXHRepository>();
builder.Services.AddScoped<IChiTietXHService, ChiTietXHService>();

builder.Services.AddScoped<IPhieuXuatHangService, PhieuXuatHangService>();
builder.Services.AddScoped<IPhieuXuatHangRepository, PhieuXuatHangRepository>();

builder.Services.AddScoped<IKhachHangRepository, KhachHangRepository>();
builder.Services.AddScoped<IKhachHangService, KhachHangService>();

#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
