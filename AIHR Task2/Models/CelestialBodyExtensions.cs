using AIHR_Task2.Interfaces;

namespace AIHR_Task2.Models
{
    public static class CelestialBodyExtensions
    {
        public static bool Colonize(this IColonizable celestialBody)
        {
            return true;
        }
    }
}
