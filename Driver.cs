namespace Opdracht
{
    public class Driver : Human
    {
        public string LicenseNumber { get; set; }

        public Driver(string name, int age, string licenseNumber)
            : base(name, age)
        {
            LicenseNumber = licenseNumber;
        }
    }
}