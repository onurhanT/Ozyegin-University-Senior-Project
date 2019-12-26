using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piano_Controller : MonoBehaviour
{
    
    
    private AudioSource sound;

    // Start is called before the first frame update
    void Start()
    {
        sound = this.gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        sound.Play();
    }
    private void OnTriggerExit(Collider other)
    {
        sound.Stop();
    }
}
