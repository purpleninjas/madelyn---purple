using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public LayerMask obstacleLayer;
    public List<Vector2> availableDirections;

    private void CheckAvaiableDirection(Vector2 newDirection)
    {
        RaycastHit2D hit = Physics2D.BoxCast(transform.position, Vector2.one * 0.75f, 0f, newDirection, 1.5f, obstacleLayer);
        if (hit.collider == null)
        {
            availableDirections.Add(newDirection);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        availableDirections = new List<Vector2>();

        CheckAvaiableDirection(Vector2.up);
        CheckAvaiableDirection(Vector2.down);
        CheckAvaiableDirection(Vector2.left);
        CheckAvaiableDirection(Vector2.right);
    }
    

    
    // Update is called once per frame
    void Update()
    {
        
    }
}
