using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnCarrots : MonoBehaviour
{
    public GameObject Carrotprefab;

    public Vector3 centre;
    public Vector3 size;

    public float max_carrots = 8;

    public GameObject spawn;

    void Update()
    {
        var number_of_carrots = GameObject.FindGameObjectsWithTag("boosters");
        if(number_of_carrots.Length == max_carrots)
        {
            return;
        }
        else
        {
            SpawnCarrots();
        }
        
    }

    public void SpawnCarrots()
    {
        Vector3 pos = centre + new Vector3(Random.Range(-size.x / 2, size.x /2), 0 , Random.Range(-size.z / 2, size.z / 2));
        GameObject evo = Instantiate(spawn, pos, Quaternion.identity);
        Destroy(evo, 1f);

        Instantiate(Carrotprefab, pos, Quaternion.identity);
    }
    
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(centre, size);
    }
}
