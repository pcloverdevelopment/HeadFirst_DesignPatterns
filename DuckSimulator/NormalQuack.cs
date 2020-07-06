using System;

namespace DuckSimulator
{
  public class NormalQuack : IQuackBehavior
  {
    public void Quack()
    {
      Console.WriteLine("Quack");
    }
  }
}