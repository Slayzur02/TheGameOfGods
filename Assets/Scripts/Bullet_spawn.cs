using UnityEngine;
using System.Collections;

public class Bullet_spawn : MonoBehaviour
{   public float bulletWaitTime;
    public GameObject bullet;
    public Transform spawnpoint;
    public float bulletSpeed;
    public Vector3 direction;
    public float scaleSize; 

    public bool shooting;
    public AudioClip cannonShoot;


    public Animator animator;
    void Start() {
        shooting = true;
        scaleSize = Random.Range(0.15f, 0.25f);
        transform.localScale = scaleSize * Vector3.one;
        bulletWaitTime = Random.Range(0.8f, 1.5f);
        direction = new Vector3(0.0f, 0.0f, Random.Range(160.0f, 200f));
        bulletSpeed = Random.Range(4.0f, 8.0f);
        StartCoroutine(Countdown1());
    }

    void Update()
    {
        if (transform.localPosition.y > GameObject.Find("Main_character").transform.position.y + 20 || 
        transform.localPosition.y < GameObject.Find("Main_character").transform.position.y - 20){
            shooting = false;
        }
        else shooting = true;
        
    }
    private IEnumerator Countdown1() {
    while(true) {
        yield return new WaitForSeconds(bulletWaitTime); 
        if (shooting){
            animator.Play("Cannon_fire");
            yield return new WaitForSeconds(0.44f);
            if (transform.localPosition.y < GameObject.Find("Main_character").transform.position.y + 9 &&
            transform.localPosition.y > GameObject.Find("Main_character").transform.position.y - 5)
            {
                GetComponent<AudioSource>().Play();
            }
            
            var callingBullet = Instantiate(bullet, spawnpoint.position, spawnpoint.rotation);
            callingBullet.GetComponent<Rigidbody2D>().velocity  = callingBullet.transform.right * bulletSpeed;
            callingBullet.transform.localScale = scaleSize * Vector3.one * 1;       
        }
    }
    }
} 