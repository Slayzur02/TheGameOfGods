using UnityEngine;
using System.Collections;
public class Bullet_fire : MonoBehaviour
{
        
    // public float bulletSpeed;
    // void Start(){
    //     bulletSpeed = GameObject.Find("Triangle").GetComponent<Bullet_spawn>().bulletSpeed;
    // }
    
    // void OnTriggerEnter2D(Collider2D target) {
    //     // if (target.gameObject.tag == "FirePoint") GetComponent<Rigidbody2D>().AddForce((transform.right* bulletForce));
    //     if (target.gameObject.tag == "FirePoint") GetComponent<Rigidbody2D>().velocity = transform.right*bulletSpeed;
    //     Debug.Log(bulletSpeed);
    // }

    private void Update()
    {
        if (transform.localPosition.x < -20){
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Main_character" && GameObject.Find("Main_character").GetComponent<Ship_behaviour>().death == false){
            Destroy(gameObject);
            GameObject.Find("Main_character").GetComponent<Ship_behaviour>().deathPlay();
            GameObject.Find("CameraCenter").GetComponent<CameraCenterControl>().Died();
            GameObject.Find("Better_text").GetComponent<ScoreManager>().setHighScore();   
            GameObject.Find("Canvas").GetComponent<PauseMenu>().showDeathScreen();
        }
    }
}
