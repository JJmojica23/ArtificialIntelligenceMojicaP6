using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ShellMove : MonoBehaviour
{ 
    float speed = 1f;
    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(0, (speed * Time.deltaTime) / 2.0f, speed * Time.deltaTime);
    }
}
