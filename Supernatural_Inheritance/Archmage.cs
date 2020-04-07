// Archmage.cs
using System;

namespace MagicalInheritance
{
 public class Archmage : Mage
 {
   public Archmage(string Title) : base(Title) {}
   
   public override Storm CastRainStorm()
   {
     Storm storm = new Storm("rain", true, Title);
     return storm;
   }
   
   public Storm CastLightningStorm()
   {
     Storm storm = new Storm("lightning", true, Title);
     return storm;
   }
 }
}
