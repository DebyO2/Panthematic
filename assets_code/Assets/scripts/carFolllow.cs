using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carFolllow : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Player;
    public GameObject child;
    public float speed = 5f;
    private void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        child = Player.transform.Find("CameraConstraint").gameObject;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        follow();   
    }

    private void follow()
    {
        gameObject.transform.position = Vector3.Lerp(transform.position, child.transform.position, Time.deltaTime * speed);
        gameObject.transform.LookAt(Player.gameObject.transform.position);
    }
}
