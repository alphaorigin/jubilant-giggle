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
    public class CourseMarksController : Controller
    {
        private readonly aspnet_projectDev_A4D1A652_62EC_43A8_BCDD_4045399CA9B1Context _context;

        public CourseMarksController(aspnet_projectDev_A4D1A652_62EC_43A8_BCDD_4045399CA9B1Context context)
        {
            _context = context;
        }

        // GET: CourseMarks
        public async Task<IActionResult> Index()
        {
            return View(await _context.CourseMarks.ToListAsync());
        }

        // GET: CourseMarks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseMarks = await _context.CourseMarks
                .SingleOrDefaultAsync(m => m.ID == id);
            if (courseMarks == null)
            {
                return NotFound();
            }

            return View(courseMarks);
        }

        // GET: CourseMarks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CourseMarks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,StudentId,CourseId,Yeartaken,Semester,CourseMark,CourseGrade,CoursePassed")] CourseMarks courseMarks)
        {
            if (ModelState.IsValid)
            {
                _context.Add(courseMarks);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(courseMarks);
        }

        // GET: CourseMarks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseMarks = await _context.CourseMarks.SingleOrDefaultAsync(m => m.ID == id);
            if (courseMarks == null)
            {
                return NotFound();
            }
            return View(courseMarks);
        }

        // POST: CourseMarks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,StudentId,CourseId,Yeartaken,Semester,CourseMark,CourseGrade,CoursePassed")] CourseMarks courseMarks)
        {
            if (id != courseMarks.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(courseMarks);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CourseMarksExists(courseMarks.ID))
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
            return View(courseMarks);
        }

        // GET: CourseMarks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseMarks = await _context.CourseMarks
                .SingleOrDefaultAsync(m => m.ID == id);
            if (courseMarks == null)
            {
                return NotFound();
            }

            return View(courseMarks);
        }

        // POST: CourseMarks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var courseMarks = await _context.CourseMarks.SingleOrDefaultAsync(m => m.ID == id);
            _context.CourseMarks.Remove(courseMarks);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CourseMarksExists(int id)
        {
            return _context.CourseMarks.Any(e => e.ID == id);
        }
    }
}
