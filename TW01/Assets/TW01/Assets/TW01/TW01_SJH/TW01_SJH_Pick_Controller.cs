using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TW01_SJH_Pick_Controller : MonoBehaviour
{
    int pickCount = 0;
    bool isInTheAreas = false;
    public GameObject UI;

    // GameObject가 클릭됐을때
    public void Increase_PickCount(GameObject Clone){
        if(isInTheAreas){
            pickCount++;
            print($"pick count: {pickCount}");
            Destroy(Clone);
            UI.GetComponent<TW01_SJH_UI_Controller>().Display_PickCounts(pickCount);
        }
    }

    public void Decrease_PickCount()
    {
        pickCount--;
    }


    void OnTriggerStay(Collider other)  // 영역 안에 들어온 경우
    {
        if(other.name == "FPSController"){
            isInTheAreas = true;
        }
    }

    void OnTriggerExit(Collider other)  // 영역 밖으로 나간 경우
    {
        if(other.name == "FPSController"){  
            isInTheAreas = false;
        }
    }
}
