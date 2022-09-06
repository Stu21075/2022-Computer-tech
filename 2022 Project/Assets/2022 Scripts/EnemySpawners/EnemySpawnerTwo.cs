using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerTwo : MonoBehaviour
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
            xPos = Random.Range(240, 260);
            zPos = Random.Range(70, 40);
            yPos = Random.Range(2, 2);
            Instantiate(theEnemy, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            yield return new WaitForSeconds(15f);
            enemyCount += 1;

        }


    }
}