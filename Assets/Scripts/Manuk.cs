using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manuk : MonoBehaviour
{
    public float upForce = 200f;

    private bool isDead = false;
    private new Rigidbody2D rigidbody;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Don't Allow
        if (!isDead)
        {
            if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
            {
                rigidbody.velocity = Vector2.zero;
                rigidbody.AddForce(new Vector2(0, upForce));
                animator.SetTrigger("Flap");
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        rigidbody.velocity = Vector2.zero;
        isDead = true;
        animator.SetTrigger("Die");
        GameController.instance.BirdDied();
    }
}
