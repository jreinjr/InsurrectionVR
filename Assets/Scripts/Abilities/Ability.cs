using UnityEngine;

public abstract class Ability : ScriptableObject
{
    public abstract void Execute();
}

[CreateAssetMenu(menuName ="Ability/Jump")]
public class Jump : Ability
{
    public override void Execute()
    {
        throw new System.NotImplementedException();
    }
}