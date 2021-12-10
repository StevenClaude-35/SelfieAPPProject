using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SelfieAWookie.Core.Infrastructures.Data;
using SelfieAWookies.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SelfieApp.UI.Controllers
{
    
    [Route("api/v1/[controller]")]
    [ApiController]
    public class SelfieController : ControllerBase
    {
        #region Field
        private readonly SelfiesContext _context = null;
        #endregion
        #region Constructors
        public SelfieController(SelfiesContext context)
        {
            _context = context;
        }
        #endregion
        [HttpGet]
        public IActionResult Get()
        {
            //var model = Enumerable.Range(1, 10).Select(item => new Selfie() { Id = item });

            //return this.StatusCode(StatusCodes.Status204NoContent);

            var model = _context.Selfies.Include(item=>item.Wookie).Select(item=>new { Title = item.Title, WookieId = item.WookieId,NbreSelfieonWookie=item.Wookie.Selfies.Count}).ToList();
            return this.Ok(model);
        }
    }
}