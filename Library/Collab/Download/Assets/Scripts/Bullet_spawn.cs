using UnityEngine;
using System.Collections;

public class Bullet_spawn : MonoBehaviour
{   public float bulletWaitTime;
    public GameObject bullet;
    public Transform spawnpoint;
    public float bulletSpeed;
    public Vector3 direction;

    void Start() {
        bulletWaitTime = Random.Range(0.8f, 1.5f);
        direction = new Vector3(0.0f, 0.0f, Random.Range(160.0f, 200f));
        bulletSpeed = Random.Range(5.0f, 15.0f);
        StartCoroutine(Countdown1());
    }

    private IEnumerator Countdown1() {
    while(true) {
        yield return new WaitForSeconds(bulletWaitTime); 
        var callingBullet = Instantiate(bullet, spawnpoint.position, spawnpoint.rotation);
        callingBullet.GetComponent<Rigidbody2D>().velocity  = callingBullet.transform.right * bulletSpeed;
    }
    }

    void OnBecameInvisible() {
         Destroy(gameObject);
    }
}
