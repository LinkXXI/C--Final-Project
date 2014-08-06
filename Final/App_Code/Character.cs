using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final
{
    public class Character
    {
        public string CharacterName { get; set; }
        public string Class { get; set; }
        public int Attack { get; set; }
        public int Health { get; set; }
        public int DamageTaken { get; set; }
        public int Days { get; set; }
        public int EnemyLevel { get; set; }
        public int CurrentHealth { 
            get { 
                return Health - DamageTaken;
            }
        }
        public string SqlInsert { 
            get 
            {
                return "INSERT INTO [Character]([CharacterName],[Class],[Attack],[Health],[DamageTaken],[Days],[EnemyLevel]) VALUES('" + CharacterName + "','" + Class + "', " + Attack + ", " + Health + ", " + DamageTaken + ", " + Days + ", " + EnemyLevel + ");";
            } 
        }
        public string ToString(){
            return CharacterName + " the " + Class + " Health: " + CurrentHealth + "/" + Health;
        }
    }
}