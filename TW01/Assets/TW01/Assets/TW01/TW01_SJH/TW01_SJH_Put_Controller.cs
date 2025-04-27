using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TW01_SJH_Put_Controller : MonoBehaviour
{
    public GameObject TargetObjectToThrow;
    public Transform PlayerCamera;
    public GameObject UI;
    bool isInTheArea = false;

    void Update()
    {
        if(Input.GetMouseButtonDown(0) && isInTheArea)
        {
            int pickCounts = UI.GetComponent<TW01_SJH_UI_Controller>().GetPickCounts(); 
            if (pickCounts > 0) 
            { 
                Throw();
                UI.GetComponent<TW01_SJH_UI_Controller>().Decrease_PickCounts();
                FindObjectOfType<TW01_SJH_Pick_Controller>().Decrease_PickCount();
            }
        }
    }

    void Throw(){
        Vector3 Pos = PlayerCamera.position + PlayerCamera.forward; // 바라보는 방향 기준으로 앞으로 1unit

        // 복제할 클론의 랜덤한 rotation 
        float randomAngleX = Random.value * 360f;
        float randomAngleY = Random.value * 360f;
        float randomAngleZ = Random.value * 360f;
        Quaternion randomRot = Quaternion.Euler(randomAngleX, randomAngleY, randomAngleZ);

        // 복제하기 
        GameObject Clone = Instantiate(TargetObjectToThrow, Pos, randomRot);

        // 복제한 클론 설정 
        Clone.SetActive(true);
        Clone.GetComponent<Collider>().isTrigger = false;
        Clone.GetComponent<Rigidbody>().useGravity = true;

        // 던지기 
        Clone.GetComponent<Rigidbody>().AddForce(PlayerCamera.forward * 400f);

        // 3초 후 소멸시키기 
        Destroy(Clone, 3);
    
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "FPSController")
        {
            isInTheArea = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "FPSController")
        {
            isInTheArea = false;
        }
    }
}
