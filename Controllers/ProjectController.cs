using Assesment.Models;
using Assesment.Service_class;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assesment.Controllers
{
    public class ProjectController : Controller
    {

        public IActionResult Index()
        {

            
            ProjectClass pro = new ProjectClass();

            var UserDetails = pro.getName();

            return View(UserDetails);

        }


        public PartialViewResult ProjectList()
        {


            ProjectClass pro = new ProjectClass();

            var UserDetails = pro.getName();

            return PartialView("ProjectList",UserDetails);

        }


        public IActionResult Add()
        {
            return View();
        }
       
        public IActionResult Update(int Id)
        {
            ProjectClass pro = new ProjectClass();

            var UserDetails = pro.GetProject(Id);
           
            return View(UserDetails);
        }




        public JsonResult SaveProject([FromForm] ProjectDatamodel objmodel)
        {


            ProjectClass pro = new ProjectClass();

            var result = pro.SaveProject(objmodel);

            return Json(result);
        }

        public JsonResult UpdateProject([FromForm] ProjectDatamodel objmodel)
        {

            ProjectClass pro = new ProjectClass();

            var result = pro.UpdateProject(objmodel);

            return Json(result);
        }


        public JsonResult GetProject(int Id)
        {
            ProjectClass pro = new ProjectClass();

            var UserDetails = pro.GetProject(Id);

            return Json(UserDetails);
        }
        [HttpPost]
        public JsonResult getdatabyDropdownselection(ProjectDatamodel obj)
        {
            ProjectClass pro = new ProjectClass();

            var UserDetails = pro.getdatabyDropdownselection(obj);

            return Json(UserDetails);
        }



        public JsonResult DeleteProject(int Id)
        {

            ProjectClass pro = new ProjectClass(); 

            var result = pro.DeleteProject(Id);

            return Json(result);
        }


        

    }
}
