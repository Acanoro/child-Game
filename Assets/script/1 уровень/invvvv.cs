using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invvvv : MonoBehaviour
{
    public GameObject dialog1/*, dialog2, dialog3*/;

    public void ShowAndHide1()
    {
        if (dialog1.activeSelf) dialog1.SetActive(false);
        else dialog1.SetActive(true);
    }
    /*public void ShowAndHide2()
    {
        if (dialog2.activeSelf) dialog2.SetActive(false);
        else dialog2.SetActive(true);
    }
    public void ShowAndHide3()
    {
        if (dialog3.activeSelf) dialog3.SetActive(false);
        else dialog3.SetActive(true);
    }*/
}
