
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LeVanDuyTung2410900085_exam.Models;

public class LvdtEmployeesController : Controller
{
    private readonly LvdtDbContext _context;

    public LvdtEmployeesController(LvdtDbContext context)
    {
        _context = context;
    }

    // GET: LVDTEMPLOYEES
    public async Task<IActionResult> Index()    
    {
        return View(await _context.LvdtEmployees.ToListAsync());
    }

    // GET: LVDTEMPLOYEES/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var lvdtemployee = await _context.LvdtEmployees
            .FirstOrDefaultAsync(m => m.Id == id);
        if (lvdtemployee == null)
        {
            return NotFound();
        }

        return View(lvdtemployee);
    }

    // GET: LVDTEMPLOYEES/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: LVDTEMPLOYEES/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,LvdtName,LvdtGender,LvdtBirthDay,LvdtEmail,LvdtPhone,LvdtActive")] LvdtEmployee lvdtemployee)
    {
        if (ModelState.IsValid)
        {
            _context.Add(lvdtemployee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(lvdtemployee);
    }

    // GET: LVDTEMPLOYEES/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var lvdtemployee = await _context.LvdtEmployees.FindAsync(id);
        if (lvdtemployee == null)
        {
            return NotFound();
        }
        return View(lvdtemployee);
    }

    // POST: LVDTEMPLOYEES/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("Id,LvdtName,LvdtGender,LvdtBirthDay,LvdtEmail,LvdtPhone,LvdtActive")] LvdtEmployee lvdtemployee)
    {
        if (id != lvdtemployee.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(lvdtemployee);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LvdtEmployeeExists(lvdtemployee.Id))
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
        return View(lvdtemployee);
    }

    // GET: LVDTEMPLOYEES/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var lvdtemployee = await _context.LvdtEmployees
            .FirstOrDefaultAsync(m => m.Id == id);
        if (lvdtemployee == null)
        {
            return NotFound();
        }

        return View(lvdtemployee);
    }

    // POST: LVDTEMPLOYEES/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var lvdtemployee = await _context.LvdtEmployees.FindAsync(id);
        if (lvdtemployee != null)
        {
            _context.LvdtEmployees.Remove(lvdtemployee);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool LvdtEmployeeExists(int? id)
    {
        return _context.LvdtEmployees.Any(e => e.Id == id);
    }
}
