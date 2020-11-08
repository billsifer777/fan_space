using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bad_planets : MonoBehaviour
{
    public control control;
    public GameObject gg;
    public float Rotate;
    private Rigidbody2D rb;
    private Transform tr;
    // Start is called before the first frame update
    void Start()
    {
        rb=gg.GetComponent<Rigidbody2D>(); //кешируем физику гг
        tr=gg.GetComponent<Transform>();   //кешируем трансформ гг
    }

    // Update is called once per frame
    void Update()
{
    
        Vector2 DirectionPlanet1 = (transform.position-tr.position).normalized;  //вектор по направлению к планете
      
        if(control.fly)
            rb.AddForce(DirectionPlanet1*5); //придаем импульс гг
        
        transform.Rotate(0,0,Rotate);
    }
}
