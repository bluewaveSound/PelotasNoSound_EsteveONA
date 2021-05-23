using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAudioController : MonoBehaviour
{
    AudioSource source;
    Renderer rend; 
    // Start is called before the first frame update
    void Start()
    {
       source = GetComponent<AudioSource>();
       rend = GetComponent<Renderer>(); 
       source.pitch = 1.73f / rend.bounds.size.magnitude;
       //print(" CubeSize " + rend.bounds.size.magnitude);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        print("cube collision" + collision.collider.name);
        source.Play(); 
    }
}
