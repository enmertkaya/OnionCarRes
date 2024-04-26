using OnionCarRes.Application.Features.CQRS.Handlers.AboutHandlers;
using OnionCarRes.Application.Features.CQRS.Handlers.BannerHandlers;
using OnionCarRes.Application.Features.CQRS.Handlers.BrandHandlers;
using OnionCarRes.Application.Features.CQRS.Handlers.CarHandlers;
using OnionCarRes.Application.Features.CQRS.Handlers.CategoryHandlers;
using OnionCarRes.Application.Features.CQRS.Handlers.ContactHandlers;
using OnionCarRes.Application.Interfaces;
using OnionCarRes.Application.Interfaces.CarInterfaces;
using OnionCarRes.Application.Interfaces.CarFeatureInterfaces;
using OnionCarRes.Persistence.Repositories.CarFeatureRepositories;
using OnionCarRes.Persistence.Context;
using OnionCarRes.Persistence.Repositories;
using OnionCarRes.Persistence.Repositories.CarRepositories;
using OnionCarRes.Application.Services;
using OnionCarRes.Application.Interfaces.BlogInterfaces;
using OnionCarRes.Persistence.Repositories.BlogRepositories;
using OnionCarRes.Application.Interfaces.CarPricingInterfaces;
using OnionCarRes.Persistence.Repositories.CarPricingRepositories;
using OnionCarRes.Persistence.Repositories.CommentRepositories;
using OnionCarRes.Application.Interfaces.TagCloudInterfaces;
using OnionCarRes.Persistence.Repositories.TagCloudRepositories;
using OnionCarRes.Application.Features.RepositoryPattern;
using OnionCarRes.Application.Interfaces.StatisticsInterfaces;
using OnionCarRes.Persistence.Repositories.StatisticsRepositories;
using OnionCarRes.Application.Interfaces.RentACarInterfaces;
using OnionCarRes.Persistence.Repositories.RentACarRepositories;
using OnionCarRes.Application.Interfaces.CarDescriptionInterfaces;
using OnionCarRes.Persistence.Repositories.CarDescriptionRepositories;





var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<CarBookContext>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped(typeof(ICarRepository), typeof(CarRepository));
builder.Services.AddScoped(typeof(IBlogRepository), typeof(BlogRepository));
builder.Services.AddScoped(typeof(ICarPricingRepository), typeof(CarPricingRepository));
builder.Services.AddScoped(typeof(ITagCloudRepository), typeof(TagCloudRepository));
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(CommentRepository<>));
builder.Services.AddScoped(typeof(IRentACarRepository), typeof(RentACarRepository));
builder.Services.AddScoped(typeof(IStatisticsRepository), typeof(StatisticsRepository));
builder.Services.AddScoped(typeof(ICarFeatureRepository), typeof(CarFeatureRepository));
builder.Services.AddScoped(typeof(ICarDescriptionRepository), typeof(CarDescriptionRepository));




builder.Services.AddScoped<GetAboutQueryHandler>();
builder.Services.AddScoped<GetAboutByIdQueryHandler>();
builder.Services.AddScoped<CreateAboutCommandHandler>();
builder.Services.AddScoped<UpdateAboutCommandHandler>();
builder.Services.AddScoped<RemoveAboutCommandHandler>();

builder.Services.AddScoped<GetBannerQueryHandler>();
builder.Services.AddScoped<GetBannerByIdQueryHandler>();
builder.Services.AddScoped<CreateBannerCommandHandler>();
builder.Services.AddScoped<UpdateBannerCommandHandler>();
builder.Services.AddScoped<RemoveBannerCommandHandler>();

builder.Services.AddScoped<GetBrandQueryHandler>();
builder.Services.AddScoped<GetBrandByIdQueryHandler>();
builder.Services.AddScoped<CreateBrandCommandHandler>();
builder.Services.AddScoped<UpdateBrandCommandHandler>();
builder.Services.AddScoped<RemoveBrandCommandHandler>();

builder.Services.AddScoped<GetCarQueryHandler>();
builder.Services.AddScoped<GetCarByIdQueryHandler>();
builder.Services.AddScoped<GetCarWithBrandQueryHandler>();
builder.Services.AddScoped<GetLast5CarsWithBrandQueryHandler>();
builder.Services.AddScoped<CreateCarCommandHandler>();
builder.Services.AddScoped<UpdateCarCommandHandler>();
builder.Services.AddScoped<RemoveCarCommandHandler>();

builder.Services.AddScoped<GetCategoryQueryHandler>();
builder.Services.AddScoped<GetCategoryByIdQueryHandler>();
builder.Services.AddScoped<CreateCategoryCommandHandler>();
builder.Services.AddScoped<UpdateCategoryCommandHandler>();
builder.Services.AddScoped<RemoveCategoryCommandHandler>();

builder.Services.AddScoped<GetContactQueryHandler>();
builder.Services.AddScoped<GetContactByIdQueryHandler>();
builder.Services.AddScoped<CreateContactCommandHandler>();
builder.Services.AddScoped<UpdateContactCommandHandler>();
builder.Services.AddScoped<RemoveContactCommandHandler>();

builder.Services.AddApplicationService(builder.Configuration);



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
