using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger : MonoBehaviour
{
    
    public string scene="";
    private string activeScene;
    // Start is called before the first frame update
    void Start()
    {
        activeScene = SceneManager.GetActiveScene().name;
        
        
        if (scene == "")
        {
            scene = activeScene;
            
        }
       

        
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (activeScene!= "rocket")
        {
            ShowCanvas.ShowScreen();
        }
        else if (other.gameObject.tag == "Player")
        {
            Application.LoadLevel(scene);
        }
       
    }



}
