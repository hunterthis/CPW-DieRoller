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
        private static Random _random;

       public Die()
        {
            Roll();
        }
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
        public byte Roll()
        {
            if (!IsHeld)
            {
                // Generate random number
                byte newValue = (byte)_random.Next(1, 7);

                FaceValue = newValue;
            }
            return FaceValue;
        }
    }
}
