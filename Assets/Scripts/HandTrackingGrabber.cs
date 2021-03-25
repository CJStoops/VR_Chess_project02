using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OculusSampleFramework;

public class HandTrackingGrabber : OVRGrabber
{
    private OVRHand oVRHand;
    public float pinchThreshold = 0.7f;
    // Start is called before the first frame update
    void Start()
    {
       oVRHand = GetComponent<OVRHand>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckIndexPinch(); 
    }

    void CheckIndexPinch()
    {
        float pinchStrength = GetComponent<OVRHand>().GetFingerPinchStrength(OVRHand.HandFinger.Index);
        bool isPinching = pinchStrength > pinchThreshold;

        if (!m_grabbedObj && isPinching && m_grabCandidates.Count > 0)
            GrabBegin();
        else if (m_grabbedObj && !isPinching)
            GrabEnd();
    }
}
