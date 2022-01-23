using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDownward : MonoBehaviour
{
    public float speed;
    public SpawnManager spawnref;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector2.down * Time.deltaTime * speed);
        //if (transform.childCount == 0)
        //{
        //    //for(int i=0;i<this.transform.childCount;i++)
        //    //    Destroy(transform.GetChild(i).gameObject);
        //    transform.position=new Vector2(-1.8f, 0.5f);
        //    spawnref.SpawnBlocks();
        //}
    }
}
