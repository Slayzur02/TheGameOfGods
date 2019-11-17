using UnityEngine;
using System.Collections;
public class Cannon_spawn : MonoBehaviour
{ 
    public GameObject newestCannon;
    public float newestYPosition;
    public GameObject cannon;
    public Vector3 position;

    public Vector3 direction;

    public float scaleNumber;

    void Start() {
        newestYPosition = Random.Range(1.0f, 3.0f);

        StartCoroutine(Countdown1());
    }

    private IEnumerator Countdown1() {
    while(true) {
        yield return new WaitForSeconds(2); 
        direction = new Vector3(0.0f, 0.0f, Random.Range(190f,240f));
        scaleNumber = Random.Range(0.3f, 1.0f);
        position = new Vector3(Random.Range(1.8f, 2.2f), Random.Range(newestYPosition+1.0f, newestYPosition+3.0f), 0);
        newestCannon = Instantiate(cannon, position, Quaternion.Euler(direction));
        newestCannon.transform.localScale = Vector3.one * scaleNumber;
        newestYPosition = newestCannon.transform.position.y;
    }
    }
    void OnBecameInvisible() {
         Destroy(gameObject);
    }
}
