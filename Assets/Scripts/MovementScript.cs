using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OculusSampleFramework;

public class MovementScript : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    public float m_Speed = 1.0f;
    private float m_Stop = 0.0f;
    public OVRHand leftHand;
    public OVRHand rightHand;
    public float pinchThreshold = 0.7f;
    public GameObject rig;


    void Start()
    {
        //Fetch the Rigidbody component you attach from your GameObject
        m_Rigidbody = rig.GetComponent<Rigidbody>();
    }

    void Update()
    {
        CheckIndexPinch();
        
    }
    public void CheckIndexPinch()
    {
        float pinchStrength = GetComponent<OVRHand>().GetFingerPinchStrength(OVRHand.HandFinger.Middle);
        bool isPinching = pinchStrength > pinchThreshold;
        var leftHandRigidbody = leftHand.GetComponent<Rigidbody>();
        var rightHandRigidbody = rightHand.GetComponent<Rigidbody>();

        if (isPinching)
        {
            //Move the Rigidbody forwards constantly at speed you define (the blue arrow axis in Scene view)
            m_Rigidbody.velocity = transform.forward * m_Speed;
            leftHandRigidbody.velocity = transform.forward * m_Speed;
            rightHandRigidbody.velocity = transform.forward * m_Speed;
        }
        else if (!isPinching)
        {
            m_Rigidbody.velocity = transform.forward * m_Stop;
            leftHandRigidbody.velocity = transform.forward * m_Stop;
            rightHandRigidbody.velocity = transform.forward * m_Stop;
        }

    }

}
