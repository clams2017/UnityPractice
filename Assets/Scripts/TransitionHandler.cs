using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionHandler : MonoBehaviour {

	public void toTopScene(){
		SceneManager.LoadScene ("Top");
	}

	public void toCompleteListScene(){
		SceneManager.LoadScene ("CompleteList");
	}

	public void toBreedingScene(){
		SceneManager.LoadScene ("Breeding");
	}

	public void toSettingScene(){
		SceneManager.LoadScene ("Setting");
	}
}
