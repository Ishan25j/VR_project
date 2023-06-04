using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Transform[] spheres;
    
    public void updatePosition(int i)
    {
        transform.position = spheres[i].position;
    }
}
