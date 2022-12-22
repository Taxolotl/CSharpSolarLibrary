using System;

namespace SolarLibrary
{
  public class SolarSystem
  {
    public string name;
    public string notes;
    public Star star = new Star();
    public Planet[] planets = new Planet[99];
  }
}
