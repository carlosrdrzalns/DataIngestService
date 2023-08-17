using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataIngestService.DBModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DataIngestService.Controllers
{

    public class BiologicalReactorDataController : ControllerBase
    {
        private readonly DTDataContext ctx;

        public BiologicalReactorDataController(DTDataContext ctx)
        {
            this.ctx = ctx;
        }
        [HttpPost]
        [Route("BiologicalReactorController/postData")]
        public async Task<IActionResult> postData([FromBody] BiologicalReactorData data)
        {
            try
            {
                //BiologicalReactorData data = Newtonsoft.Json.JsonConvert.DeserializeObject<BiologicalReactorData>(jsonData.ValueKind);
                data.ID = Guid.NewGuid();
                data.timestamp = DateTime.UtcNow;
                ctx.BiologicalReactorData.Add(data);
                await ctx.SaveChangesAsync();
                return Ok();
            }
            catch (System.Exception exp)
            {
                return NotFound(exp);
            }
        }

        [HttpGet]
        [Route("BiologicalReactorController/getData")]
        public List<BiologicalReactorData> getData(int nElements)
        {
            List<BiologicalReactorData> biologicalReactorDatas = new List<BiologicalReactorData>();
            biologicalReactorDatas = this.ctx.BiologicalReactorData.OrderByDescending(wd => wd.timestamp).Take(nElements).ToList();
            return biologicalReactorDatas;
        }

    }
}
