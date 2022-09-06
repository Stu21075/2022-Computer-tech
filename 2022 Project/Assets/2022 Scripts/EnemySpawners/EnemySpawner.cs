 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject theEnemy;
    public int xPos;
    public int yPos;
    public int zPos;
    public int enemyCount;


    void Start()
    {
        StartCoroutine(EnemyDrop());

    }

    IEnumerator EnemyDrop()
    {
        while (enemyCount < 20)
        {
            xPos = Random.Range(210, 230);
            zPos = Random.Range(-10, 30);
            yPos = Random.Range(2,2);
            Instantiate(theEnemy, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            yield return new WaitForSeconds(15f);
            enemyCount += 1;

        }


    }
}