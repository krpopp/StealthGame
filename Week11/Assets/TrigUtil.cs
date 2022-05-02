using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigUtil : MonoBehaviour
{

    public float amplitude;
    public float frequency;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Mathf.Cos(Time.time * frequency) * amplitude;
        float y = Mathf.Sin(Time.time * frequency) * amplitude;
        //float y = transform.position.y;
        float z = transform.position.z;

        transform.position = new Vector3(x, y, z);
    }
}
