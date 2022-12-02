using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4
{
    class Galaxy : IMobiles, IUpdates
    {
        public void call()
        {
            Console.WriteLine("GALAXY _ Call is successfull");
        }

        public void textmessage()
        {
            Console.WriteLine("GALAXY _ Text Message is successfull");
        }
        public void multimedia_using()
        {
            Console.WriteLine("GALAXY _ Tmultimedia_Using is successfull");
        }
    
    }
}
