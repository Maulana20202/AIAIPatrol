using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyed : MonoBehaviour
{

    public bool M_nempel;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnCollisionEnter(Collision col){

        M_nempel = true;
        if(col.gameObject.tag.Equals("Enemy") == true){
            Destroy(gameObject);
        }

    }
}
