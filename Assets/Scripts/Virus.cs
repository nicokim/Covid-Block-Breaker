using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Virus : MonoBehaviour
{
    //config params
    [SerializeField] Paddle hand;
    //state
    Vector2 handToVirusVector;
    void Start()
    {
        handToVirusVector = transform.position - hand.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 handPos = new Vector2(hand.transform.position.x,hand.transform.position.y);
        transform.position = handPos + handToVirusVector;
    }
}
