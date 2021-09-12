using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] float interval;
    [SerializeField] GameObject tube;
    [SerializeField] float minY;
    [SerializeField] float maxY;

    private float time;

    private void Update()
    {
        time += Time.deltaTime;

        if(time >= interval)
        {
            Spawn();
            time = 0;
        }
    }

    private void Spawn()
    {
        GameObject clone = Instantiate(tube);
        clone.transform.position = new Vector3(transform.position.x, Random.Range(minY, maxY), transform.position.z);

        Destroy(clone, 10);
    }
}
