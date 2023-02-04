using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public float Health;
    // Update is called once per frame
    void Update()
    {
        DisableOnDeath();
    }

    public void DisableOnDeath()
    {
        if (Health <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
