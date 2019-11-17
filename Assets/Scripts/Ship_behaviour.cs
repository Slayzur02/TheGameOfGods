using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class Ship_behaviour : MonoBehaviour
{
    public Rigidbody2D ship;
    public bool death = false;
    public bool up = true;
    public float degrees = 1f;
    public float shipspeed = 10.0f;
    public Animator animator;
    public GameObject ButtonGameObject;

    void Start()
    {
        ship = GetComponent<Rigidbody2D>();
        
    }


    void Update()
    {   
        if (PauseMenu.GameIsPaused==false)
        {   
                if (Input.GetMouseButtonDown(0) && death == false && EventSystem.current.currentSelectedGameObject != ButtonGameObject) 
                {        
                    shipspeed = shipspeed * (-1);
                    RotateUpsideDown();
                }

        }
        
        ship.velocity = new Vector2(ship.velocity.x, shipspeed);
    }
    
    public void RotateUpsideDown()
    {
        up = !up;
        transform.RotateAround(transform.position, Vector3.forward, 180);
    }
    public void deathPlay(){
        shipspeed = 0;
        if (!up){
            transform.Rotate(0,180,0);
        }
        GetComponent<AudioSource>().Play();
        animator.Play("Death_animation");
        death= true;
    }

}
