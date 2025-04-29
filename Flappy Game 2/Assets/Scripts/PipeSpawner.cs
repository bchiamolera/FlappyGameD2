using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;

    public float delay;

    private float timer;

    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (timer > delay)
        {
            SpawnPipe();
            timer = 0;
        }

        timer += Time.deltaTime;
    }

    void SpawnPipe()
    {
        Vector3 spawnPos = transform.position;
        Instantiate(pipePrefab, spawnPos, Quaternion.identity);
    }
}
