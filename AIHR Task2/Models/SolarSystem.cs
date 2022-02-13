using System.Collections.Generic;
using AIHR_Task2.Models.Planets.Stars;

namespace AIHR_Task2.Models
{
    public class SolarSystem
    {
        public IList<CelestialBody> CelestialBodies = new List<CelestialBody>();

        public SolarSystem()
        {
            Add(new Sun());
        }
         
        public void Add(CelestialBody planet)
        {
            CelestialBodies.Add(planet);
        }

        public void Remove(CelestialBody planet)
        {
            CelestialBodies.Remove(planet);
        }
    }
}
