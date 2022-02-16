using AIHR_Task2.Models.PlanetsCategory;

namespace AIHR_Task2.Models.Planets.Stars
{
    public sealed class Sun: Star
    {
        public Sun()
        {
            DistanceFromSun = 0;
            Mass = 1988500;
            Name = "Sun";
            OrbitalPeriod = 226;
        }
            
    }
}
