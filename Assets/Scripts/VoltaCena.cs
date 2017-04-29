using UnityEngine;
using System.Collections;



public class VoltaCena : MonoBehaviour {
    public string nomeDaCena;
    public bool sairDoJogo = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (sairDoJogo) { Application.Quit(); }
            Time.timeScale = 1;
            GameManager.Instance.setPlayerVivo();
            UnityEngine.SceneManagement.SceneManager.LoadScene(nomeDaCena);
            if (GameManager.Instance.GetPause()) { GameManager.Instance.SetPause(); }
            GameManager.Instance.SetPontos(0);


        }
        
        
    }
}
