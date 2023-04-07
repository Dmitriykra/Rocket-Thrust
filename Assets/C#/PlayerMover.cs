using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    private float horizontalInput;
    private float sidePlayerSpeed = 1000f;
    private float sideBorders = 25f;
  
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            horizontalInput = Input.GetAxis("Mouse X");
            SideMove();
        }
        else 
        {
            horizontalInput = 0f;
        } 
    }

    private void SideMove()
    {
        float xAxisMove = transform.position.x + 
            horizontalInput * sidePlayerSpeed * Time.deltaTime;

        xAxisMove = Mathf.Clamp(xAxisMove, -sideBorders, sideBorders);    

        transform.position = new Vector3(xAxisMove, 
            transform.position.y, transform.position.z);
    }
}
