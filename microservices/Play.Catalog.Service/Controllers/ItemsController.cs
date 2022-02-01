using Microsoft.AspNetCore.Mvc;
using Play.Catalog.Service.Dtos;

namespace Play.Catalog.Service.Controllers;

[ApiController]
[Route("[controller]")]
public class ItemsController : ControllerBase
{
    private static readonly List<ItemDto> items = new()
    {
        new ItemDto(Guid.NewGuid(), "Potion", "Restore a small prtion of HP", 5, DateTimeOffset.UtcNow),
        new ItemDto(Guid.NewGuid(), "Antidote", "Cures Poison", 7, DateTimeOffset.UtcNow),
        new ItemDto(Guid.NewGuid(), "Bronze Sword", "Deals an small amount of damage", 20, DateTimeOffset.UtcNow),
    };

    private readonly ILogger<ItemsController> _logger;

    public ItemsController(ILogger<ItemsController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<ItemDto> Get()
    {
        return items;
    }

    [HttpGet("{id}")]
    public ItemDto GetById(Guid id){
        var item = items.Where(item => item.Id == id).SingleOrDefault();
        return item;
    }

    [HttpPost]
    public ActionResult<ItemDto> Post(CreateItemDto createItemDto){
        var item = new ItemDto(Guid.NewGuid(), createItemDto.Name, createItemDto.Description, createItemDto.Price, DateTimeOffset.UtcNow);
        return CreatedAtAction(nameof(GetById), new { id = item.Id }, item);
    }

    [HttpPut("{id}")]
    public IActionResult Put(Guid id, UpdateItemDto updateItemDto){
        var existingItem = items.Where(item => item.Id == id).SingleOrDefault();

        var updateItem = existingItem with 
        {
            Name = updateItemDto.Name,
            Description = updateItemDto.Description,
            Price = updateItemDto.Price
        };

        var index = items.IndexOf(existingItem);
        items[index] = updateItem;

        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id){
        var index = items.FindIndex(item => item.Id == id);
        items.RemoveAt(index);

        return NoContent();
    }
}
