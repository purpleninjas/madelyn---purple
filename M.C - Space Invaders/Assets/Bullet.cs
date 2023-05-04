using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public GameObject bulletPrefab;
    private Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {
        direction = Vector2.up;

    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(direction * Time.deltaTime);
        }
    }
}
