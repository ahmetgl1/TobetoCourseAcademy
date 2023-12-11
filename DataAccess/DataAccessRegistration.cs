using DataAccess.Abstracts;
using DataAccess.Concretes;
using DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess;

public static class DataAccessRegistration
{

    public static IServiceCollection AddDataAccessServices(this IServiceCollection services, IConfiguration configuration)
    {

        services.AddDbContext<TobetoCourseAcademyDb>(options =>
        {
            options.UseInMemoryDatabase("TobetoCourseAcademyDB");



        });



        services.AddScoped<ICourseDal, EfCouseDal>();
        return services;
    }







}
