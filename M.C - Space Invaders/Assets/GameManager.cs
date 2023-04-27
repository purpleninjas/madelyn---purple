using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float xSpace;
    public float xOffset;
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        for(int x = 0; x < 10; x++)
        {
            Instantiate(enemy, new Vector2(x * xSpace + xOffset, 3), Quaternion.identity);
            Instantiate(enemy, new Vector2(x * xSpace + xOffset, 3.75f), Quaternion.identity);
            Instantiate(enemy, new Vector2(x * xSpace + xOffset, 4.5f), Quaternion.identity);
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
