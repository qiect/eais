﻿using Haowen.Configurations;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.MySQL;
using Volo.Abp.EntityFrameworkCore.PostgreSql;
using Volo.Abp.EntityFrameworkCore.Sqlite;
using Volo.Abp.EntityFrameworkCore.SqlServer;
using Volo.Abp.Modularity;

namespace Haowen.EntityFrameworkCore;

[DependsOn(
    typeof(TemplateDomainModule),
    typeof(AbpEntityFrameworkCoreModule),
    typeof(AbpEntityFrameworkCoreMySQLModule),
    typeof(AbpEntityFrameworkCoreSqlServerModule),
    typeof(AbpEntityFrameworkCorePostgreSqlModule),
    typeof(AbpEntityFrameworkCoreSqliteModule)
    )]
public class TemplateEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<TemplateDbContext>(options =>
        {
            options.AddDefaultRepositories(includeAllEntities: true);
        });

        Configure<AbpDbContextOptions>(options =>
        {
            switch (AppSettings.EnableDb)
            {
                case "MySQL":
                    options.UseMySQL();
                    break;
                case "SqlServer":
                    options.UseSqlServer();
                    break;
                case "PostgreSql":
                    options.UsePostgreSql();
                    break;
                case "Sqlite":
                    options.UseSqlite();
                    break;
                default:
                    options.UseMySQL();
                    break;
            }
        });
    }
}
