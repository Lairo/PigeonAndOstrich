using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigeonAndOstrich
{
    internal class Pigeon : Bird
    {
        public override Egg[] LayEggs(int numberOfEggs)
        {
            int a = Bird.Randomizer.Next(2);
            Egg[] eggs = new Egg[numberOfEggs];
            for (int i = 0; i < numberOfEggs; i++)
            {
                {
                    if(i == 1 || i == a )
                    {

                        if (Bird.Randomizer.Next(4) == 0)
                            eggs[i] = new BrokenEgg("white");
                        else
                            eggs[i] = new Egg(Bird.Randomizer.NextDouble() * 2 + 1, "white");
                    }
                    else
                    {
                         eggs[i] = new Egg(0,"no");
                        
                    }

                }
            }
            return eggs;
        }

    }
}
