using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using src.api.ViewModel;

namespace src.api.Controllers.v1
{
    [Route("api/v1/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IActionResult Get([FromQuery]int pageSize = 10, [FromQuery]int pageIndex = 0)
        {
            var items = new List<string>
            {
                "i01", "i02", "i03", "i04", "i05", "i06", "i07", "i08", "i09", "i10",
                "i11", "i12", "i13", "i14", "i15", "i16",
            };

            var total = items.Count;

            List<string> itemsOnPage;
            if (pageSize * pageIndex + pageSize > total)
            {
                itemsOnPage = items.GetRange(pageSize * pageIndex, total - pageSize * pageIndex);
            }
            else
            {
                itemsOnPage = items.GetRange(pageSize * pageIndex, pageSize);
            }
            
            var model = new PaginatedItemsViewModel<string>(
                pageIndex, pageSize, total, itemsOnPage
            );

            return Ok(model);
        }

        // GET api/values/5
        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            return Ok($"value {id}");
        }

        // POST api/values
        [HttpPost]
        public IActionResult InsertOrUpdate([FromBody]string value)
        {
            if (value == null)
            {
                return NotFound();
            }

            return Ok(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody]string value)
        {
            if (value == null)
            {
                return NotFound();
            }

            return Ok(value);
        }

        // DELETE api/values/5
        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            return Ok($"{id}");
        }
    }
}
