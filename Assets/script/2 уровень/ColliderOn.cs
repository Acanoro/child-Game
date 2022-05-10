using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderOn : MonoBehaviour
{
    private void Start()
    {
        GetComponent<BoxCollider2D>().enabled = false;
    }
    public void CollOn()
    {
        GetComponent<BoxCollider2D>().enabled = true;
    }
}
