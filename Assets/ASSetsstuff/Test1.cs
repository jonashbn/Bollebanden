using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour
{
    // Dræb mig
public float speed; 
public int Dob; 
public int i;
//Rigidbody RB;


    // Start is called before the first frame update
    void Start()
    {
       // RB = GetComponent<Rigidbody>();
      //   RB.velocity = new Vector3(10*speed*Time.deltaTime,0,0);
      i = 10;

    }

    // Update is called once per frame
    void Update()
    { 
        MovementManager();
        CountToSomething(i);

    }

    public void CountToSomething(int k)
    {
        for(int j = 0; j < k; j++)
        {
            print(j);
        }
    }

    public void MovementManager()
    {
        if(transform.position.x < 10)
        {
        transform.position += new Vector3(1,0,0)*speed * Time.deltaTime;
        transform.Rotate(0,1*Dob*Time.deltaTime,0);
    
        }
        else
        {
            Destroy(gameObject);
        }


    


    }
}
