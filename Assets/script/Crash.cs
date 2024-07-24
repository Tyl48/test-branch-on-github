using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Crash : MonoBehaviour
{
    [SerializeField] float LS = 1f;
    // Start is called before the first frame update
     void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Ground")
        {
            Invoke("LoadScene", LS);
        }
    }
    void LoadScene()
    {
        SceneManager.LoadScene(0);
    }
}
