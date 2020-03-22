using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Virus : MonoBehaviour
{
    //config params
    [SerializeField] Paddle hand;
    [SerializeField] float xPush;
    [SerializeField] float yPush;
    //state
    Vector2 handToVirusVector;
    bool hasStarted = false;
    void Start()
    {
        handToVirusVector = transform.position - hand.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(!hasStarted)
        {
            LockVirusToHand();
            LaunchOnClick();
        }
    }

    private void LaunchOnClick()
    {
        if(Input.GetMouseButtonDown(0))
        {
            hasStarted = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(xPush,yPush);
        }
    }
    private void LockVirusToHand()
    {
        Vector2 handPos = new Vector2(hand.transform.position.x,hand.transform.position.y);
        transform.position = handPos + handToVirusVector;
    }
}
