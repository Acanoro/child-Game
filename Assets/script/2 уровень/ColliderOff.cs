using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderOff : MonoBehaviour
{
    
    public void CollOff()
    {
        GetComponent<BoxCollider2D>().enabled = false;
    }
}
