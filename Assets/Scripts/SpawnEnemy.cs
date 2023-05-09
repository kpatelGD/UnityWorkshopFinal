using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemy;
    public int xPos;
    public int zPos;
    private float yPos = 0.5f;
    public int enemyCount;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator Spawn()
    {
        //xPos = Random.Range(0,-39)
        //zPos = Random.Range(-39,39)
        while (enemyCount < 15)
        {
            xPos = Random.Range(0, -39);
            zPos = Random.Range(-39, 39);
            Instantiate(enemy, new Vector3(xPos, 0.5f, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.75f);
            enemyCount++;
        }
    }
}
