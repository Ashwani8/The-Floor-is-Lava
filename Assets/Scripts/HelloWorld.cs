using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    
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
         

    }
}
