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

    // ���� �߰�: ��� ������Ʈ���� �� ��ũ��Ʈ�� ���δٴ� ����
    void OnMouseDown()
    {
        Increase_PickCount(this.gameObject);
    }
}
