using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] tetrominos;

    public void Spawn()
    {
        int rand = Random.Range(0, tetrominos.Length);
        Instantiate(tetrominos[rand], transform.position, Quaternion.identity);
    }

    void Start()
    {
        Spawn();
    }
}
