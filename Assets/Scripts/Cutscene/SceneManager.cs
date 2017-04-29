using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour {
    private bool proximaCena = true;
	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {

        if (proximaCena) {


            Invoke("ProximaCena", 2f);
            proximaCena = false;


        }
        
    }

    void ProximaCena() { Application.LoadLevelAsync("GamePlay"); }
}
