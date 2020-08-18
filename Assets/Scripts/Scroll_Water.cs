using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll_Water : MonoBehaviour
{
    public float scrollX = 0.5f;
    public float scrollZ = 0.5f;
    public float timeDifx;
    public float timeDifz;

    void Update()
    {
        timeDifx = Time.time*scrollX;
        timeDifz = Time.time*scrollZ;
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(timeDifx, timeDifz);
    }
}
