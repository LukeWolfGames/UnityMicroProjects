using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public int scoreToGive = 1;
    public int clicksToPop = 5;
    public float scaleIncreasePerClick = 0.1f;

    void OnMouseDown ()
    {
        clicksToPop -= 1;

        transform.localScale += Vector3.one * scaleIncreasePerClick;
    }
}
