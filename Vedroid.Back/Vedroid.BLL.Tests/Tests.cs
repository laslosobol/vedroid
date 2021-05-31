using NUnit.Framework;
using Vedroid.BLL.DTO;
using Vedroid.BLL.Mappers;
using Vedroid.DAL.Entities;

namespace Vedroid.BLL.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DrinkMapperTest()
        {
            //Arrange
            var expected = new DrinkDto() {Id = 1, Name = "Beer", Type = "Beer", AveragePrice = 26.30};

            //Act
            var mapper = new DrinkMapper();
            var drink = new Drink() {Id = 1, Name = "Beer", Type = "Beer", AveragePrice = 26.30};
            var actual = mapper.Map(drink);
            
            //Assert
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void SnackServiceGetSnackByIdTest()
        {
            Assert.True(true);
        }
    }
}