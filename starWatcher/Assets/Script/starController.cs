using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starController : MonoBehaviour
{

    // Use this for initialization
    public Camera mainCam;
    private int count;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            //check to see if user clicks
        {
            Ray ray = mainCam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
                //if the raycast hits something
            {
                if (hit.transform.tag == "star")
                    //check to see if its a star
                {
                    Debug.Log("My object is clicked by mouse");
                    hit.transform.tag = "clicked";
                    if (hit.transform.parent.name == "starGroup1")
                    {
                        //if it is part of the first stargroup/picture, add to count.
                        //whenever the count of stars that makes the pic is satisfied, then we will make
                        //the picture appear
                        count += 1;
                    }
                }
                else if (hit.transform.tag == "clicked")
                    //dont preform the above actions if star is already clicked.
                {
                    Debug.Log("Already been clciked yo.");
                }
            }

        }

        if (count == 6) {
            print("star group 1 has all been clicked!");
        }

    }
}
