
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LeVanDuyTung2410900085_exam.Models;

public class LvdtStudentsController : Controller
{
    private readonly LvdtDbContext _context;

    public LvdtStudentsController(LvdtDbContext context)
    {
        _context = context;
    }

    // GET: LVDTSTUDENTS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.LvdtStudents.ToListAsync());
    }

    // GET: LVDTSTUDENTS/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var lvdtstudent = await _context.LvdtStudents
            .FirstOrDefaultAsync(m => m.Id == id);
        if (lvdtstudent == null)
        {
            return NotFound();
        }

        return View(lvdtstudent);
    }

    // GET: LVDTSTUDENTS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: LVDTSTUDENTS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,LvdtName,LvdtGender,LvdtBirthDay,LvdtEmail,LvdtPhone,LvdtActive")] LvdtStudent lvdtstudent)
    {
        if (ModelState.IsValid)
        {
            _context.Add(lvdtstudent);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(lvdtstudent);
    }

    // GET: LVDTSTUDENTS/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var lvdtstudent = await _context.LvdtStudents.FindAsync(id);
        if (lvdtstudent == null)
        {
            return NotFound();
        }
        return View(lvdtstudent);
    }

    // POST: LVDTSTUDENTS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("Id,LvdtName,LvdtGender,LvdtBirthDay,LvdtEmail,LvdtPhone,LvdtActive")] LvdtStudent lvdtstudent)
    {
        if (id != lvdtstudent.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(lvdtstudent);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LvdtStudentExists(lvdtstudent.Id))
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
        return View(lvdtstudent);
    }

    // GET: LVDTSTUDENTS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var lvdtstudent = await _context.LvdtStudents
            .FirstOrDefaultAsync(m => m.Id == id);
        if (lvdtstudent == null)
        {
            return NotFound();
        }

        return View(lvdtstudent);
    }

    // POST: LVDTSTUDENTS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var lvdtstudent = await _context.LvdtStudents.FindAsync(id);
        if (lvdtstudent != null)
        {
            _context.LvdtStudents.Remove(lvdtstudent);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool LvdtStudentExists(int? id)
    {
        return _context.LvdtStudents.Any(e => e.Id == id);
    }
}
