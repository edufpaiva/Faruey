using UnityEngine;
using System.Collections;

public class WallController : MonoBehaviour {

	public float velocidadeParede, y;
	public GameObject outraWall;
	private Vector3 temp;
	
	
	

	void Start () {
		
		
	}
	

	void Update () {
        if (GameManager.Instance.GetPlayerMorto() || GameManager.Instance.GetPause())
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.down * 0;
            return;

        }
        else { 
        GetComponent<Rigidbody2D>().velocity = Vector2.down * velocidadeParede;

        }
    }

	void FixedUpdate(){

		//print (transform.position.y);
		if(transform.position.y < -63){


			temp.y = outraWall.transform.position.y + y;
			transform.position = new Vector3(transform.position.x, temp.y , transform.position.z );
			
		}


	} 
	
	
	
}
