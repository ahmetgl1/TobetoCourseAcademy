using Business.Abstracts;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CoursesController : ControllerBase
{

    ICourseService courseService;

    public CoursesController(ICourseService courseService)
    {
        this.courseService = courseService;
    }


    [HttpPost]
    public async Task<IActionResult> Add([FromBody] Course course)
    {
        var result = courseService.Add(course);
        return Ok(result);
    }


    [HttpGet]
    public async Task<IActionResult> GetList()
    {


        var result = courseService.GetListAsync();


        return Ok(result);
    }









}
