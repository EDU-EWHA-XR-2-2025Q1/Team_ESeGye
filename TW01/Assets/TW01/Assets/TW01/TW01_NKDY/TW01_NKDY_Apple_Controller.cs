using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TW01_NKDY_Apple_Controller : MonoBehaviour
{
    public GameObject Pick_Controller;

    private void OnMouseDown()
    {
        PrintInfo(); // Step01 
        Pick_Controller.GetComponent<TW01_NKDY_Pick_Controller>().Increase_PickCount(gameObject);
    }

    // Step01: 게임 오브젝트의 이름 출력 
    void PrintInfo()
    {
        print($"{gameObject.name}을/를 클릭했습니다.");
    }

}
