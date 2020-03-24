using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smallastt : MonoBehaviour
{



    IEnumerator Example()
    {
       
        yield return new WaitForSeconds(0.5f);
        Destroy(this.gameObject);
    }
    void Start()
    {
        StartCoroutine(Example());
        
    }
    
}
