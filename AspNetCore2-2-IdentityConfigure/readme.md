# Read me - Identity configuration change primary key datatype to integer

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
```

4. cmd on root folder. 
5. dotnet ef migrations add InitialCreate(comment that you like)
6. dotnet ef database update