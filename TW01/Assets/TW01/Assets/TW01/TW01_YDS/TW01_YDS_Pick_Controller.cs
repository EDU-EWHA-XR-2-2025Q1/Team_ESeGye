using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TW01_YDS_Pick_Controller : MonoBehaviour
{
    int pickCount = 0;
    bool isInTheAreas = false;
    public GameObject UI;

    public void Increase_PickCount(GameObject Clone){
        if(isInTheAreas){
            pickCount++;
            print($"pick count: {pickCount}");
            Destroy(Clone);
            UI.GetComponent<TW01_YDS_UI_Controller>().Display_PickCounts(pickCount);
        }
    }

    void OnTriggerStay(Collider other)
    {
        if(other.name == "FPSController"){
            isInTheAreas = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.name == "FPSController"){
            isInTheAreas = false;
        }
    }
}
