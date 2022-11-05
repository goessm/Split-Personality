using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public Animator animator;
    private Vector2 moveSpeed = new Vector2(100, 50);
    private Vector2 moveInput;
    private Rigidbody2D rigidBody;
    private MoveState moveState;


    private enum MoveState {
        Moving,
        Frozen,
    }
    // Start is called before the first frame update
    
    void OnEnable ()
    {
        EventManager.StartListening ("PlayerTalking", OnPlayerTalking);
        EventManager.StartListening ("PlayerStopTalking", OnPlayerStopTalking);
    }

    void OnDisable ()
    {
        EventManager.StopListening ("PlayerTalking", OnPlayerTalking);
        EventManager.StopListening ("PlayerStopTalking", OnPlayerStopTalking);
    }
    
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        rigidBody = GetComponent<Rigidbody2D>();
        moveState = MoveState.Moving;
    }

    void OnPlayerTalking()
    {
        moveState = MoveState.Frozen;
    }

    void OnPlayerStopTalking()
    {
        moveState = MoveState.Moving;
    }
    
    void FixedUpdate()
    {
        switch (moveState)
        {
            case MoveState.Moving:
                MovementTick();
                break;
            case MoveState.Frozen:
                break;
        }
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Horizontal", moveInput.x);
        animator.SetFloat("Vertical", moveInput.y);
        animator.SetFloat("Speed", moveInput.sqrMagnitude);
    }

    public void OnMoveInput(InputAction.CallbackContext ctx) {
        moveInput = ctx.ReadValue<Vector2>();
    }

    void MovementTick()
    {
        rigidBody.velocity = new Vector2(moveInput.x * moveSpeed.x * Time.deltaTime, moveInput.y * moveSpeed.y * Time.deltaTime);
        if (moveInput.x > 0.01 || moveInput.y > 0.01) {
            //print(movementInput * moveSpeed);
            //print(rb.velocity);
        }
    }
}
