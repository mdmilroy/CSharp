// Pupil.cs
using System;

namespace MagicalInheritance
{
  public class Pupil
  {
    public string Title { get; private set; }
    
    public Pupil(string title)
    {
      Title = title;
    }
    
    public Storm CastWindStorm()
    {
      Storm storm = new Storm("wind", false, Title);
      return storm;
    }
  }
}
