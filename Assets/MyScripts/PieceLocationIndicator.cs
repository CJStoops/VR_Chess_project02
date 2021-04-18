using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeLocationIndicator : MonoBehaviour
{
    public Renderer rCube;
    bool piecePlaced = false;

    public Material red, transparent;
    // Start is called before the first frame update

    AudioSource myAudioSource;
    public AudioClip soundFX;
    void Start()
    {
        // r = GetComponent<Renderer>();
        myAudioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "ChessPiece" && piecePlaced == false)
        {
            rCube.material = red;
            myAudioSource.Play();

            OVRHapticsClip ovrClip = new OVRHapticsClip(soundFX);
            OVRHaptics.RightChannel.Preempt(ovrClip);
            OVRHaptics.LeftChannel.Preempt(ovrClip);
            piecePlaced = true;
            Invoke("SetTransparent", 2f);
        }
            else
        {
            //not chess piece, so do nothing.
        }           
    
    }

    private void OnTriggerExit(Collider other)
    {
        
        //r.material.color = Color.grey;
       
        piecePlaced = false;
     
    }

    private void SetTransparent()
    {
        rCube.material = transparent;
    }

}

