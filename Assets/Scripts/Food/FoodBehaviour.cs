using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class FoodBehaviour : MonoBehaviour
{
    public List<GameObject> foodPositions;
    public float timeToWait;

    private void Start()
    {
        StartCoroutine(SpawnRandomFood());
    }


    IEnumerator SpawnRandomFood()
    {
        while (true)
        {
            DisablePreviousFood();
            int rand = UnityEngine.Random.Range(0, foodPositions.Count);
            foodPositions[rand].SetActive(true);
            foreach (BoidAgent boid in BoidManager.instance.allBoids)
            {
                boid.seekTarget = foodPositions[rand];
            }
            yield return new WaitForSeconds(10);
        }
    }
    
    void DisablePreviousFood()
    {
        foreach (GameObject g in foodPositions)
        {
            g.SetActive(false);
        }
    }
}
