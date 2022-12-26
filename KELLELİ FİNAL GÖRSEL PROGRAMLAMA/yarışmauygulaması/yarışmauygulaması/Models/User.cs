using System;

namespace yarışmauygulaması.Models
{
    public class User:Personel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime ApplicationDate { get; set; }
        public string JokerNames { get; set; }
        public string[] Jokers { get; set; }

        public User()
        {
            Jokers = JokerNames.Split(',');
        }
    }
}
