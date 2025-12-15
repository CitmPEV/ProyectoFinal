using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    private PlayerInputActions input;
    private Vector2 move;

    private void Awake()
    {
        input = new PlayerInputActions();
        Debug.Log("PlayerMovement Awake");
    }

    private void OnEnable()
    {
        input.Player.Enable();
        input.Player.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
        input.Player.Move.canceled += ctx => move = Vector2.zero;
    }

    private void OnDisable()
    {
        input.Player.Disable();
    }

    private void Update()
    {
        Vector3 dir = new Vector3(move.x, 0, move.y);
        transform.Translate(dir * speed * Time.deltaTime);
    }
}
