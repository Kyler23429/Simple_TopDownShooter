using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 5f;

    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");
        float moveInputVertical = Input.GetAxisRaw("Vertical");
        rb.linearVelocity = new Vector2(moveInput * speed, moveInputVertical * speed);
    }
}
