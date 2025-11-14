using GMS.Business.CMN;
using GMS.Business.PRJ;
using GMS.Business.STD;
using GMS.Business.SUB;
using GMS.Business.VLT;
using GMS.Business.GNR;
using GMS.Data.DataHelper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//versioning
builder.Services.AddApiVersioning(o =>
{
    o.AssumeDefaultVersionWhenUnspecified = true;
    o.DefaultApiVersion = new ApiVersion(1, 0);
    o.ReportApiVersions = true;
    o.ApiVersionReader = ApiVersionReader.Combine(
        new QueryStringApiVersionReader("api-version"),
        new HeaderApiVersionReader("X-Version"),
        new MediaTypeApiVersionReader("ver"));

});

#region Register services....
//Data services....
builder.Services.AddScoped<IDataHelper, DataHelper>();

// RBL services...
builder.Services.AddScoped<ISTDService, STDService>();
builder.Services.AddScoped<ISUBService, SUBService>();
builder.Services.AddScoped<ICMNService, CMNService>();
builder.Services.AddScoped<IPRJService, PRJService>();
builder.Services.AddScoped<IVLTService, VLTService>();
builder.Services.AddScoped<IGNRService, GNRService>();


#endregion

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
