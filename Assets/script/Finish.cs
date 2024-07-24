using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    [SerializeField] float LS = 2f;
    [SerializeField] ParticleSystem ps ;
     void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            GetComponent<AudioSource>().Play();
            ps.Play();
            Invoke("LoadScene", LS); 
        }

    }
    void LoadScene()
    {
        SceneManager.LoadScene(0);

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
