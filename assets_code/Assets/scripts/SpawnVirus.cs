using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnVirus : MonoBehaviour
{
    

    public GameObject virusPrefab;

    public Vector3 centre;
    public Vector3 size;

    private Vector3 pos;

    public float max_viruses = 40;

    //private void Start()
    //{
    //    SpawnViruses();
    //}
    void Update()
    {

        var number_of_carrots = GameObject.FindGameObjectsWithTag("virus");
        if (number_of_carrots.Length >= max_viruses)
        {
            return;
        }
        else
        {
            SpawnViruses();
        }

    }
    void SpawnViruses()
    {
        pos = centre + new Vector3(Random.Range(-size.x / 2, size.x / 2), 0, Random.Range(-size.z / 2, size.z / 2));
        Instantiate(virusPrefab, pos, Quaternion.identity);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(centre, size);
    }
}
