using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarTrafficLeft : MonoBehaviour
{
    public float speed = 2f;
    public Transform road;
    public Vector2 direction;

    private void FixedUpdate()
    {
        /* if(transform.position.x < -6f)
         {
             transform.Translate(direction * Time.deltaTime);
         }*/

        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (transform.position.x < -15f)
        {
            Transform newObj = Instantiate(road, new Vector2(16f, 0.96f), Quaternion.identity);
            newObj.gameObject.name = newObj.gameObject.name.Replace("(Clone", "");
            Destroy(gameObject);
        }
    }
}
