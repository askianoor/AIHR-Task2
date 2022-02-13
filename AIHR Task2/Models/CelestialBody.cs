namespace AIHR_Task2.Models
{
    public abstract class CelestialBody
    {
        public string Name { get; set; }
        public string Picture { get; set; }
        public long DistanceFromSun { get; set; }
        public long OrbitalPeriod { get; set; }
        public long Mass { get; set; }
    }
}
