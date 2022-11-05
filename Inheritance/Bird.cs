using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Bird : Animal
    {
       public string food { get; set; }

       

       public double flythSpeed { get; set; }


        public void lifeEnviroment() 
        {

          Console.WriteLine("Birds can hide from predator and inclementweather");
        
        }
        public string BirdMesure(int ms, string v) 
        {
            
            var sd2 = "inches";
            return  ms  + sd2;
           
      


        }



    }
}
