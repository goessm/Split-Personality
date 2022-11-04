using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    private Vector2 moveInput;
    private Rigidbody2D rigidBody;
    private MoveState moveState;

    private enum MoveState {
        Moving,
        Frozen,
    }
    // Start is called before the first frame update
    
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        rigidBody = GetComponent<Rigidbody2D>();
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
        
    }

    public void OnMoveInput(InputAction.CallbackContext ctx) {
        moveInput = ctx.ReadValue<Vector2>();
    }

    void MovementTick()
    {
        rigidBody.velocity = moveInput * moveSpeed * Time.deltaTime;
        if (moveInput.x > 0.01 || moveInput.y > 0.01) {
            //print(movementInput * moveSpeed);
            //print(rb.velocity);
        }
    }
}
