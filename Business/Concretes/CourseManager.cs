using Business.Abstracts;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes;

public class CourseManager : ICourseService
{

    ICourseDal _iCourseDal;

    public CourseManager(ICourseDal iCourseDal)
    {
        _iCourseDal = iCourseDal;
    }

    public async Task Add(Course course)
    {

        await _iCourseDal.AddAsync(course);
    }

    public Task<IPaginate<Course>> GetListAsync()
    {

        return _iCourseDal.GetListAsync();

    }
}
