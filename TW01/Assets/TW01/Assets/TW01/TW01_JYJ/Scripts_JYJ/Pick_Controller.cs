using UnityEngine;

public class Pick_Controller : MonoBehaviour
{
    int clickCounter = 0;

    public void Add_Click(GameObject clickedApple)
    {
        clickCounter++;
        Debug.Log($"{clickCounter} 개 클릭됨!");
        Destroy(clickedApple); // 사과 제거
    }
}
