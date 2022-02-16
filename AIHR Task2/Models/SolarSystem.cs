using System.Collections.Generic;
using AIHR_Task2.Models.Planets.Stars;

namespace AIHR_Task2.Models
{
    public class SolarSystem
    {
        private IList<CelestialBody> CelestialBodies = new List<CelestialBody> {  new Sun() };

        public SolarSystem()
        {
        }
         
        public void Add(CelestialBody planet)
        {
            if(planet.GetType() != typeof(Sun))
                CelestialBodies.Add(planet);
        }

        public void Remove(CelestialBody planet)
        {
            CelestialBodies.Remove(planet);
        }
    }
}
