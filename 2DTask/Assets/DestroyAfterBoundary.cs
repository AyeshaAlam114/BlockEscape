using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterBoundary : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -6)
        {
            //for (int i = 0; i < this.transform.childCount; i++)
                Destroy(this.gameObject);
            //transform.position = new Vector2(-1.8f, 0.5f);
           // spawnref.SpawnBlocks();
        }
    }
}
