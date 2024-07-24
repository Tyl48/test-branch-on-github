using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField] float torque = 1;
    [SerializeField] float Speed = 30f;
    [SerializeField] float Normal = 15f;

    SurfaceEffector2D se;
    Rigidbody2D rb;
  
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
        se = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rotate();
        boost();
    }

    private void boost()
    {
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            se.speed = Speed;
        }
        else
        {
            se.speed = Normal;
        }
    }
    
    void rotate()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.AddTorque(torque);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb.AddTorque(-torque);
        }
    }
}
