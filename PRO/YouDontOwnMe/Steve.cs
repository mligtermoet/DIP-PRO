using System;

    public class Steve : Character
    {
        public int CrouchSpeed = 2;
        public void Crouch()
        {
            Console.WriteLine("Crouching");
        }
        public Steve()
        {
            
            name = "Steve";
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Crouching speed: " + CrouchSpeed);

        }
    }
