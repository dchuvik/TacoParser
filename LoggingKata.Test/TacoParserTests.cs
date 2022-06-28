using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldDoSomething()
        {
            // TODO: Complete Something, if anything

            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);

        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        [InlineData("34.795116, -86.97191, Taco Bell Athens...", -86.97191)]
        [InlineData("34.996237,-85.291147,Taco Bell Chattanooga...", -85.291147)]
        [InlineData("34.8831,-84.293899,Taco Bell Blue Ridg...", -84.293899)]
        [InlineData("34.201107,-86.151229, Taco Bell Boa...", -86.151229)]
        [InlineData("33.444114,-86.826613,Taco Bell Homewood...", -86.826613)]
        [InlineData("33.450442,-86.984822,Taco Bell Hueytow...", -86.984822)]
        [InlineData("34.764965,-86.48607,Taco Bell Huntsvill...", -86.48607)]



        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO: Complete - "line" represents input data we will Parse to - DONE
            //       extract the Longitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

            //Arrange (object created to call method to test)
            var tacoParser = new TacoParser();
            //Act
            var actual = tacoParser.Parse(line).Location.Longitude;
            //Assert
            Assert.Equal(expected, actual);
        }


        //TODO: Create a test ShouldParseLatitude - DONE

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)]
        [InlineData("34.795116, -86.97191, Taco Bell Athens...", 34.795116)]
        [InlineData("34.996237,-85.291147,Taco Bell Chattanooga...", 34.996237)]
        [InlineData("34.8831,-84.293899,Taco Bell Blue Ridg...", 34.8831)]
        [InlineData("34.201107,-86.151229, Taco Bell Boa...", 34.201107)]
        [InlineData("33.444114,-86.826613,Taco Bell Homewood...", 33.444114)]
        [InlineData("33.450442,-86.984822,Taco Bell Hueytow...", 33.450442)]
        [InlineData("34.764965,-86.48607,Taco Bell Huntsvill...", 34.764965)]
        public void ShouldParseLatitude(string line, double expected)
        {
            //Arrange (object created to call method to test)
            var tacoParser = new TacoParser();
            //Act
            var actual = tacoParser.Parse(line).Location.Latitude;
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
