using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class ClickForURL : MonoBehaviour {

	public GameObject tutorialPage;
	public GameObject bottom;
	public GameObject scanPage;
	bool iamready = true;

	public void Update(){

		Debug.Log (Application.persistentDataPath);

		if (tutorialPage.activeSelf && iamready) {
			
						if (File.Exists (Application.persistentDataPath + "/tutorial")) {

							tutorialPage.SetActive (false);
							scanPage.SetActive (true);

				bottom.SetActive (false);

						} else if (!File.Exists (Application.persistentDataPath + "/tutorial")) {

							tutorialPage.SetActive (true);

							File.Create (Application.persistentDataPath + "/tutorial");
						}

			iamready = false;

		}

	}

	public void ClickFoodAbout(){
	
		Application.OpenURL ("https://sugarpoke.wixsite.com/echo4good");

	}
		
	public void CloseTutorial(){

		tutorialPage.SetActive (false);
		bottom.SetActive (false);
		scanPage.SetActive (true);

	}

}
