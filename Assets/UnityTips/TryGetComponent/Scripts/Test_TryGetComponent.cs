using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Example  :   How to use TryGetComponent
// Detail   :   We are getting a collider component via TryGetComponent 
//              and to disable the collider of the GameObject on which this script is attached.
public class Test_TryGetComponent : MonoBehaviour
{
    void Start()
    {
        //This is current Code
        /*if (GetComponent<Collider>() != null)
        {
            GetComponent<Collider>().enabled = false;
        }
        else
        {
            Debug.Log("Collider is not attached !");
        }*/

        //This is latest code
        if (TryGetComponent(out Collider CubeCollider))
        {
            CubeCollider.enabled = false;
        }
        else
        {
            Debug.Log("Collider is not attached !");
        }

        //This code section demonstrate how to get script using TryGetComponent
        //In this case we are furhter not using test_Player, so we can also use "_" instead of "test_Player"
        if (TryGetComponent(out Test_Player test_Player))
        {
            Debug.Log("Test_Player is attached !");
        }
        else
        {
            Debug.Log("Test_Player is not attached !");
        }
    }

}
