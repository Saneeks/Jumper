using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    void Update()
    {
        if(transform.position.x <= -22)
        {
            transform.Translate(22*2, 0, 0);
        }
    }
}
