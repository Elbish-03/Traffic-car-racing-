
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background_mov : MonoBehaviour
{
    public float speed = 4f;
    private Vector3 startPosition;
    void Start()
    {
        startPosition = transform.position;
    }
// Update is called once per frame
void Update()
    {                                                
    transform.Translate(translation:Vector3.down * speed * Time.deltaTime);
    }
}
