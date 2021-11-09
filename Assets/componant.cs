using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class componant : MonoBehaviour
{
    [SerializeField] protected KeyCode up;
    float ss= 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(up)){
        transform.localScale = new Vector3(Mathf.Abs(Mathf.Sin(Time.time)), Mathf.Abs(Mathf.Sin(Time.time)), 0);
        }
        else transform.localScale = new Vector3(0,0,0);
    }
}
