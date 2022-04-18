using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle25 : MonoBehaviour
{
    [SerializeField]
    private GameObject obstacle;
    private float randomPosicionX=0;
    private float randomPosicionZ=0;
    public static List<GameObject> listObstacle = new List<GameObject>();
    private GameObject vehicle;
    private GameObject destroyObtacle;
    [SerializeField]
    private GameObject[] obstacleMass;
    [SerializeField]
    private float addRoadCount=0;
   
  
    void Start()
    {
        
        vehicle = GameObject.Find("Vehicle");
        obstacle.transform.position = new Vector3(0, 0, 0);
    }
    void Update()
    {

        CreateObtacle();
        RemoveObtacle();

       






    }
    //private void GanaredeObstacle(int obstacleCount)
    //{
    //    obstacleMass = new GameObject[obstacleCount];
    //    for (int i = 0; i < obstacleMass.Length; i++)
    //    {

    //        obstacleMass[0].transform.position = new Vector3(0, 0, 0);
    //        randomPosicionX = Random.Range(-10, 10);

    //        randomPosicionZ = Random.Range(transform.position.z, obstacleMass[i].transform.position.z + 20);

    //        obstacleMass[i].transform.position = new Vector3(randomPosicionX, 1.5f, randomPosicionZ);
            
    //    }
    //}
    private void CreateObtacle()
    {
        randomPosicionZ = Random.Range(vehicle.transform.position.z + 200, obstacle.transform.position.z + 120);
        Debug.Log(randomPosicionZ);
        if (randomPosicionZ > obstacle.transform.position.z && transform.position.z > obstacle.transform.position.z)
        {
            randomPosicionX = Random.Range(-10, 10);
            obstacle.transform.position = new Vector3(randomPosicionX, 1.5f, randomPosicionZ);
            destroyObtacle = Instantiate(obstacle, obstacle.transform.position, Quaternion.identity);
            Debug.Log(destroyObtacle.transform.position);
            listObstacle.Add(destroyObtacle);

        }
    }
    private void RemoveObtacle()
    {
        for (int i = 0; i < listObstacle.Count; i++)
        {
            if (vehicle.transform.position.z > listObstacle[i].transform.position.z && listObstacle[i])
            {
                Destroy(listObstacle[i]);
                listObstacle.RemoveAt(i);
            }
        }
    }
}

