using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    bool isGround = false;
    public float fuerzaSalto;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isGround)//(Input.GetKeyDown("space")&& isGround)
        {
            rb.AddForce(new Vector2(0, fuerzaSalto));
            Debug.Log("salto");
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left/50);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right/50);
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        isGround = true;    
    }
    
    void OnCollisionExit2D(Collision2D other)
    {
        isGround = false;    
    }
}
