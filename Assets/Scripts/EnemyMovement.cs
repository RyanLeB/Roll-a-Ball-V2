using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EnemyMovement : MonoBehaviour
{
    public float distance = 0.5f; // how far the object moves
    public float speed = 1.0f; // how fast the object moves

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }



    void Update()
    {
        float newPosition = Mathf.Sin(Time.time * speed) * distance;
        transform.position = startPosition + new Vector3(newPosition, 0, 0);
    
    
    }
    
    


}