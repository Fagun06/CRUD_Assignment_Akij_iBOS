using CRUD_Assignment.Data;
using CRUD_Assignment.IRepository;
using CRUD_Assignment.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Assignment.Repository;

public class DrinkRepository : IDrinkRepository
{
    private readonly ApplicationDBContext _Context;

    public DrinkRepository(ApplicationDBContext Context)
    {
        _Context = Context;
    }

    public async Task<int> CreateDrinkAsync(Drink drink)
    {
        try
        {
            int result = 0;
            if (drink == null)
            {
                result = 0;
            }
            else
            {
                await _Context.AddAsync(drink);
                await _Context.SaveChangesAsync();
                result = drink.intColdDrinksld;
            }
            return result;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        
    }

    public async Task<int> DeleteByQuantityAsync()
    {
        var productsToDelete = await _Context.dbAkijFood.Where(x=>x.numQuantity<500).ToListAsync();
        _Context.dbAkijFood.RemoveRange(productsToDelete);
        _Context.SaveChanges();
        return 1;
    }

    public async Task<int> DeleteDrinkAsync(int id)
    {

        try
        {
            if (id == 0)
            {
                return 0;
            }
            else
            {
                var res = await _Context.dbAkijFood.Where(x=>x.intColdDrinksld == id).FirstOrDefaultAsync();
                if (res != null)
                {
                    _Context.dbAkijFood.Remove(res);
                    _Context.SaveChanges();
                    return res.intColdDrinksld;
                }
                return 0;
            }
        }
        catch (Exception ex)
        {

            throw new Exception(ex.Message);
        }
       
    }

    public async Task<IEnumerable<Drink>> GetAllAsync()
    {
        try
        {
            return await _Context.dbAkijFood.ToListAsync();
        }
        catch (Exception ex)
        {
           
            throw new Exception(ex.Message);
        }
    }


    public async Task<Drink> GetDrinkByIdAsync(int id)
    {
        try
        {
            var result = await _Context.dbAkijFood.Where(x => x.intColdDrinksld == id).FirstOrDefaultAsync() ?? null;
            return result;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public async Task<double> TotalPriceAsync()
    {
        var TotalPrice = await _Context.dbAkijFood.SumAsync(x => x.numQuantity * x.numUnitPrice);
        return TotalPrice;
    }

    public async Task<int> UpdateDrinkAsync(Drink drink)
    {
        try
        {
            var result = await _Context.dbAkijFood.Where(x => x.intColdDrinksld == drink.intColdDrinksld).FirstOrDefaultAsync() ?? null;
            if (result != null)
            {
                result.intColdDrinksld = drink.intColdDrinksld;
                result.strColdDrinksName = drink.strColdDrinksName;
                result.numQuantity = drink.numQuantity;
                result.numUnitPrice = drink.numUnitPrice;
                _Context.SaveChanges();
                return result.intColdDrinksld;
            }
            return -1;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
