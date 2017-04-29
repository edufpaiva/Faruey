using UnityEngine;
using System.Collections;


public class nave : MonoBehaviour
{
	public float temp_anime;
	private float temp;
	private Animator anime; 
	private bool jaTrocou=true;


	// Use this for initialization
	void Start ()
	{
		anime = GetComponent<Animator> ();
	
	}
	
	// Update is called once per frame
	void Update ()
	{

		if(jaTrocou){

			Invoke ("trocaAnimacao", 1f);
			print ("foi");
			jaTrocou = false;
		
		}


	
	}

	void trocaAnimacao(){
		anime.SetBool ("troca", true);

	
	
	}
}
