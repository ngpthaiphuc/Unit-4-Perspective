using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject9 : MonoBehaviour
{
    // Scene 6: Add SerializeField so it can be edited in the component
    [SerializeField] float moveSpeed;
    [SerializeField] Vector3 moveDirection;

    // Scene 8: syntax error -> needs to specify type float
    float totalMoveDistance;
    Vector3 startingLocation;

    // Start is called before the first frame update
    void Start()
    {
        totalMoveDistance = 10f;
        startingLocation = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float distanceTraveled = GetDistanceTraveled();

        if (distanceTraveled > totalMoveDistance)
        {
            FlipMoveDirection();
            this.enabled = false;
        }

        gameObject.transform.Translate(moveDirection * moveSpeed);
    }

    void FlipMoveDirection()
    {
        moveDirection = -moveDirection;
        //Scene 9: reset startingLocation to the current object location so the door doesn't move infinitely
        startingLocation = gameObject.transform.position;
    }

    float GetDistanceTraveled()
    {
        return Vector3.Distance(gameObject.transform.position, startingLocation);
    }
}
