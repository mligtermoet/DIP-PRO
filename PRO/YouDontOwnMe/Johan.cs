using System;
public class Johan : Character
{
    public int JumpHeight = 5;
    public Johan()
        {
            
            name = "Johan";
            Console.WriteLine("Name: " + name);
            

        }
    public void Jump()
    {
        Console.WriteLine("Jumping");
        Console.WriteLine("Jump height: " + JumpHeight);
    }
}