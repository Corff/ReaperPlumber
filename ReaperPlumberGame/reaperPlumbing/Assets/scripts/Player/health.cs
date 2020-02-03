using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    private Transform bar;

    // Start is called before the first frame update
    private void Start()
    {
        bar = transform.Find("Bar");
        bar.localScale = new Vector3(1f, 1f);
    }

    public void setSize(float sizeNormalised)
    {
        bar.localScale = new Vector2(sizeNormalised, 1f);
    }
}
