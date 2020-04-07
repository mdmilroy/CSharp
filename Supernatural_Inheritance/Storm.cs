// Storm.cs
using System;

namespace MagicalInheritance
{
  public class Storm
  {
    public string Essence { get; private set; }
    public bool IsStrong { get; private set; }
    public string Caster { get; private set; }
    
    public Storm(string essence, bool isstrong, string caster)
    {
      Essence = essence;
      IsStrong = isstrong;
      Caster = caster;
    }
    
    public void Announce()
    {
      if (!IsStrong)
      {
        Console.WriteLine($"{Caster} cast a weak {Essence} storm!");
      }
      else
      {
        Console.WriteLine($"{Caster} cast a strong {Essence} storm!");
      }
    }
  }
}
