using UnityEngine;

public class SPAWN : MonoBehaviour
{
    public Transform player;
    public float distanceBetweenLamps = 2.0f;
    public GameObject prefab;

    void Start()
    {
        Vector3 startPos = transform.position;
        Vector3 spawnPos;

        for (int i = 0; i < 10; i++) 
        {
            spawnPos = startPos + new Vector3(2, 0, i * distanceBetweenLamps);
            Instantiate(prefab, spawnPos, Quaternion.identity);
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
            Instantiate(prefab);
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 spawnPos = player.position + player.forward * distanceBetweenLamps;
            Instantiate(prefab, spawnPos, player.rotation);
        }
    }
}
