using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class PlayerControllerX : MonoBehaviour
//{
//    public GameObject dogPrefab;

//    // Update is called once per frame
//    void Update()
//    {
//        // On spacebar press, send dog
//        if (Input.GetKeyDown(KeyCode.Space))
//        {
//            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
//        }
//    }
//}

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float spawnRate = 2f;
    private float timeStamp = 0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time >= timeStamp)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            timeStamp = Time.time + spawnRate;
        }
    }
}