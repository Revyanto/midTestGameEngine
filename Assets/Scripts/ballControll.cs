using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D> (); 
        Vector2 arah = new Vector2 (2, 0).normalized; 
        rigid.AddForce (arah * force);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
