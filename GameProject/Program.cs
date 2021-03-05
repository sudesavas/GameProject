using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 2,
                BirthYear = 1984,
                FirstName = "SS",
                LastName = "MİRACLE",
                IdentityNumber = 123123
            });
                
                    
                    
           
        }
    }
}
