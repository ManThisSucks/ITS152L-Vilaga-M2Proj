using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AudioDataLibrary.Data;
using AudioDataLibrary.Models;
using System.Collections.Generic;

namespace AudioDataLibrary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly SqlData _data;

        public ItemsController(SqlData data)
        {
            _data = data;
        }

        // GET: api/items
        [HttpGet]
        public ActionResult<List<ItemModel>> GetItems()
        {
            var items = _data.getItems();
            return Ok(items);
        }

        // GET: api/items/{id}
        [HttpGet("{id}")]
        public ActionResult<ItemModel> GetItem(int id)
        {
            var items = _data.getItems();
            var item = items.FirstOrDefault(i => i.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        // POST: api/items
        [HttpPost]
        public IActionResult CreateItem(ItemModel item)
        {
            _data.AddItem(item);
            return CreatedAtAction(nameof(GetItem), new { id = item.Id }, item);
        }

        // PUT: api/items/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateItem(int id, ItemModel item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            _data.UpdateItem(item);
            return NoContent();
        }

        // DELETE: api/items/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteItem(int id)
        {
            _data.DeleteItem(id);
            return NoContent();
        }
    }
}
