using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public List<CelestialBody> GetSortedSolarSystemByOrbitalPeriodAsync()
        {
            return CelestialBodies.OrderBy(t => t.OrbitalPeriod).ToList();
        }
    }
}
