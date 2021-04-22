using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeLocationIndicator : MonoBehaviour
{
    public Renderer rCube;

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
        if(other.CompareTag("Pawn"))
        {
           TriggerEntered();

        }
        else if(other.CompareTag("Rook"))
        {
            TriggerEntered();

        }
        else if (other.CompareTag("King"))
        {
            TriggerEntered();

        }
        else if (other.CompareTag("Queen"))
        {
            TriggerEntered();

        }
        else if (other.CompareTag("Bishop"))
        {
            TriggerEntered();

        }
        else if (other.CompareTag("Knight"))
        {
            TriggerEntered();

        }
        else
        {

            Debug.Log("Did Nothing");
            //not chess piece, so do nothing.
            
        }
        
    }

    private void OnTriggerExit(Collider other)
    {

        //r.material.color = Color.grey;

    }

    private void SetTransparent()
    {
        rCube.material = transparent;
    }

    private void TriggerEntered()
    {
        rCube.material = red;
        myAudioSource.loop = false;
        myAudioSource.Play();

        OVRHapticsClip ovrClip = new OVRHapticsClip(soundFX);
        OVRHaptics.RightChannel.Preempt(ovrClip);
        OVRHaptics.LeftChannel.Preempt(ovrClip);
        Invoke("SetTransparent", 2f);
    }

}

