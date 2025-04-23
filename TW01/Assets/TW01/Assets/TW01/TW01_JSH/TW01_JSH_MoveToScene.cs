using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TW01_JSH_MoveToScene : MonoBehaviour
{
    public void Change()
    {
        SceneManager.LoadScene("TW01_Main_Scene");
    }
}