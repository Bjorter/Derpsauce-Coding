using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo05
{
    class Circle : DrawingObject
    {
        public override void Draw()
        {
            //throw new NotImplementedExceptionException;
            Console.WriteLine("Draw circle!");
        }
    }
}
