using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieRollerA
{
    /// <summary>
    /// represents six sided dice in game
    /// </summary>
    public class Die
    {
        /// <summary>
        ///  current face up value of the die
        /// </summary>
    public byte FaceValue { get; set; }
    /// <summary>
    /// True if die is currently held
    /// </summary>
    public bool IsHeld { get; set; }
    /// <summary>
    /// Rolls die and sets the <see cref="FaceValue"/>
    /// to the new number
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    public void Roll()
        {
            // generate random number, sets face value and returns new number
            throw new NotImplementedException();
        }
    }
}
