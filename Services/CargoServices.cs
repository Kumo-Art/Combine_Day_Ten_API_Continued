//Cargo Services will be where our logic happens
//This is our kitchen
using Combine_Day_Ten_API_Continued.Models;

namespace Combine_Day_Ten_API_Continued.Services
{
    //ICargoServices is a PROMISE that this class will implement EVERY method within our Interface
    public class CargoServices : ICargoServices
    {
        
        private static List<CargoItem> _manafest = [
            new CargoItem {Id = 1, Name ="Ration Packs", Catagory = "Food", Maskkg = 240},
            new CargoItem {Id = 2, Name = "Battery Cells", Catagory = "Energy", Maskkg = 1200},
            new CargoItem {Id = 3, Name = "Trauma Kits", Catagory = "Medical", Maskkg = 55},
            new CargoItem {Id = 4, Name = "Healing Potion", Catagory = "Medical", Maskkg = 10}
        ];

         //While our app runs static means it will keep track and not reset the value
        static int newId = 5;

      public List<CargoItem> GetAll()
        {
            return _manafest;
        }

        public List<CargoItem> GetByCatagory(string Catagory)
        {
            //We do not want to Mutate our original List
            //We are putting our Manifest in a copy so there isn't a chance we mutate it
            //Ienumerable = List with specific rules, you can only iterate through it
            IEnumerable<CargoItem> result = _manafest;

            //Linq Queries are handy methods that we use to Query Lists/ Databases
            //Language Integrated Query
            //Where filters out and then stores the condition in a list
            // => is called an arrow function / LMBDA a short hand for an anomous function
            // this will run once per item c=> c.Catagory == Catagory
            result = result.Where(c => c.Catagory == Catagory);

            return result.ToList();
        }

       public CargoItem GetById(int id)
        {
            CargoItem? item = _manafest.FirstOrDefault(c => c.Id == id);

            return item;
        }

       public CargoItem Create(CargoItem item)
        {
            
          item.Id = newId;
          newId++;

          _manafest.Add(item);

          return item;

        }

        public bool Update(int id, CargoItem item)
        {
            //FirstOrDefault checks the list against the condition c.Id == id
            //returns the first result or default (null)
            CargoItem existing = _manafest.FirstOrDefault(c => c.Id == id);

            if (existing == null)
            {
                return false;
            }

            existing.Name = item.Name;
            existing.Catagory = item.Catagory;
            existing.Maskkg = item.Maskkg;


            return true;
        }


      public bool Delete(int id)
        {
            CargoItem? existingItem = _manafest.FirstOrDefault(t => t.Id == id);


            if (existingItem is null)
            {
                return false;
            }

            _manafest.Remove(existingItem);

            return true;
        }



    }
}