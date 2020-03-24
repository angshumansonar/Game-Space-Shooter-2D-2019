using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawneer : MonoBehaviour
{
    public GameObject[] astero;
    public Vector3 spawnvalue;
    public float spawnwait;
    public float spawnmaxwait;
    public float spawnlesswait;
    public int startwait;


    int randomast;

    private void Start()
    {
        StartCoroutine(sapwner());
    }
    void Update()
    {
        spawnwait = Random.Range(spawnmaxwait, spawnlesswait);
    }



    IEnumerator sapwner()
    {
        yield return new WaitForSeconds(startwait);
        while (true)
        {
            randomast = Random.Range(0, 2);
            Vector3 spawnposition = new Vector3(1, Random.Range(-spawnvalue.y, spawnvalue.y),1);
            Instantiate(astero[randomast], spawnposition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);
            yield return new WaitForSeconds(spawnwait);
        }

    }
}
