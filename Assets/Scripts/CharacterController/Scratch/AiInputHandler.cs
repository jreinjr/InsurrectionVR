using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace InsurrectionVR
{
    [CreateAssetMenu(menuName = "Input/AI Input Handler")]
    public class AiInputHandler : InputHandler
    {
        public override void ReadInput()
        {
            // Just keep jumping
            //Jump = 1f;
            // Override base at the end to update bools
            base.ReadInput();
        }
    }
}
