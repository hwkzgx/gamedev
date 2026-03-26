using UnityEngine;
using System.Collections;

public class TrapFloor : MonoBehaviour
{
    public float fallDelay = 0.3f;
    public float respawnTime = 3f;

    Rigidbody2D rb;
    Collider2D col;
    bool triggered = false;
    Vector3 startPos;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<Collider2D>();

        rb.bodyType = RigidbodyType2D.Static;
        startPos = transform.position;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (!triggered && collision.gameObject.CompareTag("Player"))
        {
            triggered = true;
            Invoke("Fall", fallDelay);
        }
    }

    void Fall()
    {
        col.enabled = false;
        rb.bodyType = RigidbodyType2D.Dynamic;
        Debug.Log("Player Died!");

        StartCoroutine(Respawn());
    }

    IEnumerator Respawn()
    {
        yield return new WaitForSeconds(respawnTime);

        rb.bodyType = RigidbodyType2D.Static;
        transform.position = startPos;
        col.enabled = true;
        triggered = false;
    }
}
