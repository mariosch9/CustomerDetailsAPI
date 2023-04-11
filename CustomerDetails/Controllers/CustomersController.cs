using CustomerDetails.Models;
using CustomerDetails.Services;
using Microsoft.AspNetCore.Mvc;

namespace CustomerDetails.Controllers
{
    public class CustomersController : Controller
    {
        private readonly IService<Customers> _customersService;

        public CustomersController(IService<Customers> customersService)
        {
            _customersService = customersService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _customersService.GetAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _customersService.GetByIdAsync(id.Value);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,Email,Address")] Customers customer)
        {
            var exist = await _customersService.GetByIdAsync(customer.Id, log: false) != null;
            if (!exist)
            {
                await _customersService.AddAsync(customer);
            }

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _customersService.GetByIdAsync(id.Value, log: false);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,Email,Address")] Customers customer)
        {
            if (id != customer.Id)
            {
                return NotFound();
            }

            await _customersService.UpdateAsync(customer);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _customersService.GetByIdAsync(id.Value, log: false);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customer = await _customersService.GetByIdAsync(id, log: false);
            if (customer == null)
            {
                return NotFound();
            }

            await _customersService.DeleteAsync(customer);
            return RedirectToAction(nameof(Index));
        }
    }
}
