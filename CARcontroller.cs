using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CARcontroller : MonoBehaviour

{
public Rigidbody2D backTire;
public Rigidbody2D frontTire;
public Rigidbody2D carRigidbody;
public AudioSource audioSource;
private float movement;
public float speed=5;
public float carRotation=10;
public float fuel=0.1f;
public float fuelconsumption;
public UnityEngine.UI.Image image;
    // Start is called before the first frame update
    void Start()
    {
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        movement=Input.GetAxis("Horizontal");
        image.fillAmount=fuel;
    }
    private void FixedUpdate(){
        if(fuel>0){
            backTire.AddTorque(-movement* speed * Time.deltaTime);
            frontTire.AddTorque(-movement* speed * Time.deltaTime);
            carRigidbody.AddTorque(-movement* carRotation * Time.deltaTime);
            fuel-=fuelconsumption*MathF.Abs(movement)*Time.deltaTime;
        }
        
    }
    public void GameOver(){
        speed=0;
        SceneManager.LoadScene("gameover scene", LoadSceneMode.Single);
    }
}
