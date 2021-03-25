using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GHColorChangeBlack : MonoBehaviour
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
            SetBlack();
        }
    }

    public void SetBlack()
    {
        r.material.color = Color.black; //sets the color back to black when pinch ends
    }

    public void SetGreen()
    {
        r.material.color = Color.green; // sets color to green while pinching
    }
}
