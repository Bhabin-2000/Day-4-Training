using System;

namespace Day_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INTERFACE");
            Console.WriteLine();

            Nokia NOKIA = new Nokia();
            NOKIA.call();
            NOKIA.textmessage();

            Galaxy GALAXY = new Galaxy();
            GALAXY.call();
            GALAXY.textmessage();
            GALAXY.multimedia_using();

        }
    }

    interface IMobiles
    {
        void textmessage();
        void call();
    }
    interface IUpdates
    {
        void multimedia_using();
    }
}
