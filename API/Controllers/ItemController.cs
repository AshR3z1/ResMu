using API.Dtos;
using API.Interface;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemController : ControllerBase
    {
        private readonly IItemRepository _itemRepository;

        public ItemController(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ItemDto itemDto)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            if (itemDto == null)
            {
                return BadRequest("Restaurant data is null");
            }

            var createdItem = await _itemRepository.CreateAsync(itemDto);

            return CreatedAtAction(nameof(GetItem), new {id= createdItem.Id}, createdItem);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetItem(int id)
        {
            var item = await _itemRepository.GetItemByIdAsync(id);

            if(item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllItems(){
            var items = await _itemRepository.GetAllAsync();
            return Ok(items);
        }
    }
}