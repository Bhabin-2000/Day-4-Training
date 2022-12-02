using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4
{
    class Nokia : IMobiles
    {
        public void call()
        {
            Console.WriteLine("NOKIA - Call is Successfull !");
        }

        public void textmessage()
        {
            Console.WriteLine("NOLIA - Text Message is Successfull !");
        }
    }

}
