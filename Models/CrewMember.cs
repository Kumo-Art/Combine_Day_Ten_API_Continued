//A Model is just a normal C# class describing one thing your API works with
//This will describe the shape of our Data for our crew member
using Microsoft.AspNetCore.SignalR;
using Microsoft.Net.Http.Headers;

namespace Combine_Day_Ten_API_Continued.Models
{
    public class CrewMember
    {
        
        public int Id { get; set;}
        public string Name { get; set;} //get - allows us to give this property value, and set - allows us to change it

        public string Rank { get; set;}

        public string Sector { get; set;}

        public bool IsOnDuty { get; set;}
    }
}



//CrewMember crew = new CrewMember();
//crew.Name = "Brandon"; <- this would be set
//Console.WriteLine(crew.Name); <- this is get