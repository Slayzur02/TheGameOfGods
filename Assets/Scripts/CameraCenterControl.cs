using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class CameraCenterControl : MonoBehaviour
{
    public Rigidbody2D CameraCenter;
    public bool death = false;
    public float movespeed = 3f;
    public Animator animator_this;
    public Animator second_cam; 
    public GameObject ButtonGameObject;
    // Start is called before the first frame update
    void Start()
    {
        animator_this.Play("normal mode");
        StartCoroutine(stopAnimation());
        second_cam.Play("Zoomed_in");
        CameraCenter = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(CameraCenter.transform.localPosition.y);
        if (Input.GetMouseButtonDown(0) && death == false && PauseMenu.GameIsPaused == false && EventSystem.current.currentSelectedGameObject != ButtonGameObject)
        {
            movespeed = movespeed * (-1);
        }
        CameraCenter.velocity = new Vector2(CameraCenter.velocity.x, movespeed);
        
    }

    public void Died(){
        death = true;
        if (PlayerPrefs.GetString("Vibrate", "true")=="true")
        {
            Handheld.Vibrate();
        }
        
        GameObject.Find("Main Camera").GetComponent<CameraFollow>().camShaker();
        if (movespeed > 0){
            while (movespeed > 0.2)
            {
            movespeed -=0.2f;
            }
        }
        else if (movespeed < 0 ){
            while (movespeed < -0.2)
            {
            movespeed +=0.2f;
            }
        }
        
    }

    private IEnumerator stopAnimation()
    {
        yield return new WaitForSeconds(1.0f);
        GetComponent<Animator>().enabled = false;
    }
}
