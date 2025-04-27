using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TW01_JSH_HeartController : MonoBehaviour
{
    public GameObject Pick_Controller;

    private void OnMouseDown()
    {
        PrintInfo(); // Step01 
    }

    // Step01: 게임 오브젝트의 이름 출력 
    void PrintInfo()
    {
        print($"{gameObject.name}을/를 클릭했습니다.");
        Pick_Controller.GetComponent<TW01_JSH_Pick_Controller>().Increase_PickCount(gameObject);
    }

}
