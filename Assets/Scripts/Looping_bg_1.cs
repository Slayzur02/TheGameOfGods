using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Looping_bg_1 : MonoBehaviour
{
    // GameObject.Find("Main_character").transform.position.y

    // Update is called once per frame
    void Update()
    {
        if (transform.localPosition.y+30 < GameObject.Find("Main_character").transform.position.y)
        {
            transform.position =new Vector3(transform.localPosition.x, transform.localPosition.y+60, 0);
        }
        if (transform.localPosition.y-30 > GameObject.Find("Main_character").transform.position.y )
        {
            transform.position =new Vector3(transform.localPosition.x, transform.localPosition.y-60, 0);
        }
    }
}
