using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

public class SpawnerPipe : MonoBehaviour
{
    [SerializeField]
    private GameObject tile;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine (Spawner ());
    }
    IEnumerator Spawner() {
        yield return new WaitForSeconds(2);
        Vector3 temp = tile.transform.position;
        temp.x = Random.Range(3.0f, 10.0f);
        temp.y = Random.Range(-5.0f, -3.0f);
        Instantiate(tile, temp, Quaternion.identity);
        StartCoroutine (Spawner ());
    }
}
