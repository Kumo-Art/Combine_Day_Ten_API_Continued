//This will Model one crate of Cargo

//You can think of it as a form of an object

namespace Combine_Day_Ten_API_Continued.Models
{
    public class CargoItem
    {
        
        public int Id { get; set;} //get allows us to read, set allows us to change value

        public string Name {get;set;}

        public string Catagory {get;set;}

        public int Maskkg {get;set;}

        }
}