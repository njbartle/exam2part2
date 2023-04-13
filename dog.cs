using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exam2pt2.exam2part2
{
    public class Dog
    {
        public string name {get; set ;}
        public ITrick TBehavior {get; set;}
        public Dog()
        {
            TBehavior = new Sit();
        }
    }
}