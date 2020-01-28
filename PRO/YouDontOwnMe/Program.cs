using System;

namespace YouDontOwnMe
{
    class Program
    {
        static void Main(string[] args)
        {
            Johan newJohan = new Johan();
            Console.WriteLine("Lives: " + newJohan.lives);
            Console.WriteLine("Ability's: " );
            newJohan.Jump();
            Console.WriteLine("----------------------------------------");
            Steve newSteve = new Steve();
            Console.WriteLine("Lives: " + newSteve.lives);
            Console.WriteLine("Ability's: " );
            newSteve.Crouch();
            Console.WriteLine("----------------------------------------");
            
        }
    }
}
