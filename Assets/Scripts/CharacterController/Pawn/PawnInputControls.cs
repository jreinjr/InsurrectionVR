using UnityEngine;


[System.Serializable]
[CreateAssetMenu(menuName = ("Pawn/Pawn Input Controls"))]
public class PawnInputControls : ScriptableObject
{
    [Header("Pawn Inputs")]
    public string horizontalAxis = "Horizontal";
    public string verticalAxis = "Vertical";
    public string strafeAxis = "Strafe";
    public string jumpButton = "Jump";

    [Header("Camera Inputs")]
    public string rotateCameraXInput = "Mouse X";
    public string rotateCameraYInput = "Mouse Y";
}