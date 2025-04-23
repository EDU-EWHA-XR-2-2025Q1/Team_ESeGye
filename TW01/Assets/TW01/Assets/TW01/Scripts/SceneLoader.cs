using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{


    public void LoadYVJScene()
    {
        SceneManager.LoadScene("TW01_YVJ_Scene");
    }

    public void LoadJSHScene(){

        Debug.Log("버튼 눌림 - 씬 이동 시도");

        if (Application.CanStreamedLevelBeLoaded("TW01_JSH_Scene"))
        {
            Debug.Log("씬 전환 시작!");
            SceneManager.LoadScene("TW01_JSH_Scene");
        }
        else
        {
            Debug.LogError("TW01_JYJ_Scene 씬이 Build Settings에 등록되지 않았거나 이름이 틀렸습니다!");
        }
    }

    public void LoadPJHScene()
    {

        Debug.Log("버튼 눌림 - 씬 이동 시도");

        if (Application.CanStreamedLevelBeLoaded("TW01_PJH_Scene"))
        {
            Debug.Log("씬 전환 시작!");
            SceneManager.LoadScene("TW01_PJH_Scene");
        }
        else
        {
            Debug.LogError("TW01_PJH_Scene 씬이 Build Settings에 등록되지 않았거나 이름이 틀렸습니다!");
        }
    }
}
