using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public float minRange;
    public float maxRange;
    float horizontalInput;

    public ScoreManager scoreManager;
    bool once;
    

    // Start is called before the first frame update
    void Start()
    {
        once = false;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * Time.deltaTime * moveSpeed * horizontalInput);
        if (transform.position.x < minRange)
            transform.position= new Vector3( minRange,-4,-1);
        if (transform.position.x > maxRange)
            transform.position = new Vector3(maxRange, -4,-1);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        once = true;
        if (once)
        {
            once = false;
            scoreManager.DeductScore();
        }
        Debug.Log(collision.gameObject.name);
    }
}
