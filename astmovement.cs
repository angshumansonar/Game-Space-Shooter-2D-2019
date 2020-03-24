using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class astmovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    private Rigidbody2D rb;
    public GameObject ast;
    
  

    // Use this for initialization
    void Start()
    {
        
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, 0);
 
    }
   void Update()
    {
       
    }
  


void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "MainCamera")
        {
            
            Destroy(this.gameObject);
        }

        if (coll.gameObject.tag == "player")
        {
            Instantiate(ast, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }
        if (coll.gameObject.tag == "bullet")
        {

          
            
            Instantiate(ast, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }
    }

}
