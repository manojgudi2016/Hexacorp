using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFCrudOperationDemoApp.BO;

namespace EFCrudOperationDemoApp.Controllers
{
    public class EmployeeController : Controller
    {

        EmployeeBO objEmpBO = new EmployeeBO();
        //
        // GET: /Employee/

        public ActionResult Index()
        {
            var employees = objEmpBO.GetAll();
            return View(employees.ToList());
        }

        //
        // GET: /Employee/Details/5

        public ActionResult Details(int id = 0)
        {
            Employee employee = objEmpBO.GetDetails(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        //
        // GET: /Employee/Create

        public ActionResult Create()
        {
            DepartmentBO objDeptBO = new DepartmentBO();
            ViewBag.DeptId = new SelectList(objDeptBO.GetAll(), "DeptId", "DeptName");
            return View();
        }

        //
        // POST: /Employee/Create

        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                objEmpBO.Insert(employee);
                return RedirectToAction("Index");
            }
            DepartmentBO objDeptBO = new DepartmentBO();
            ViewBag.DeptId = new SelectList(objDeptBO.GetAll(), "DeptId", "DeptName");
            return View(employee);
        }

        //
        // GET: /Employee/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Employee employee = objEmpBO.GetDetails(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            DepartmentBO objDeptBO = new DepartmentBO();
            ViewBag.DeptId = new SelectList(objDeptBO.GetAll(), "DeptId", "DeptName",employee.DeptId);
            return View(employee);
        }

        //
        // POST: /Employee/Edit/5

        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                objEmpBO.Update(employee);
                return RedirectToAction("Index");
            }
            DepartmentBO objDeptBO = new DepartmentBO();
            ViewBag.DeptId = new SelectList(objDeptBO.GetAll(), "DeptId", "DeptName", employee.DeptId);
            return View(employee);
        }

        //
        // GET: /Employee/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Employee employee = objEmpBO.GetDetails(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        //
        // POST: /Employee/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            objEmpBO.Delete(id);
            return RedirectToAction("Index");
        }

    }
}