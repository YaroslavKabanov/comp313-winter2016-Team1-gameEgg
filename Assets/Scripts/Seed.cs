using UnityEngine;
using System.Collections;

public class Seed : MonoBehaviour {
	private static int pointsToAdd = 1;
	public AudioClip soundFile;
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Player") {
			ScoreManager.AddPoints (pointsToAdd);
			Destroy(gameObject);
		}  

	}
	void Start () {
		

	}
}
