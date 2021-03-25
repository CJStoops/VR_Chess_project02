using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeWhite : MonoBehaviour
{

    Renderer r;
    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(-90, 0, 0);
        if (transform.GetComponent<OVRGrabbable>().isGrabbed)
        {
            SetGreen();
        }
        else
        {
            SetWhite();
        }
    }

    public void SetWhite()
    {
        r.material.color = Color.white; //sets the color back to white when pinch ends
    }

    public void SetGreen()
    {
        r.material.color = Color.green; // sets color to green while pinching
    }
}