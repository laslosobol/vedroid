using Vedroid.BLL.DTO;
using Vedroid.DAL.Entities;

namespace Vedroid.BLL.Mappers
{
    public class SnackMapper : GenericMapper<Snack, SnackDto>
    {
        public override Snack Map(SnackDto dtoEntity)
        {
            return new Snack()
            {
                Id = dtoEntity.Id,
                Name = dtoEntity.Name,
                Type = dtoEntity.Type,
                AveragePrice = dtoEntity.AveragePrice
            };
        }

        public override SnackDto Map(Snack dataEntity)
        {
            return new SnackDto()
            {
                Id = dataEntity.Id,
                Name = dataEntity.Name,
                Type = dataEntity.Type,
                AveragePrice = dataEntity.AveragePrice
            };
        }
    }
}