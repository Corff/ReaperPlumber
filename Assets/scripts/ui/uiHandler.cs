using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uiHandler : MonoBehaviour
{
    public GameObject enabler;
    public GameObject disabler;

    public void clicked()
    {
        enabler.SetActive(true);
        disabler.SetActive(false);
    }

}
