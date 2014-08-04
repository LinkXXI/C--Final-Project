using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final
{
    public class Character
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public int Attack { get; set; }
        public int Health { get; set; }
        public int DamageTaken { get; set; }
        public int CurrentHealth { 
            get { 
                return Health - DamageTaken;
            }
        }
        public string SqlInsert { 
            get 
            { 
                return "INSERT INTO [Character]([CharacterName],[Class],[attack],[health]) VALUES('"+ Name +"','"+ Class +"', "+ Attack +", "+ Health +");";
            } 
        }
        public string ToString(){
            return Name + " the " + Class + " Health: " + CurrentHealth + "/" + Health;
        }
    }
}