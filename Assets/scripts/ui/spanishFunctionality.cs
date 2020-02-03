using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class spanishFunctionality : MonoBehaviour
{
    public Text title;
    public GameObject sombrero;


    public void spanish()
    {
        if (gameObject.GetComponent<Toggle>().isOn == true)
        {
            title.text = "Plomero Reaper";
            sombrero.SetActive(true);
        }
        else
        {
            title.text = "Reaper Plumber";
            sombrero.SetActive(false);
        }
    }

}
