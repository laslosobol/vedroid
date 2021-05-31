namespace Vedroid.BLL.DTO
{
    public class DrinkDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public double AveragePrice { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj is null) return false;
            return GetHashCode() == obj.GetHashCode();
        }

        public override int GetHashCode() => (Id, Name, Type, AveragePrice).GetHashCode();
    }
}