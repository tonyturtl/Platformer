using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //variables for the game
    float speed;        
    float move;         

    float jump;
    bool isJumping;  

    Rigidbody2D rb;

    public static PlayerMovement instance;  //static variable that will hold Singleton

    // Called when script instance is being loaded
   void Awake()
   {
        // Make a Singleton to prevent more than one instance of an object
        if (instance == null)                 
        {
            DontDestroyOnLoad(gameObject); 
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
   } 

    // Start is called before the first frame update
    void Start()
    {
        speed = 8f;
        jump = 600f;

        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(speed * move, rb.velocity.y);
       
        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            rb.AddForce (new Vector2(rb.velocity.x, jump));
            isJumping = true; 
        }
    }

    // Called when a Collision is detected
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping =  false;
        }
    }
}

