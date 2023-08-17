using Microsoft.EntityFrameworkCore;
using DataIngestService.DBModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DataIngestService.Controllers
{

    public class WaterPumpDataController : ControllerBase
    {
        private readonly DTDataContext ctx;
        public WaterPumpDataController(DTDataContext ctx)
        {
            this.ctx = ctx;
        }
        [HttpPost]
        [Route("waterpumpcontroller/postData")]
        public async Task<IActionResult> postData([FromBody]WaterPumpData jsonData)
        {
            try
            {                
                jsonData.Id = Guid.NewGuid();
                jsonData.timestamp = DateTime.UtcNow;
                ctx.WaterPumpData.Add(jsonData);
                await ctx.SaveChangesAsync();
                return Ok();
            }catch(System.Exception exp)
            {
                return NotFound(exp);
            }
        }

        [HttpGet]
        [Route("waterpumpcontroller/getData")]
        public List<WaterPumpData> getData(int nElements)
        {
            List<WaterPumpData> waterPumpDatas = new List<WaterPumpData>();
            waterPumpDatas = this.ctx.WaterPumpData.OrderByDescending(wd => wd.timestamp).Take(nElements).ToList();
            waterPumpDatas = waterPumpDatas.OrderBy(x => x.timestamp).ToList();
            return waterPumpDatas;
        }

        [HttpPost]
        [Route("waterpumpcontroller/postPredictions")]
        public async Task<IActionResult> postPredictions([FromBody] WaterPumpStatusPredictions jsonData)
        {
            try
            {
                jsonData.Id = Guid.NewGuid();
                ctx.WaterPumpStatusPredictions.Add(jsonData);
                await ctx.SaveChangesAsync();
                return Ok();
            }
            catch (System.Exception exp)
            {
                return NotFound(exp);
            }
        }

        [HttpGet]
        [Route("waterpumpcontroller/getPredictions")]
        public List<WaterPumpStatusPredictions> getPredictions(int nElements)
        {
            List<WaterPumpStatusPredictions> waterPumpDatas = new List<WaterPumpStatusPredictions>();
            waterPumpDatas = this.ctx.WaterPumpStatusPredictions.OrderByDescending(wd => wd.timestamp).Take(nElements).ToList();
            return waterPumpDatas;
        }



    }
}
