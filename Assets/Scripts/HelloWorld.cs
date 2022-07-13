using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public float speed;
    public string myMessage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(myMessage);
        // geting input from the key board
        //  if (Input.GetKeyDown(KeyCode.Space))
        // the same can be achieved using defined function in unity like jump
       if(Input.GetButtonDown("Jump"))
        {
            print("spacebar was pressed");
            transform.position += new Vector3(0, 1, 0);
        }

        // Use GetAxis for Smooth motion instead of Key, left/Right arrow "Horizontal"/"Vertical" motion 
        // will go smoothly from 0 to -1 or +1 value
        float xInput = Input.GetAxis("Horizontal"); // we are storing
        float yInput = Input.GetAxis("Vertical");
        // we are using delta time to change x positon per second rather than frame speed time as different
        // system may have different frame update speed
        xInput = xInput * speed * Time.deltaTime;
        yInput = yInput * speed * Time.deltaTime;
        // Use Get Axis for Smooth motion, from 0 to 1
        //print(xInput);
        //print(yInput);
        // will move object with arrow keys or ctrl +a or d, up shipt+w or s
        transform.Translate(xInput, yInput, 0);
    }
}
