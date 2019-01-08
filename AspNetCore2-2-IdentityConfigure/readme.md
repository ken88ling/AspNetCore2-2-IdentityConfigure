# Read me - Identity configuration change type

1. Delete migrations folder which auto generated
2. Create 2 .cs which is ApplicationUser, ApplicationRole
3. Replace the code at Statup.cs => ConfigureServices()


```c#
 public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<ApplicationUser, ApplicationRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultUI()
                .AddDefaultTokenProviders();

        }