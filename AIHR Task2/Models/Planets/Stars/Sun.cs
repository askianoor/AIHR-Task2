using AIHR_Task2.Models.PlanetsCategory;

namespace AIHR_Task2.Models.Planets.Stars
{
    public sealed class Sun: Star
    {
        private static Sun _instance;

        public static Sun GetInstance()
        {
            return _instance ??= new Sun
            {
                DistanceFromSun = 0,
                Mass = 1988500,
                Name = "Sun",
                OrbitalPeriod = 226,
            };
        }
    }
}
