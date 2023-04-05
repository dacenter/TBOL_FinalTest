using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Size
    {
        get
        {
            return GetComponent<PlayerController>().Size;
        }
    }

    // Update is called once per frame
    public void SetSize(float size)
    {
        GetComponent<PlayerController>().SetSize(size);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        LevelObject obj = col.gameObject.GetComponent<LevelObject>();
        if (obj != null)
        {
            obj.OnPlayerTouch(this);
        }
    }
}
