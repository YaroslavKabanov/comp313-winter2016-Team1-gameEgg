using UnityEngine;
using System.Collections;

public class PlayBtn : MonoBehaviour {

	public void Play(){
		//ChangeLevel();
		Application.LoadLevel ("farm");
	}
//	IEnumerator ChangeLevel(){
//		//fade out  the game  and load a new level
//		float fadeTime  = GameObject.Find("_Manager").GetComponent<Fading>().BeginFade(1);
//		yield return new WaitForSeconds (fadeTime);
//
//
//	}
}
