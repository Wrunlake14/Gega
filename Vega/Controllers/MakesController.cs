using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vega.Data;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Vega.Models;
using Vega.Models.Resources;
using Microsoft.AspNetCore.Cors;

namespace Vega.Controllers
{
    // [Route("api/[controller]/[action]")]
    [EnableCors("CorsPolicy")]
    public class MakesController : Controller
    {
        //
        private readonly ILogger _logger;
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _context;

       public MakesController(ILoggerFactory loggerFactory, ApplicationDbContext context, IMapper mapper)
        {
            _logger = loggerFactory.CreateLogger<MakesController>();
            _context = context;
            _mapper = mapper;
        }

      //  public IMapper Mapper { get; }

        [HttpGet("api/Makes")]
        public async Task<IEnumerable<MakeResource>> GetMakes()
        { 
          var makes=  await _context.Makes.Include(m => m.Models).ToListAsync();
         //   return Ok(_mapper.Map<List<Make>, List<MakeResource>>(makes));
            return _mapper.Map<List<Make>, List<MakeResource>>(makes);
            //   return Ok(await _context.Makes.Include(m => m.Models).ToListAsync());
        }

    }
}
