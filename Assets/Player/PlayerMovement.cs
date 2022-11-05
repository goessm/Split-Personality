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
    private List<GameObject> npcsInRange = new List<GameObject>();


    private enum MoveState {
        Moving,
        Frozen,
    }

    public void meetNPC(GameObject npc)
    {
        if (!npcsInRange.Contains(npc)) {
            npcsInRange.Add(npc);
        }
    }

    public void unmeetNPC(GameObject npc)
    {
        if (npcsInRange.Contains(npc)) {
            npcsInRange.Remove(npc);
        }
    }

    // Start is called before the first frame update
    
    void OnEnable ()
    {
        EventManager.StartListening ("PlayerTalking", OnPlayerTalking);
        EventManager.StartListening ("PlayerStopTalking", OnPlayerStopTalking);
        EventManager.StartListening ("MonokelOn", OnMonokelOn);
        EventManager.StartListening ("MonokelOff", OnMonokelOff);
    }

    void OnDisable ()
    {
        EventManager.StopListening ("PlayerTalking", OnPlayerTalking);
        EventManager.StopListening ("PlayerStopTalking", OnPlayerStopTalking);
        EventManager.StopListening ("MonokelOn", OnMonokelOn);
        EventManager.StopListening ("MonokelOff", OnMonokelOff);
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

    void OnMonokelOn()
    {
        moveState = MoveState.Frozen;
    }

    void OnMonokelOff()
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
                rigidBody.velocity = Vector2.zero;
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

    public void OnTalk(InputAction.CallbackContext ctx)
    {
        if (ctx.performed && npcsInRange.Count > 0) {
            npcsInRange[0].GetComponent<NPC>().talkToNpc();
        }
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
