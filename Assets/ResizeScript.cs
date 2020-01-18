using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizeScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.X))
        {
            double x = 0.1;
            double y = 0.1;
            double z = 0.1;
            transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
        }
        else if (Input.GetKey(KeyCode.Z))
        {
            transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
        }
    }
}
