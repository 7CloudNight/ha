using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sound_gem : MonoBehaviour
{
    Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;

        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
        rend.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
