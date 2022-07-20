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
    public byte FaceValue { get; set; }
    
    public bool IsHeld { get; set; }
    
    public void Roll()
        {
            throw new NotImplementedException();
        }
    }
}
