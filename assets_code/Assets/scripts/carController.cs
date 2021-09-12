using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carController : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody car;

    public float forwardAcceleration = 8f, turnstrength = 180f , maxSpeed = 10f;
    private float speedInput , turnInput;

    public AudioSource car_noises;

    void Update()
    {
        
        speedInput = 0f;
        if (Input.GetAxisRaw("Vertical") > 0)
        {
            speedInput = Input.GetAxisRaw("Vertical") * forwardAcceleration * 100f;
            
        }

        turnInput = Input.GetAxisRaw("Horizontal");

        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0, turnInput * turnstrength * Time.deltaTime * Input.GetAxisRaw("Vertical"), 0));

        transform.position = car.transform.position;

        
    }

    private void FixedUpdate()
    {
        if (car.velocity.magnitude < maxSpeed*100f)
        {
            if (Mathf.Abs(speedInput) > 0)
            {
                car_noises.Play();
                car.AddForce(transform.forward * Mathf.Abs(speedInput));
            }
        }
       
    }

    
}
