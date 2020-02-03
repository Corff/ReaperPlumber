using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class fader : MonoBehaviour
{
    float alpha;
    bool bAlpha;
    public void Start()
    {
        alpha = 0;
        bAlpha = false;
        StartCoroutine(waitForSeconds(5,true));
        StartCoroutine(waitForSeconds(10));
    }
    public void Update()
    {
        if (!bAlpha)
        {
            alpha = alpha + 0.01f;
            gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, alpha);
        }
        if(bAlpha)
        {
            alpha = alpha - 0.01f;
            gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, alpha);
        }
    }


    IEnumerator waitForSeconds(float a)
    {
        yield return new WaitForSeconds(a);
        SceneManager.LoadScene(1);
    }
    IEnumerator waitForSeconds(float a, bool changeTo)
    {

        yield return new WaitForSeconds(a);
        bAlpha = changeTo;

    }

}
