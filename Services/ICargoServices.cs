//This is our menu
//Think of Interface as a contract
//It is a list of what our CargoServices MUST do. This is not where th data is kept
using Combine_Day_Ten_API_Continued.Models;

namespace Combine_Day_Ten_API_Continued.Services
{
    public interface ICargoServices
    {
        //we are Creating, Updating, Reading, and Deleting Data 

        List<CargoItem> GetAll();

        List<CargoItem> GetByCatagory(string Catagory);

        CargoItem GetById(int id);

        CargoItem Create(CargoItem item);

        bool Update(int id, CargoItem item);

        bool Delete(int id);
    }
}