using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    
    public float screenheight;
    public float screenwidth;
    //transform
    Transform myTrans;
    //object position
    Vector3 myPos;
    
   
    float angle;


    playerspawnpoint spawnscript;
    public GameObject myspawnpoint;

    // Use this for initialization
    void Start()
    {
        
        myTrans = transform;
        myPos = myTrans.position;
        spawnscript = myspawnpoint.GetComponent<playerspawnpoint>();
    }

    private void Update()
    {
        warp();

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        //converting the object euler angle's magnitude from to Radians    
        angle = myTrans.eulerAngles.magnitude * Mathf.Deg2Rad;


        //rotate object Right & Left
        if (Input.GetKey(KeyCode.RightArrow))
        {
            myPos.x += (Mathf.Cos(angle) * speed) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            myPos.x -= (Mathf.Cos(angle) * speed) * Time.deltaTime;
        }


        //move object Forward & Backward
        if (Input.GetKey(KeyCode.UpArrow))
        {

            
            myPos.y += (Mathf.Cos(angle) * speed) * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
           
            myPos.y -= (Mathf.Cos(angle) * speed) * Time.deltaTime;
        }


        //Apply
        myTrans.position = myPos;
       

    }

    private void warp()
    {

        if (myPos.y > screenheight)
        {
            myPos.y = -screenheight;
        }
        else if (myPos.y < -screenheight)
        {
            myPos.y = screenheight;
        }
        else if (myPos.x > screenwidth)
        {
            myPos.x = -screenwidth;
        }
        else if (myPos.x < -screenwidth)
        {
            myPos.x = screenwidth;
        }
        myTrans.position = myPos;

    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "ast")
        {
            spawnscript.spawnSomething();
            Destroy(this.gameObject);
        }
        if (coll.gameObject.tag == "smallast")
        {
           
            spawnscript.spawnSomething();
            Destroy(this.gameObject);
        }

    }


}
