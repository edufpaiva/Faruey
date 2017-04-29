using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {
    public AudioSource exp1, exp2, exp3;
    public float intervaloSom;
	// Use this for initialization
	void Start () {
        if (GameManager.Instance.GetMudo())
        {
            Camera.main.gameObject.GetComponent<AudioListener>().enabled = false;
            //print(GameManager.Instance.GetMudo());
        }
        else {

            Som1();
        }
        

	}
	
	// Update is called once per frame
	void Update () {
        
	}

    void Som1() {
        exp1.Play();
        Invoke("Som2", intervaloSom);
    }

    void Som2()
    {
        exp1.Play();
        Invoke("Som3", intervaloSom);

    }
    void Som3()
    {
        exp1.Play();
        Invoke("Som1", intervaloSom);
    }
}
