using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class volumeHandler : MonoBehaviour
{

    public void volumeChange()
    {
        AudioListener.volume = gameObject.GetComponent<Slider>().value;
    }

}
