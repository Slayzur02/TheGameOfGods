using UnityEngine;
using System.Collections;
public class Cannon_spawn : MonoBehaviour
{ 
    public GameObject newestCannon;
    public float newestYPosition;
    public GameObject cannon;
    public Vector3 position;

    public Vector3 direction;

    public float MaxVal;
    void Start() {
        newestYPosition = Random.Range(1.0f, 3.0f);
        // StartCoroutine(Countdown1());
    }

    void Update() {
        MaxVal = GameObject.Find("Better_text").GetComponent<ScoreManager>().MaxVal;
        while(newestYPosition < MaxVal + 5) {
        direction = new Vector3(0.0f, 0.0f, Random.Range(-25f, 25f));
        position = new Vector3(Random.Range(2.6f, 4f), Random.Range(newestYPosition+3.5f, newestYPosition+5.2f), 0);
        newestCannon = Instantiate(cannon, position, Quaternion.Euler(direction));
        newestYPosition = newestCannon.transform.position.y;
    }
    }

    // private IEnumerator Countdown1() {
    // while(newestYPosition < MaxVal + 40) {
    //     // yield return new WaitForSeconds(2); 
    //     direction = new Vector3(0.0f, 0.0f, Random.Range(165f, 195f));
    //     position = new Vector3(Random.Range(1.8f, 2.2f), Random.Range(newestYPosition+1.0f, newestYPosition+3.0f), 0);
    //     newestCannon = Instantiate(cannon, position, Quaternion.Euler(direction));
    //     newestYPosition = newestCannon.transform.position.y;
    // }
    // }
} 
