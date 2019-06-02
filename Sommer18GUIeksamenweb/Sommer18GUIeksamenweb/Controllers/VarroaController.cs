using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sommer18GUIeksamenweb.Data;
using Sommer18GUIeksamenweb.Data.Migrations;
using Sommer18GUIeksamenweb.Models;

namespace Sommer18GUIeksamenweb.Controllers
{
    [Authorize]
    public class VarroaController : Controller
    {
        private ApplicationDbContext _context;

        public VarroaController(ApplicationDbContext context)
        {
            _context = context; 
        }

        public IActionResult Index()
        {
            return View(from x in _context.VarroaCounts
                where x.User == User.Identity.Name
                select x);
        }

        public IActionResult CreateVarroaCount()
        {
            return View();
        }

        public async Task<IActionResult> Create([Bind("BeehiveId,User,BeeHiveName,Date,AmountOfVarroa,ObservedDays,Note")] VarroaCount varroaCount)
        {
            if (ModelState.IsValid)
            {
                varroaCount.User = User.Identity.Name;
                _context.Add(varroaCount);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Varroa");
            }
            return View("CreateVarroaCount");
        }

    }
}