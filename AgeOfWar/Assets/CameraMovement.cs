using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField]
    private float sensitivity = 1f;


    // Update is called once per frame
    void Update()
    {
        var step = sensitivity * Time.deltaTime;
        Vector3 mousePos = Input.mousePosition;
        Vector3 left = new Vector3(0, transform.position.y, -10);
        Vector3 right = new Vector3(10, transform.position.y, -10);

        if (mousePos.x < 100)
        {
            transform.position = Vector3.MoveTowards(transform.position, left, step);
        }

        if (mousePos.x > 800)
        {
            transform.position = Vector3.MoveTowards(transform.position, right, step);
        }
    }
}
