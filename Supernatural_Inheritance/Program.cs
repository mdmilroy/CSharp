using System;

namespace MagicalInheritance
{
  class Program
  {
    static void Main(string[] args)
    {
      Storm storm = new Storm("wind", false, "Zul'rajas");
      storm.Announce();
      
      Pupil pupil = new Pupil("Mezil-kree");
      var pupilAttack = pupil.CastWindStorm();
      pupilAttack.Announce();
      
      Mage mage = new Mage("Gul'dan");
      var mageAttack = mage.CastRainStorm();
      mageAttack.Announce();
      
      Archmage archmage = new Archmage("Nielas Aran");
      var rainAttack = archmage.CastRainStorm();
      var lightningAttack = archmage.CastLightningStorm();
      rainAttack.Announce();
      lightningAttack.Announce();
    }
  }
}