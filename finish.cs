using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finish : MonoBehaviour
{
    public CARcontroller carcontroller;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D Collision){
        carcontroller.GameOver();
    }
}
