using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour

{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Random.insideUnitCircle.normalized * 10;
    }
    public float speed;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * Time.deltaTime * speed);
        }
        if (transform.position.y < player.transform.position.y)
        {
            Time.timeScale = 0;
        }
    }
}
