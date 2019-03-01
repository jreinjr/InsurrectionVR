using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

namespace InsurrectionVR
{
    public abstract class Ability<T>
    {
        public abstract void Cast(PawnController caster, T target);
    }


    public class MindControlAbility : Ability<PawnController>
    {
        public override void Cast(PawnController caster, PawnController target)
        {
            target.Input = caster.Input;
            caster.Input = null;
        }
    }
}

