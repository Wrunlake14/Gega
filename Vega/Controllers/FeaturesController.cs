using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AutoMapper;
using Vega.Data;
using Vega.Models.Resources;
using Microsoft.EntityFrameworkCore;
using Vega.Models;
using Microsoft.AspNetCore.Cors;

namespace Vega.Controllers
{
    [EnableCors("CorsPolicy")]
    public class FeaturesController  : Controller
    {
        private readonly ILogger _logger;
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _context;


        public FeaturesController(ILoggerFactory loggerFactory, ApplicationDbContext context, IMapper mapper)
        {

            _logger = loggerFactory.CreateLogger<FeaturesController>();
            _context = context;
            _mapper = mapper;
        }
        [HttpGet("/api/features")]
        public async Task<IEnumerable<KeyValuePairResource>> GetFeatures()
        {
            var features = await _context.Features.ToListAsync();

            return _mapper.Map<List<Feature>, List<KeyValuePairResource>>(features);

        }

    }
}