using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TW01_NKDY_Pick_Controller : MonoBehaviour
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

    void OnTriggerExit(Collider other)
    {
        if (other.name == "FPSController")
        {
            isInTheAreas = false;
        }
    }

    // 여기 추가: 사과 오브젝트에도 이 스크립트를 붙인다는 가정
    void OnMouseDown()
    {
        Increase_PickCount(this.gameObject);
    }
}
