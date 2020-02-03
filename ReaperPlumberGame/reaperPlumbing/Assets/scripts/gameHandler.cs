using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameHandler : MonoBehaviour
{
    [SerializeField] private health healthBar;

    private void Start()
    {
        {
            healthBar.setSize(.4f);
        }
    }
}
