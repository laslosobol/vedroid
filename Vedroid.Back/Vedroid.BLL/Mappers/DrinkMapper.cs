using Vedroid.BLL.DTO;
using Vedroid.DAL.Entities;

namespace Vedroid.BLL.Mappers
{
    public class DrinkMapper : GenericMapper<Drink, DrinkDto>
    {
        public override Drink Map(DrinkDto dtoEntity)
        {
            return new Drink()
            {
                Id = dtoEntity.Id,
                Name = dtoEntity.Name,
                Type = dtoEntity.Type,
                AveragePrice = dtoEntity.AveragePrice
            };
        }

        public override DrinkDto Map(Drink dataEntity)
        {
            return new DrinkDto()
            {
                Id = dataEntity.Id,
                Name = dataEntity.Name,
                Type = dataEntity.Type,
                AveragePrice = dataEntity.AveragePrice
            };
        }
    }
}