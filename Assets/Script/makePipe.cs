using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makePipe : MonoBehaviour
{
    public GameObject pipes; 
    public float responTime =2.5f;
    float timer =0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > responTime)
        {
        GameObject newpipe = Instantiate(pipes);
        newpipe.transform.position = new Vector3(4,Random.Range(-1.0f,4.5f),0);
        timer = 0;
        Destroy(newpipe,5);
        }
    }
}
