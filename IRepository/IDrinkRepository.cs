
using CRUD_Assignment.Models;

namespace CRUD_Assignment.IRepository;

public interface IDrinkRepository 
{
    Task<IEnumerable<Drink>> GetAllAsync();

    Task<Drink> GetDrinkByIdAsync(int id);

    Task<int> CreateDrinkAsync(Drink Drink);

    Task<int> UpdateDrinkAsync(Drink Drink);

    Task<int> DeleteDrinkAsync(int id);

    Task<double> TotalPriceAsync();

    Task<int> DeleteByQuantityAsync();
}
