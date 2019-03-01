using UnityEngine;

public class PawnMotor
{
    // Public tweaking variable
    public float TURN_SPEED = 30f;

    // Dependencies
    private readonly IPawnInput input;
    private readonly Animator animator;
    private readonly Transform transform;
    //private readonly PawnSettings pawnSettings;

    // Constant values
    private int velocityXHash = Animator.StringToHash("InputHorizontal");
    private int velocityZHash = Animator.StringToHash("InputVertical");
    private int jumpHash = Animator.StringToHash("Jump");

    public PawnMotor(IPawnInput pawnInput, Animator animator, Transform transform)
    {
        // Dependency injection
        this.input = pawnInput;
        this.animator = animator;
        this.transform = transform;
        //this.pawnSettings = pawnSettings;
    }

    public void Tick()
    {
        MovePawn();
    }

    void MovePawn()
    {
        // Update movement
        animator.SetFloat(velocityXHash, input.DirectionInput.x);
        animator.SetFloat(velocityZHash, input.DirectionInput.z);
        // Update rotation
        transform.Rotate(Vector3.up, input.RotationInput * TURN_SPEED * Time.deltaTime);
        // Trigger jump
        if (input.JumpInput)
        {
            animator.SetTrigger(jumpHash);
        }
    }
}