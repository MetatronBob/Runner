using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreatRoad : MonoBehaviour
{
    public GameObject[] roads;
    private float spawnPos = 0;
    private float tileLength = 200;
    [SerializeField] private Transform player;
    private List<GameObject> activeRoad = new List<GameObject>();
      void Start()
    {

        SpawnRoad(0);
        SpawnRoad(1);
        SpawnRoad(2);
    }

    // Update is called once per frame
    void Update()
    {
        if (player.position.z > spawnPos - (3 * tileLength))
        {
            SpawnRoad(Random.Range(0,roads.Length));
            DeleteRoad();
        }
    }
    private void SpawnRoad(int RoadIndex)
    {
        roads[RoadIndex].transform.eulerAngles = new Vector3(0, 90, 0);
        GameObject nextTile = Instantiate(roads[RoadIndex], new Vector3(0, 0, -100 + spawnPos), transform.rotation) ;
        nextTile.transform.Rotate(0, 90, 0);
        activeRoad.Add(nextTile);
        spawnPos += tileLength;
    }
    private void DeleteRoad()
    {
        Destroy(activeRoad[0]);
        activeRoad.RemoveAt(0);
    }

}
