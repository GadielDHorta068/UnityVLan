using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    bool isGround = false;
    public float fuerzaSalto;
    private float auxY;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Si esta tocando algo, y estuvo en caida
        if (isGround &&(auxY <transform.position.y ) )//(Input.GetKeyDown("space")&& isGround)
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
        //Actualizar Posicion
        auxY = transform.position.y;
    }
    void OnCollisionStay2D(Collision2D other)
    {
        isGround =true;
        //Debug.Log("STAY");
    }
    
    void OnCollisionExit2D(Collision2D other)
    {
        isGround = false;
        //Debug.Log("Unstay");   
    }
    private void OnBecameInvisible() {
        Debug.Log("invisible");
        Destroy(this.gameObject);

        //Esta bug, no anda
    }
}
