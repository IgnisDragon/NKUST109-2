using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using ConsoleApp1.Model;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Controllers.Apis
{
    [Route("api/WaterConsumptions")]
    [ApiController]
    public class WaterConsumptionsController : ControllerBase
    {
        private ApplicationDbContext _context;

        public WaterConsumptionsController(ApplicationDbContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public async Task<List<WaterConsumption>> GetAsync()
        {
            var data = await this._context.waterConsumptions.ToListAsync();
            return data;
        }

        [HttpPut]
        public async Task<WaterConsumption> PutAsync(WaterConsumption water)
        {
            _context.waterConsumptions.Add(water);
            await _context.SaveChangesAsync();

            return water;
        }

        [HttpDelete]
        public async Task<WaterConsumption> DeleteAsync(int id)
        {
            var w = _context.waterConsumptions.Find(id);

            _context.Remove(id);
            await _context.SaveChangesAsync();

            return w;
        }
    }
}
