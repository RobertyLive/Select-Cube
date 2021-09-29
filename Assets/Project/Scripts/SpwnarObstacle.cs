using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpwnarObstacle : MonoBehaviour
{
    public GameObject[] Obstacles;
    public float xPos;
    public float timeToInstantite = 0.5f;
    public Transform position;


    public bool ActiveCorrotine = true;
    private void Rand()
    {

        float randomX = Random.Range(-xPos, xPos);

        Vector3 randomPos = new Vector3(randomX, transform.position.y, transform.position.z);

       Instantiate(Obstacles[Random.Range(0, Obstacles.Length)], randomPos, transform.rotation);
        
      
    }

    private void Start()
    {
        StartCoroutine(timeToInstatiate());
    }

    IEnumerator timeToInstatiate()
    {
        while (true && ActiveCorrotine)
        {
            Rand();

            yield return new WaitForSeconds(timeToInstantite);
        }
    }
}
