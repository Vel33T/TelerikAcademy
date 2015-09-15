using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    public class ShootingEngine : Engine
    {
        public ShootingEngine(IRenderer renderer, IUserInterface uInterface, int sleepTime)
            : base(renderer, uInterface, sleepTime)
        {
        }

        public void ShootPlayerRacket()
        {
        }
    }
}
