using System;

public class Dog : Animal
{
	public Dog()
	{
	}

	public void Speak()
    {
		Console.WriteLine($"{Name} barks");
    }
}
