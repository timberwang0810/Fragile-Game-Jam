using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool facingLeft;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        facingLeft = false;
    }
    // Update is called once per frame
    void Update()
    {
        float horizontalMove = Input.GetAxisRaw("Horizontal");
        if (horizontalMove < 0) facingLeft = true;
        else if (horizontalMove > 0) facingLeft = false;
    }

}
