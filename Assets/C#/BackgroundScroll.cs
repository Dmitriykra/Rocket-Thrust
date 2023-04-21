using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    public float moveBgSpeed = 10f;
    Vector3 strartPos;

    void Start()
    {
        //set start position to default position of bg image;
        strartPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * moveBgSpeed * Time.deltaTime);
        if(transform.position.y < -134f)
        {
            Debug.Log("Dimas");
            transform.position = strartPos;
        }
    }
}
