using System;

namespace SolarLibrary
{
  public class Planet
  {
    public string name;
    public double distance; // in AU
    public string type; // ex. Gas Giant, Dwarf, water-world.
    public string skyColor; 
    public string[] moons = new string[100]; // string of the names of the moons, if any. moons[0] is any notes, and if there is none, it will just say "none"
    public bool rings;
    public double size; // in earth sizes
    public int radius; // in miles
    public double gravity; // g-force
    public int tempHigh; //fahrenheit
    public int tempLow;
    public int tempAvg;
    public string water; //any details on water on the planet
    public bool earthLife;
    public string dayLength;
    public string yearLength;
    public bool seasons;
    public Animal[] animals = new Animal[99];
   }
}
