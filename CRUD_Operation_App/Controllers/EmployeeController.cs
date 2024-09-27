using AutoMapper;
using CRUD.BLL.Interfaces;
using CRUD.DAL.Models;
using CRUD_Operation_App.Helpers;
using CRUD_Operation_App.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CRUD_Operation_App.Controllers
{
	public class EmployeeController : Controller
	{
		// Dependencies for unit of work and AutoMapper
		// التبعيات لـ UnitOfWork و AutoMapper
		private readonly IUnitOfWork _unitOfWork;
		private readonly IMapper _mapper;

		// Constructor to initialize the dependencies
		// المنشئ لتفعيل التبعيات
		public EmployeeController(IUnitOfWork unitOfWork,IMapper mapper)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
			// _employeeReposetory = employeeReposetory;
			// _departmentRepo = departmentRepo;
		}

		// GET: /Employee/Index
		// يعرض قائمة الموظفين ويمكن البحث باستخدام نص
		public IActionResult Index(string searchInp)
		{
			IEnumerable<Employee> employees;

			// Check if search input is empty or null
			// التحقق مما إذا كان إدخال البحث فارغًا أو فارغًا
			if (string.IsNullOrEmpty(searchInp))
				employees = _unitOfWork.EmployeeReposetory.GetAll(); // Get all employees
			else
				employees = _unitOfWork.EmployeeReposetory.SearchByName(searchInp.ToLower()); // Search employees by name

			// Map Employee entities to EmployeeViewModel
			// تحويل الكائنات Employee إلى EmployeeViewModel
			var mappedEmp = _mapper.Map<IEnumerable<Employee>, IEnumerable<EmployeeViewModel>>(employees);

			return View(mappedEmp);
		}

		// GET: /Employee/Create
		// يعرض نموذج إنشاء موظف جديد
		[HttpGet]
		public IActionResult Create()
		{
			// Optionally populate dropdowns, etc.
			// ربما تملأ القوائم المنسدلة، إلخ.
			//ViewData["Departments"] = _departmentRepo.GetAll();
			return View();
		}

		// POST: /Employee/Create
		// يعالج إرسال نموذج إنشاء موظف جديد
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Create(EmployeeViewModel employeeVM)
		{
			if (ModelState.IsValid) // Server-side validation
			{
				// Upload image and get its name
				// رفع الصورة والحصول على اسمها
				employeeVM.ImageName = DocumentSettings.UploadFile(employeeVM.Image, "Images");

				// Map EmployeeViewModel to Employee
				// تحويل EmployeeViewModel إلى Employee
				var mappedEmp = _mapper.Map<EmployeeViewModel, Employee>(employeeVM);
				_unitOfWork.EmployeeReposetory.Add(mappedEmp);
				_unitOfWork.Complete();

				return RedirectToAction(nameof(Index));
			}
			return View(employeeVM);
		}

		// GET: /Employee/Details/1
		// يعرض تفاصيل موظف معين
		[HttpGet]
		public IActionResult Details(int? id, string viewName = "Details")
		{
			if (!id.HasValue)
				return BadRequest(); // 400 Bad Request

			var employee = _unitOfWork.EmployeeReposetory.Get(id.Value);
			if (employee is null)
				return NotFound(); // 404 Not Found

			// Map Employee entity to EmployeeViewModel
			// تحويل الكائن Employee إلى EmployeeViewModel
			var mappedEmp = _mapper.Map<Employee, EmployeeViewModel>(employee);

			return View(viewName, mappedEmp);
		}

		// GET: /Employee/Edit/1
		// يعرض نموذج تعديل بيانات موظف معين
		[HttpGet]
		public IActionResult Edit(int? id)
		{
			// Optionally populate dropdowns, etc.
			// ربما تملأ القوائم المنسدلة، إلخ.
			//ViewData["Departments"] = _departmentRepo.GetAll();

			return Details(id, "Edit");
		}

		// POST: /Employee/Edit/1
		// يعالج إرسال نموذج تعديل بيانات موظف معين
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Edit([FromRoute] int id, EmployeeViewModel employeeVM)
		{
			if (id != employeeVM.Id)
				return BadRequest(); // 400 Bad Request

			if (ModelState.IsValid)
			{
				try
				{
					// Map EmployeeViewModel to Employee
					// تحويل EmployeeViewModel إلى Employee
					var mappedEmp = _mapper.Map<EmployeeViewModel, Employee>(employeeVM);
					_unitOfWork.EmployeeReposetory.Update(mappedEmp);
					_unitOfWork.Complete();

					return RedirectToAction(nameof(Index));
				}
				catch (Exception ex)
				{
					// Log exception and add a friendly message
					// سجل الاستثناء وأضف رسالة ودية
					ModelState.AddModelError(string.Empty, ex.Message);
				}
			}
			return View(employeeVM);
		}

		// GET: /Employee/Delete/1
		// يعرض تفاصيل موظف لحذفه
		[HttpGet]
		public IActionResult Delete(int? id)
		{
			return Details(viewName: "Delete", id: id);
		}

		// POST: /Employee/Delete/1
		// يعالج إرسال نموذج حذف موظف
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Delete([FromRoute] int id, EmployeeViewModel employeeVM)
		{
			if (id != employeeVM.Id)
				return BadRequest(); // 400 Bad Request

			try
			{
				// Map EmployeeViewModel to Employee
				// تحويل EmployeeViewModel إلى Employee
				var mappedEmp = _mapper.Map<EmployeeViewModel, Employee>(employeeVM);
				_unitOfWork.EmployeeReposetory.Delete(mappedEmp);

				var count = _unitOfWork.Complete();
				if (count > 0)
				{
					// Delete the image associated with the employee
					// حذف الصورة المرتبطة بالموظف
					DocumentSettings.DeleteFile(employeeVM.ImageName, "Images");
				}

				return RedirectToAction(nameof(Index));
			}
			catch (Exception ex)
			{
				// Log exception and add a friendly message
				// سجل الاستثناء وأضف رسالة ودية
				ModelState.AddModelError(string.Empty, ex.Message);
			}
			return View(employeeVM);
		}
	}
}
