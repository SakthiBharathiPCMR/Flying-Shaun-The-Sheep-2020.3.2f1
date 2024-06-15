using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPipe : MonoBehaviour
{
    public GameObject pipe;
    float timer;
    float minY, MaxY;
    // Start is called before the first frame update
    void Start()
    {
        minY = -4f;
        MaxY = -7.5f;
        SpawnThePipe();
       
    }

    // Update is called once per frame
    void Update()
    {
        if(timer<Random.Range(2f,3f))
        {
            timer += Time.deltaTime;
            
        }
        else
        {
            SpawnThePipe();
            timer = 0;
        }
        
    }

    void SpawnThePipe()
    {
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(minY, MaxY), 0), transform.rotation);
    }
}
