using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Growing the ball
public class BallTransform : MonoBehaviour
{
    public Vector3 scaleChange;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {// change per frame, grow too fast
     //  transform.localScale += scaleChange; 
     // transform.localScale += (scaleChange * Time.deltaTime); // change per second

        // rotating cube
        transform.Rotate(3 * Time.deltaTime, 0, 0);
    }
}
