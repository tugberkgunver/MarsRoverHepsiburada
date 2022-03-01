using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.ConsoleApplication.Rover;

namespace MarsRover.ConsoleApplication.Plateau.Interfaces
{
    public interface IPlateau
    {
        void CreatePlateau(string plateauSize);

        bool ValidateRoverPosition(Position roverPosition);
    }
}
