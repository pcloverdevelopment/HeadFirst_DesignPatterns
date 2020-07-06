using System;

namespace DuckSimulator
{
  public class ModelDuck : Duck
  {
    public ModelDuck()
    {
      _flyBehavior = new FlyNoWay();
      _quackBehavior = new NormalQuack();
    }

    public override void Display()
    {
      Console.WriteLine("I'm a model duck");
    }
  }
}