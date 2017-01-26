using UnityEngine;
using System.Collections;

public class changeColor : MonoBehaviour
{
    private readonly object grey;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<Renderer>().material.color = Color.red;
            print("Changed color to red");

        }
        // turns object to BLUE


        if (Input.GetKeyDown(KeyCode.B))
        {
            GetComponent<Renderer>().material.color = Color.blue;
            print("Changed color to Blue");
        }

        {
            if (Input.GetKeyDown(KeyCode.G))
            {
                GetComponent<Renderer>().material.color = Color.green;
                print("Changed color to Green");

            }
        }
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                GetComponent<Renderer>().material.color = Color.white;
                print("Changed color to White");
            }
        }
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                GetComponent<Renderer>().material.color = Color.black;
                print("Changed color to black");
              
            }
        }
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                GetComponent<Renderer>().material.color = Color.grey;
                print("Changed color to grey");

            }
        }
}
}
