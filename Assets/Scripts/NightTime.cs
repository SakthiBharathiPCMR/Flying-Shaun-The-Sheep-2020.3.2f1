using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightTime : MonoBehaviour
{
    public GameObject night;
    float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if(timer<15f)
        {
            timer += Time.deltaTime;
            night.SetActive(false);
        }
      else if(timer>15&&timer<30)
        {
            timer += Time.deltaTime;
            night.SetActive(true);
        }
        else
        {
            timer = 0;
        }
    }
}
