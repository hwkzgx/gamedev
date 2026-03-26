using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public float moveSpeed = 6f;
    public float jumpForce = 7f;
   // public float health = 100;
    // public int coin = 0;
    //public bool isGrounded;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(move * moveSpeed, rb.linearVelocity.y);

        //isGrounded = true;

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }

        //if (health <= 0)
        {
             //Debug.Log("Player Died!");
           //  Destroy(gameObject);
      //  }
        }
    }
}
