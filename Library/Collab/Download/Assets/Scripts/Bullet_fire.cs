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

    void OnBecameInvisible() {
         Destroy(gameObject);
    }
}
