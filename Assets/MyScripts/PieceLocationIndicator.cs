using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceLocationIndicator : MonoBehaviour
{
    public Renderer rPawn, rKing, rQueen, rRook, rBishop, rKnight;

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
        if(other.tag == "Pawn")
        {
            rPawn.material = red;
            myAudioSource.Play();

            OVRHapticsClip ovrClip = new OVRHapticsClip(soundFX);
            OVRHaptics.RightChannel.Preempt(ovrClip);
            OVRHaptics.LeftChannel.Preempt(ovrClip);

        }
        else if (other.tag == "King")
        {
            rKing.material = red;
            myAudioSource.Play();

            OVRHapticsClip ovrClip = new OVRHapticsClip(soundFX);
            OVRHaptics.RightChannel.Preempt(ovrClip);
            OVRHaptics.LeftChannel.Preempt(ovrClip);
        }
        else if (other.tag == "Queen")
        {
            rQueen.material = red;
            myAudioSource.Play();

            OVRHapticsClip ovrClip = new OVRHapticsClip(soundFX);
            OVRHaptics.RightChannel.Preempt(ovrClip);
            OVRHaptics.LeftChannel.Preempt(ovrClip);
        }
        else if (other.tag == "Knight")
        {
            rKnight.material = red;
            myAudioSource.Play();

            OVRHapticsClip ovrClip = new OVRHapticsClip(soundFX);
            OVRHaptics.RightChannel.Preempt(ovrClip);
            OVRHaptics.LeftChannel.Preempt(ovrClip);
        }
        else if (other.tag == "Rook")
        {
            rRook.material = red;
            myAudioSource.Play();

            OVRHapticsClip ovrClip = new OVRHapticsClip(soundFX);
            OVRHaptics.RightChannel.Preempt(ovrClip);
            OVRHaptics.LeftChannel.Preempt(ovrClip);
        }
        else if (other.tag == "Bishop")
        {
            rBishop.material = red;
            myAudioSource.Play();

            OVRHapticsClip ovrClip = new OVRHapticsClip(soundFX);
            OVRHaptics.RightChannel.Preempt(ovrClip);
            OVRHaptics.LeftChannel.Preempt(ovrClip);
        }
        else
        {
            //not chess piece, so do nothing.
        }


        
    }

    private void OnTriggerExit(Collider other)
    {
        
        //r.material.color = Color.grey;
        rPawn.material = transparent;
        rKing.material = transparent;
        rQueen.material = transparent;
        rKnight.material = transparent;
        rRook.material = transparent;
        rBishop.material = transparent;

    }


}

