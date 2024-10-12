using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Startbutton : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartGame(){
        SceneManager.LoadScene("game scene", LoadSceneMode.Single);
    }
}
