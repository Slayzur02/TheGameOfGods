using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCenterControl : MonoBehaviour
{
    public Rigidbody2D CameraCenter;

    public float movespeed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        CameraCenter = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            movespeed = movespeed * (-1);
        }
        CameraCenter.velocity = new Vector2(CameraCenter.velocity.x, movespeed);
    }
}
