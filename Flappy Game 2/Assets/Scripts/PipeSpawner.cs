using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;

    public float delay;

    private float timer;

    public float heightRange;

    void Start()
    {
        timer = 0;
    }

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
        Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(-heightRange, heightRange), 0);
        GameObject pipe = Instantiate(pipePrefab, spawnPos, Quaternion.identity);

        Destroy(pipe, 10f);
    }
}
