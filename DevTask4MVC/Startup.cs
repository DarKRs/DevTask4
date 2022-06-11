///NOT USING

//using Microsoft.AspNetCore.Builder;

//namespace DevTask4MVC
//{
//    public class Startup
//    {
//        public Startup(IConfiguration configuration)
//        {
//            Configuration = configuration;
//        }

//        public IConfiguration Configuration { get; }

//        // This method gets called by the runtime. Use this method to add services to the container.
//        public void ConfigureServices(IServiceCollection services)
//        {
//            services.AddLogging();

//            services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(Configuration["ConnectionStrings:DefaultConnection"]));
//            services.AddControllersWithViews();

//            /*services.AddSwaggerGen(config =>
//            {
//                config.SwaggerDoc("v1", new OpenApiInfo
//                {
//                    Title = "DevTask2",
//                    Version = "v1",
//                    Contact = new OpenApiContact { Name = "Sergei Kuznetsov", Email = "", Url = new Uri("https://github.com/DarKRs") },
//                });

//                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
//                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
//                config.IncludeXmlComments(xmlPath);
//            });*/

//        }

//        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
//        public void Configure(WebApplication app)
//        {
//            if (!app.Environment.IsDevelopment())
//            {
//                app.UseExceptionHandler("/Home/Error");
//                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//                app.UseHsts();
//                //app.UseSwagger();
//                //app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "DevTask2 v1"));
//            }

            
//            app.UseHttpsRedirection();
//            app.UseStaticFiles();
//            app.UseRouting();


//            app.UseAuthorization();

//            app.UseEndpoints(endpoints =>
//            {
//                endpoints.MapControllerRoute(
//                    name: "default",
//                    pattern: "{controller=Home}/{action=Index}/{id?}");
//            });

//            var builder = WebApplication.CreateBuilder(args);

//            // Add services to the container.
//            builder.Services.AddControllersWithViews();

//            var app = builder.Build();

//            // Configure the HTTP request pipeline.
//            if (!app.Environment.IsDevelopment())
//            {
//                app.UseExceptionHandler("/Home/Error");
//                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//                app.UseHsts();
//            }

//            app.UseHttpsRedirection();
//            app.UseStaticFiles();

//            app.UseRouting();

//            app.UseAuthorization();

//            app.MapControllerRoute(
//                name: "default",
//                pattern: "{controller=Home}/{action=Index}/{id?}");

//            app.Run();
//        }

//    }
//}
