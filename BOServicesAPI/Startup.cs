using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.DataProtection;
using BOServicesAPI.BusinessLogic;
using BOServicesAPI.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.PlatformAbstractions;

namespace BOServicesAPI
{
    public class Startup
    {

        public string securityKeyJWT = string.Empty;
        public string issuerJWT = string.Empty;
        public string audienceJWT = string.Empty;
        public bool IsValidateIssuer = false;
        public bool IsValidateAudience = false;
        public bool IsValidateIssuerSigningKey = false;
        public bool IsValidateLifetime = false;
        public string versionAPI = string.Empty;
        private static NLog.Logger _log;


        public Startup(IConfiguration configuration)
        {
            _log = NLog.LogManager.GetCurrentClassLogger();
            Configuration = configuration;
            securityKeyJWT = Configuration["GlobalParameters:securityKeyJWT"];
            issuerJWT = Configuration["GlobalParameters:issuerJWT"];
            audienceJWT = Configuration["GlobalParameters:audienceJWT"];
            IsValidateIssuer = Convert.ToBoolean(Configuration["GlobalParameters:IsValidateIssuer"]);
            IsValidateAudience = Convert.ToBoolean(Configuration["GlobalParameters:IsValidateAudience"]);
            IsValidateIssuerSigningKey = Convert.ToBoolean(Configuration["GlobalParameters:IsValidateIssuerSigningKey"]);
            IsValidateLifetime = Convert.ToBoolean(Configuration["GlobalParameters:IsValidateLifetime"]);
            versionAPI = Configuration["GlobalParameters:versionService"];


            _log.Info("Version BackOffice Service API:{0}", versionAPI);

        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = IsValidateIssuer,
                    ValidateAudience = IsValidateAudience,
                    ValidateIssuerSigningKey = IsValidateIssuerSigningKey,
                    ValidIssuer = issuerJWT,
                    ValidAudience = audienceJWT,
                    ValidateLifetime = IsValidateLifetime,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKeyJWT))
                };

            });
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            services.AddDbContext<OxxoBoContext>(options => options.UseSqlServer(Configuration["ConnectionStrings:DefaultConnection"]));

            services.AddMvc(options =>
            {
                options.Filters.Add(new ProducesAttribute("application/xml"));
                options.EnableEndpointRouting = false;
            }).AddXmlSerializerFormatters();

            services.AddSwaggerGen(c =>
            {
                // Para la auto documentacion en Swagger
                c.SwaggerDoc(SwaggerConfiguration.DocNameV1, new OpenApiInfo
                {
                    Title = SwaggerConfiguration.DocInfoTitle,
                    Version = SwaggerConfiguration.DocInfoVersion,
                    Description = SwaggerConfiguration.DocInfoDescription,
                    Contact = new OpenApiContact
                    {
                        Name = SwaggerConfiguration.ContactName,
                        Url = new Uri(SwaggerConfiguration.ContactUrl),
                    }

                });

                // Para definir la autorizacion por Bearer token 
                var securitySchema = new OpenApiSecurityScheme
                {
                    Description = "JWT Authorization header using the Bearer scheme. Example: \"Authorization: Bearer {token}\"",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.Http,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    Reference = new OpenApiReference
                    {
                        Type = ReferenceType.SecurityScheme,
                        Id = "Bearer"
                    }
                };

                c.AddSecurityDefinition("Bearer", securitySchema);

                var securityRequirement = new OpenApiSecurityRequirement
                {
                    { securitySchema, new[] { "Bearer" } }
                };

                c.AddSecurityRequirement(securityRequirement);

                c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First()); //This line

                //Para leer los auto comentarios dentro del xml que se genera 

                // Set the comments path for the Swagger JSON and UI.
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseAuthentication();
            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseSwagger();
            //Para indicar de donde debe tomar el estilo de la plantilla de Swagger
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("v1.0.0/swagger.json", "BO Service API");
                c.InjectStylesheet("/swagger-custom/swagger-custom-styles.css");

            });
            app.UseMvc();
        }
    }
}
