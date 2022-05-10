using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CarTrafficRight : MonoBehaviour
{
    public float speed = 5;
    public Transform road;
    public Vector2 direction;

    private void FixedUpdate()
    {
        /* if(transform.position.x < -6f)
         {
             transform.Translate(direction * Time.deltaTime);
         }*/
       
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        if (transform.position.x > 15f)
        {
            Transform newObj = Instantiate(road, new Vector2(-15f, -1.32f), Quaternion.identity);
            newObj.gameObject.name = newObj.gameObject.name.Replace("(Clone", "");
            Destroy(gameObject);
        }
    }


}