using Core.DataAccess.Repository;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes;

public class EfCouseDal : EfRepositoryBase<Course, int, TobetoCourseAcademyDb>, ICourseDal
{
    public EfCouseDal(TobetoCourseAcademyDb context) : base(context)
    {
    }
}
