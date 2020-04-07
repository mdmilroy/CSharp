// Mage.cs
using System;

namespace MagicalInheritance
{
  public class Mage : Pupil
  {
    public Mage(string Title) : base(Title) {}
    
    public virtual Storm CastRainStorm()
    {
      Storm storm = new Storm("rain", false, Title);
      return storm;
    }
  }
  

}
