using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float thing3 = 0;

    // Update is called once per frame
    void Update()
    {
        thing3 += Time.deltaTime;
        // On spacebar press, send dog
        if (thing3 > 1.0f)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                thing3 = 0;
            }
        }
    }
}
