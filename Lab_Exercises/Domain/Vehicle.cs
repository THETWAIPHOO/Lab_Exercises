namespace Lab_Exercises.Domain
{
    public class Vehicle : BaseDomainModel
    {
        public int Year { get; set; }
        public string? LicensePlateNumber { get; set; }
        public int MakeId { get; set; }
        public int CarModelId { get; set; }
        public int ColourId { get; set; }
    }
}
