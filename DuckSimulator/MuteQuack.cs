using System;

namespace DuckSimulator
{
  public class MuteQuack : IQuackBehavior
  {
    public void Quack()
    {
      Console.WriteLine("<< Silence >>");
    }
  }
}