using System;

namespace DuckSimulator
{
  public class MallardDuck : Duck
  {
    public MallardDuck()
    {
      _flyBehavior = new FlyWithWings();
      _quackBehavior = new NormalQuack();
    }

    public override void Display()
    {
      Console.WriteLine("I'm a real Mallard duck");
    }
  }
}