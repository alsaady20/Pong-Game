using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGame : MonoBehaviour
{
    // Start is called before the first frame update
    void OnMouseDown()
    {
        transform.localScale *= 9f;
    }

    // Update is called once per frame
    void OnMouseUp()
    {
        SceneManager.LoadScene(1);
    }
}
