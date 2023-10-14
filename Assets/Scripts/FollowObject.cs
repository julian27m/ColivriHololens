using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowObject : MonoBehaviour
{
    public Transform targetObject; // The object to follow
    public Vector3 offset; // The offset from the target object's position

    void Update()
    {
        if (targetObject != null)
        {
            // Set the position of this object to the target's position + offset
            transform.position = targetObject.position + offset;
        }
    }
}
