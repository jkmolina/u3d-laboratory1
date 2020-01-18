using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelotaScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ball = GetComponent<Rigidbody>();
    }

    public float velocidadPelota;
    private Rigidbody ball;
    // Update is called once per frame
    void Update()
    {
        float xVelocidad = Input.GetAxis("Horizontal");
        float yVelocidad = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(xVelocidad, 0.0f, yVelocidad);

        ball.AddForce(movement * velocidadPelota);

    }
}
