using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orcamove : MonoBehaviour
{
    Vector3 startPositie;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        startPositie = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        transform.position = startPositie + new Vector3(0, Mathf.Sin(Time.time), 0);
        //transform.Rotate(Mathf.Sin(Time.time), 0, 0);
       transform.Rotate(0, Time.deltaTime * 30, 0);
       
    }
}
