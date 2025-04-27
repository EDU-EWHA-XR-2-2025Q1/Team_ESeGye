using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.Examples;
using Unity.VisualScripting;
using UnityEngine;

public class TW01_SJH_UI_Controller : MonoBehaviour
{
    public TMP_Text PickCounts;
    public TMP_Text PutCounts;
    
    public void Display_PickCounts(int count){
        PickCounts.text= count.ToString();
    }

    public void Display_PutCounts(int putcount){
        PutCounts.text= putcount.ToString();
    }

    public void Decrease_PickCounts(){
        int lastPickCount = int.Parse(PickCounts.text);
        int currentPickCount = lastPickCount -1;
        PickCounts.text = currentPickCount.ToString();
    }

    public void Increase_PutCounts(){
        int lastPutCount = int.Parse(PutCounts.text);
        int currentPutCount = lastPutCount +1;
        PutCounts.text = currentPutCount.ToString();
    }

    public int GetPickCounts(){
        int pickCounts = int.Parse(PickCounts.text);
        return pickCounts;
    }

}
