using CRUD.BLL.Interfaces;
using CRUD.DAL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Data;

namespace CRUD_Operation_App.Controllers
{
    [Authorize]
    public class DepartmentController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public DepartmentController(IUnitOfWork unitOfWork) 
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {

            var departments = _unitOfWork.DepartmentReposetory.GetAll();
            return View(departments);
        }
        [HttpGet]
        public IActionResult Create() //Create_دى هتودينى ع صفحة ال  
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Create(Department department)//Create-ال_submit_دى هتودينى ع صفحة اللى ه 
        {
            if(ModelState.IsValid) //Server side Validation
            {
                _unitOfWork.DepartmentReposetory.Add(department);
                var count = _unitOfWork.Complete();

                if (count > 0)
                    TempData["Message"] = "Department Is Created Successfully";

                else
                    TempData["Message"] = "An Error Has Occured , Department Not Created !!";
                _unitOfWork.Complete();
                return RedirectToAction(nameof(Index));
            }
            return View(department);    
        }
        // /Departmeent/Details
        [HttpGet]
        public IActionResult Details(int? id ,string viewName="Details") 
        {
            if (!id.HasValue)
                return BadRequest(); //400

            var department = _unitOfWork.DepartmentReposetory.Get(id.Value);

            if(department is null)
                return NotFound(); //404

            return View(viewName,department);
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {

            ///if (!id.HasValue)
            ///    return BadRequest();
            ///var department = _departmentReposetory.Get(id.Value);
            ///if(department is null)
            ///    return NotFound();
            ///   return View(department);

            return Details(id , "Edit");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit([FromRoute] int id,Department department)
        {
            if(id != department.Id)
                return BadRequest();

            if (ModelState.IsValid)
            {
                try
                {
                    _unitOfWork.DepartmentReposetory.Update(department);
                    _unitOfWork.Complete();
                    return RedirectToAction(nameof(Index));
                }
                catch(Exception ex)
                {
                    // 1. Log Exception
                    // 2. Friendly Message
                    ModelState.AddModelError(string.Empty, ex.Message);
                }
            }
            return View(department);
        }
        // /Department/Delete
        // /Department/Delete/1

        //[HttpGet]
        public IActionResult Delete(int? id)
        {
            return Details(id, "Delete");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete([FromRoute] int id,Department department)
        {
            if (id != department.Id)
                return BadRequest();

            try
            {
                _unitOfWork.DepartmentReposetory.Delete(department);
                _unitOfWork.Complete();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                // 1. Log Exception
                // 2. Friendly Message
                ModelState.AddModelError(string.Empty, ex.Message);
                return View(department);

            }
            //return View(department);

        }
    }
}
