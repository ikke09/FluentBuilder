using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentBuilder.Tests
{
    class Car
    {
        [Required]
        public int Id { get; set; }

        public string Manufacturer { get; set; }

        public double Power { get; set; }
    }

    [TestClass]
    public class SimpleBuilderTests
    {
        [TestMethod]
        public void BuilderCreatesDefaultObject()
        {
            var builder = new FluentBuilder<Car>();
            Car car = builder.Create();
            car.Should().NotBeNull();
        }

        [TestMethod]
        public void BuilderCreatesObjectWithRequiredProperty()
        {
            var builder = new FluentBuilder<Car>();
            Car car = builder.Create(1);
            car.Should().NotBeNull();
            car.Id.Should().Be(1);
        }

        [TestMethod]
        public void BuilderCreatesObjectWithAttributes()
        {
            var builder = new FluentBuilder<Car>();
            Car car = builder.Create(1)
                .WithManufacturer("BMW")
                .WithPower(100);

            car.Should().NotBeNull().And.BeEquivalentTo(new
            {
                Id = 1,
                Manufacturer = "BMW",
                Power = 100
            });
        }
    }
}
