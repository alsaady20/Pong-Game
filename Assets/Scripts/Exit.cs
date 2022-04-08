using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    private void OnMouseDown()
    {
        transform.localScale *= .9f;
    }

    private void OnMouseUp()
    {
        Application.Quit();
    }
}
