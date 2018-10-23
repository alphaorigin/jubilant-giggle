using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using projectDev.Models;

namespace projectDev.Controllers
{
    public class EnrolmentsController : Controller
    {
        private readonly aspnet_projectDev_A4D1A652_62EC_43A8_BCDD_4045399CA9B1Context _context;

        public EnrolmentsController(aspnet_projectDev_A4D1A652_62EC_43A8_BCDD_4045399CA9B1Context context)
        {
            _context = context;
        }

        // GET: Enrolments
        public async Task<IActionResult> Index()
        {
            return View(await _context.Enrolments.ToListAsync());
        }

        // GET: Enrolments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enrolments = await _context.Enrolments
                .SingleOrDefaultAsync(m => m.ID == id);
            if (enrolments == null)
            {
                return NotFound();
            }

            return View(enrolments);
        }

        // GET: Enrolments/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Enrolments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,StudentID,CourseId,YearTaken,Semester")] Enrolments enrolments)
        {
            if (ModelState.IsValid)
            {
                _context.Add(enrolments);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(enrolments);
        }

        // GET: Enrolments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enrolments = await _context.Enrolments.SingleOrDefaultAsync(m => m.ID == id);
            if (enrolments == null)
            {
                return NotFound();
            }
            return View(enrolments);
        }

        // POST: Enrolments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,StudentID,CourseId,YearTaken,Semester")] Enrolments enrolments)
        {
            if (id != enrolments.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(enrolments);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EnrolmentsExists(enrolments.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(enrolments);
        }

        // GET: Enrolments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enrolments = await _context.Enrolments
                .SingleOrDefaultAsync(m => m.ID == id);
            if (enrolments == null)
            {
                return NotFound();
            }

            return View(enrolments);
        }

        // POST: Enrolments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var enrolments = await _context.Enrolments.SingleOrDefaultAsync(m => m.ID == id);
            _context.Enrolments.Remove(enrolments);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EnrolmentsExists(int id)
        {
            return _context.Enrolments.Any(e => e.ID == id);
        }
    }
}
