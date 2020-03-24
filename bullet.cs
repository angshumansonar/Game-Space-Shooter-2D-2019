using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameObject bull;
    public AudioSource sound;
    private void Start()
    {
        AudioSource sound = gameObject.GetComponent<AudioSource>();
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            sound.Play();
            Instantiate(bull, transform.position, transform.rotation);
        }
    }
}
