using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final
{
    public class Monster
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Attack { get; set; }
        public int Health { get; set; }
        public int DamageTaken { get; set; }
        public int goldReward { get; set; }
        public string imgURL { get; set; }
        public int CurrentHealth
        {
            get
            {
                return Health - DamageTaken;
            }
        }
    }
}