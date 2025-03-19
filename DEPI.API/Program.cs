using DEPI.BLL.Services.InstructorService;
using DEPI.BLL.Services.StudentService;
using DEPI.DAL.Database;
using DEPI.DAL.Repository.GenericRepository;
using DEPI.DAL.Repository.InstructorRepo;
using DEPI.DAL.Repository.StudentRepo;
using Microsoft.EntityFrameworkCore;

namespace DEPI.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            //builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);


            builder.Services.AddDbContext<DEPIContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("cs")));

            builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));//must include it in case applying Generic repository
            builder.Services.AddScoped<IStudentService, StudentService>();
            builder.Services.AddScoped<IStudentRepository, StudentRepository>();
            builder.Services.AddScoped<IInstructorService, InstructorService>();
            builder.Services.AddScoped<IInstructorRepository, InstructorRepository>();

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
        }
    }
}
