using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuning
{
    public class Animal
    {
        public virtual void Behaviour()
        {
        }
    }
    public class Dog : Animal
    {
        // composition in heritance, without enhirite class able to use other class memeber
        public Eye rightEye { get; set; }
        public Eye leftEye { get; set; }
    }
    public class Eye
    {
        public string Color { get; set; }

    }
}
