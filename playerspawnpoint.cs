using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerspawnpoint : MonoBehaviour
{

    public GameObject playerone;


    
    public void spawnSomething()
    {
       
        Instantiate(playerone, transform.position, transform.rotation);
    }

}
    
    

