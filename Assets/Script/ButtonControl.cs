using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ButtonBginnerPressed(){
      Debug.Log("Start Button is pressd");
      SceneManager.LoadScene("Ballmove");
    }
    public void ButtonIntermediatePressed(){
      SceneManager.LoadScene("Ballmove1");
    }
    public void ButtonAdvanedPressd(){
      SceneManager.LoadScene("Ballmove2");
    }
}
