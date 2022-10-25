using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCemera : MonoBehaviour
{
    [SerializeField] GameObject thingToFollow;
    //This things positin (camera) should be the same as the car's position
    void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + new Vector3(0, 0, -10);
    }
}
