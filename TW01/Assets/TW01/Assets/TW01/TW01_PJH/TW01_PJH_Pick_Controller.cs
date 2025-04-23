using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TW01_PJH_Pick_Controller : MonoBehaviour
{
    int pickCount = 0;
    bool isInTheAreas = false;

    public void Increase_PickCount(GameObject Clone){
        if(isInTheAreas){
            pickCount++;
            print($"pick count: {pickCount}");
            Destroy(Clone);
        }
    }

    void OnTriggerStay(Collider other)
    {
        if(other.name == "FPSController"){
            isInTheAreas = true;
        }
    }
}
