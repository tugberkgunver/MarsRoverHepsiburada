using FluentAssertions;
using MarsRover.ConsoleApplication;
using Xunit;

namespace MarsRover.Tests
{
    public class MarsRoverShould
    {
        [Theory]
        [InlineData("1 2 N")]
        [InlineData("3 3 E")]
        public void PrintRoverPosition(string roverPosition)
        {
            //Arrange
            var rover = new ConsoleApplication.MarsRover(roverPosition);
            //Act
            var result = rover.Execute("");
            //Assert
            result.Should().Be(roverPosition);
        }

        [Theory]
        [InlineData("1 2 N", "LMLMLMLMM", "1 3 N")]
        [InlineData("3 3 E", "MMRMMRMRRM", "5 1 E")]
        public void ExecuteRoverCommands(string roverPosition, string commands, string expectedResult)
        {
            //Arrange
            var rover = new ConsoleApplication.MarsRover(roverPosition);
            //Act
            var result = rover.Execute(commands);
            //Assert
            result.Should().Be(expectedResult);
        }
    }
}