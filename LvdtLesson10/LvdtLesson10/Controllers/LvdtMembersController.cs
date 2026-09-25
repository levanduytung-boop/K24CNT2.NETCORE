
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LvdtLesson10.Models;

public class LvdtMembersController : Controller
{
    private readonly LvdtK24cnt2Lesson10efdbContext _context;

    public LvdtMembersController(LvdtK24cnt2Lesson10efdbContext context)
    {
        _context = context;
    }

    // GET: LvdtMEMBERS
    public async Task<IActionResult> Index()    
    {
        var members = await _context.LvdtMembers.ToListAsync();

        return View("~/Views/LvdtMembers/Index.cshtml", members);
    }

    // GET: LvdtMEMBERS/Details/5
    public async Task<IActionResult> Details(long? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var Lvdtmember = await _context.LvdtMembers
            .FirstOrDefaultAsync(m => m.Id == id);
        if (Lvdtmember == null)
        {
            return NotFound();
        }

        return View(Lvdtmember);
    }

    // GET: LvdtMEMBERS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: LvdtMEMBERS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,LvdtUserName,LvdtPassword,LvdtFullname,LvdtEmail,LvdtPhone,LvdtStatus")] LvdtMember Lvdtmember)
    {
        if (ModelState.IsValid)
        {
            _context.Add(Lvdtmember);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(Lvdtmember);
    }

    // GET: LvdtMEMBERS/Edit/5
    public async Task<IActionResult> Edit(long? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var Lvdtmember = await _context.LvdtMembers.FindAsync(id);
        if (Lvdtmember == null)
        {
            return NotFound();
        }
        return View(Lvdtmember);
    }

    // POST: LvdtMEMBERS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(long? id, [Bind("Id,LvdtUserName,LvdtPassword,LvdtFullname,LvdtEmail,LvdtPhone,LvdtStatus")] LvdtMember Lvdtmember)
    {
        if (id != Lvdtmember.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(Lvdtmember);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LvdtMemberExists(Lvdtmember.Id))
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
        return View(Lvdtmember);
    }

    // GET: LvdtMEMBERS/Delete/5
    public async Task<IActionResult> Delete(long? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var Lvdtmember = await _context.LvdtMembers
            .FirstOrDefaultAsync(m => m.Id == id);
        if (Lvdtmember == null)
        {
            return NotFound();
        }

        return View(Lvdtmember);
    }

    // POST: LvdtMEMBERS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long? id)
    {
        var Lvdtmember = await _context.LvdtMembers.FindAsync(id);
        if (Lvdtmember != null)
        {
            _context.LvdtMembers.Remove(Lvdtmember);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool LvdtMemberExists(long? id)
    {
        return _context.LvdtMembers.Any(e => e.Id == id);
    }
}
