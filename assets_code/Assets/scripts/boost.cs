using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boost : MonoBehaviour
{
    public Rigidbody car;
    public float boost_amount = 350 ;
    bool isdashing;
    public Slider slider;

    public AudioSource whoosh;

    public GameObject esc;
    private void Start()
    {
        slider.value = slider.maxValue;
    }

    void Update()
    {
        recharge();
        if (Input.GetKeyDown(KeyCode.LeftShift) && slider.value == slider.maxValue)
        {
            whoosh.Play();
            useBoost();
            isdashing = true;
        }
    }
    private void FixedUpdate()
    {
        if (isdashing)
        {
            dash();
        }
    }
    private void dash()
    {
        car.AddForce(car.transform.forward * boost_amount , ForceMode.Impulse);
        isdashing = false;
    }

    void recharge()
    {
        if (esc.activeInHierarchy == false)
        {
            slider.value += 0.1f;
        }
    }

    void useBoost()
    {
        slider.value = 15;
    }
}
