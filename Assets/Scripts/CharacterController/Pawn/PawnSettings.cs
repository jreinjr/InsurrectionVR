using UnityEngine;

[System.Serializable]
[CreateAssetMenu(menuName =("Pawn/Pawn Settings"))]
public class PawnSettings : ScriptableObject
{
    public bool Player;

    [HideWhenFalse("Player")] public PawnInputControls controls;
}