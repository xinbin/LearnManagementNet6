using AutoMapper;
using LearnManagement.Web.Constants;
using LearnManagement.Web.Contracts;
using LearnManagement.Web.Data;
using LearnManagement.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LearnManagement.Web.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly UserManager<Employee> userManager;
        private readonly IMapper mapper;
        private readonly ILeaveAllocationRepository leaveAllocationRepository;
        private readonly ILeaveTypeRepository leaveTypeRepository;

        public EmployeesController(UserManager<Employee> userManager,
                                    IMapper mapper,
                                    ILeaveAllocationRepository leaveAllocationRepository,
                                    ILeaveTypeRepository leaveTypeRepository)
        {
            this.userManager = userManager;
            this.mapper = mapper;
            this.leaveAllocationRepository = leaveAllocationRepository;
            this.leaveTypeRepository = leaveTypeRepository;
        }
        // GET: EmployeeController
        public async Task<IActionResult> Index()
        {
            var employees = await userManager.GetUsersInRoleAsync(Roles.User);
            var model = mapper.Map<List<EmployeeListVM>>(employees);
            return View(model);
        }

        // GET: EmployeeController/ViewAllocation/employeeId
        public async Task<ActionResult> ViewAllocation(string id)
        {
            var model = await leaveAllocationRepository.GetEmployeeAllocations(id);
            return View(model);
        }

        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/EditAllocation/5
        public async Task<ActionResult> EditAllocation(int Id)
        {
            var model = await leaveAllocationRepository.GetEmployeeAllocation(Id);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }

        // POST: EmployeeController/EditAllocation/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditAllocation(int id, LeaveAllocationEditVM model)
        {
            try
            {
                // First check the model state..
                if (ModelState.IsValid)
                {
                    // Do the thing, in this case update.
                    // First get original value of data to check against any modifications.
                    var leaveAllocation = await leaveAllocationRepository.GetAsync(model.Id);
                    if (leaveAllocation == null)
                    {
                        return NotFound();
                    }
                    // Change the current state, manually imho, why? - oh because in this case there are specific fields only that we
                    // Are targeting.
                    leaveAllocation.Period = model.Period;
                    leaveAllocation.NumberOfDays = model.NumberOfDays;
                    await leaveAllocationRepository.UpdateAsync(leaveAllocation);

                    return RedirectToAction(nameof(ViewAllocation), new { id = model.EmployeeId });
                }
            }
            catch (Exception ex)
            {
                // ModelState is introduced. You pass an empty string for the first param, and then a custome message in this case:
                ModelState.AddModelError(string.Empty, "An Error Has Occurred. Please try again later");
            }
            // Rebuild the other data on the page that is not passed in the form:
            model.Employee = mapper.Map<EmployeeListVM>(await userManager.FindByIdAsync(model.EmployeeId));
            model.LeaveType = mapper.Map<LeaveTypeVM>(await leaveTypeRepository.GetAsync(model.LeaveTypeId));
            // Specifically take the return view out of the catch.
            return View(model);
        }

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
