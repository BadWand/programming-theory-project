using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public float obs_speed;
    public float waitBtw;

    float dashwait;
    public GameObject[] obstacleArray;

    public List<GameObject> obstacles;
    float counter;
    // Start is called before the first frame update
    void Start()
    {
        counter = waitBtw;
        dashwait = waitBtw / 1.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerController.shouldMoveLeft)
        {
            if (PlayerController.isFaster)
                SpawnObstacle(dashwait);
            else
                SpawnObstacle(waitBtw);


        }
        if (obstacles != null)
        {

            for (int i = 0; i < obstacles.Count; i++)
            {
                if (obstacles[i] == null)
                {
                    obstacles.Remove(obstacles[i]);
                }
                else
                    obstacles[i].transform.Translate(Vector3.right * -obs_speed * Time.deltaTime);
                
            }
        }
    }


    void SpawnObstacle(float wait)
    {
        counter -= Time.deltaTime;
        if (counter <= 0)
        {
            counter = waitBtw;
            int x = Random.Range(0, obstacleArray.Length);
            GameObject obst = Instantiate(obstacleArray[x], this.transform.position, Quaternion.identity) as GameObject;
            obstacles.Add(obst);
            Destroy(obst, 4f);
        }

        
    }
}
