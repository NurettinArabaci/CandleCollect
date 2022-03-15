using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public static float speed = 0;
    public static float xSpeed = 0f;
    float limitX = 3.5f;

    float mouseX = 0;

    private void Update()
    {
        transform.position += new Vector3(0, 0, speed * Time.deltaTime);

        if (Input.GetMouseButton(0))
        {
            mouseX = Input.GetAxis("Mouse X");
            transform.position += new Vector3(mouseX * xSpeed * Time.deltaTime*10, 0, 0);
        }

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -limitX, limitX), transform.position.y, transform.position.z);

    }
}
