using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerLogic : MonoBehaviour
{
    public float health = 100;

    public healthBar healthbar;

    public Rigidbody car;

    public GameObject virusDead;
    public GameObject picked;

    public AudioSource pickup, killed_virus, gameover;

    public GameObject gameover_screen;

    public GameObject Fps;

    private void Start()
    {
        
    }

    void Update()
    {
        if (health <= 0)
        {
            health = 0f;
            gameover_screen.SetActive(true);
            gameObject.SetActive(false);
            gameover.Play();
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Fps.SetActive(false);
            Time.timeScale = 0f;
        }

        if (health >= 100)
        {
            health = 100f;
        }

        takedamage(5f * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "boosters")
        {
            pickup.Play();
            Destroy(other.gameObject);
            Destroy(Instantiate(picked, other.transform.position, Quaternion.identity), 1f);
            takehealth(10);
            //Debug.Log("got some health");
        }

        if (other.tag == "virus")
        {
            killed_virus.Play();
            Destroy(Instantiate(virusDead, other.transform.position, Quaternion.identity), 1f);
            Destroy(other.gameObject);
            takedamage(25);
        //    Debug.Log("took some damage");
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "ground")
        {
            
            takedamage(12f);
           
           // Debug.Log("you crashed");
           
        }
    }

    public void takedamage(float amount)
    {
        health -= amount;
        healthbar.SetHealth(health);
    }
    public void takehealth(int amount)
    {
        health += amount;
        healthbar.SetHealth(health);
    }
}
