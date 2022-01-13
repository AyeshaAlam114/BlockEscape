using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public Transform[] spawnPositionsArr;
    public GameObject blockPrefab;
    public GameObject blockParent;
    // Start is called before the first frame update
    void Start()
    {
       // SpawnBlocks();
        InvokeRepeating("SpawnBlocks", 0.5f, 1.2f);
    }

    // Update is called once per frame
    void Update()
    {
        //if (blockParent.transform.childCount == 0)
        //{
        //   // Debug.Log("111");
           

        //}
    }

    public void SpawnBlocks()
    {
        blockParent.transform.position = new Vector2(-1.8f, 0.5f);
        int a = Random.Range(0, 4);
        for(int i = 0; i < 4; i++)
        {
            if (i != a)
                Instantiate(blockPrefab, spawnPositionsArr[i].transform.position, Quaternion.identity, blockParent.transform);
        }
    }
}
