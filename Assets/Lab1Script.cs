using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab1Script : MonoBehaviour
{

    public float speed;

    public Vector3 oscilate;
    // Start is called before the first frame update
    void Start()
    {
        oscilate = transform.localPosition;
    }



    // Update is called once per frame
    void Update()
    {
        transform.localPosition=new Vector3 (oscilate.x + Mathf.Sin(Time.time * 2f), oscilate.y, oscilate.z);
    }
}
