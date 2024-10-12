using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class refill : MonoBehaviour
{
    public CARcontroller carcontroller;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D Collision){
        carcontroller.fuel=1;
        Destroy(gameObject);
    }
}
