using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using API.Models;

namespace API.Interface
{
    public interface IItemRepository
    {
        Task<Item> CreateAsync (ItemDto itemDto);
        Task<List<Item>> GetAllAsync();
        Task<Item> GetItemByIdAsync(int id);
    }
}