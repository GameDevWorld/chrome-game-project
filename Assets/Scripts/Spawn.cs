using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Spawn : MonoBehaviour
{
    public float maxtime = 2f;
    float timer;
    public GameObject Cactus;
    public float speed = 20;
    GameObject newcac;

    private void Update()
    {

        Vector2 random = new Vector2(Random.Range(9f, 12f), -3.45f);

        timer += Time.deltaTime;

        if (timer > maxtime)
        {
            GameObject newcac = Instantiate(Cactus, random, transform.rotation);
            timer = 0;
            Destroy(newcac, 5f);
        }
        Destroy(newcac, 4f);
    }
   

}
