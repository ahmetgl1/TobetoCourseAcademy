using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context;

public class TobetoCourseAcademyDb : DbContext
{


    protected IConfiguration Configuration { get; set; }



    DbSet<Course> Courses { get; set; }


    public TobetoCourseAcademyDb(DbContextOptions dbContextOptions, IConfiguration configuration) : base(dbContextOptions)
    {


        Configuration = configuration; Database.EnsureCreated();

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

    }





}
