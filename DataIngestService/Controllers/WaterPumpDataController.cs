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
        public async Task<IActionResult> postData(string jsonData)
        {
            try
            {
                WaterPumpData data = Newtonsoft.Json.JsonConvert.DeserializeObject<WaterPumpData>(jsonData);
                data.Id = Guid.NewGuid();
                data.timestamp = DateTime.UtcNow;
                ctx.WaterPumpData.Add(data);
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
            return waterPumpDatas;
        }

        [HttpPost]
        [Route("waterpumpcontroller/postPredictions")]
        public async Task<IActionResult> postPredictions(string jsonData)
        {
            try
            {
                WaterPumpStatusPredictions data = Newtonsoft.Json.JsonConvert.DeserializeObject<WaterPumpStatusPredictions>(jsonData);
                ctx.WaterPumpStatusPredictions.Add(data);
                await ctx.SaveChangesAsync();
                return Ok();
            }
            catch (System.Exception exp)
            {
                return NotFound(exp);
            }
        }


    }
}
