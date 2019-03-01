using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Pawn : MonoBehaviour
{
    [SerializeField] private PawnSettings pawnSettings;

    private IPawnInput pawnInput;
    private PawnMotor pawnMotor;

    // Components
    Animator animator;

    private void Awake()
    {
        Initialize();
    }

    private void Update()
    {
        pawnInput.ReadInput();
        pawnMotor.Tick();
    }

    private void Initialize()
    {
        animator = GetComponent<Animator>();

        pawnInput = pawnSettings.Player ?
            new PlayerInput(pawnSettings.controls) :
            new AiInput() as IPawnInput;

        pawnMotor = new PawnMotor(pawnInput, animator, transform);
    }
}
