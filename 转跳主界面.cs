using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class 转跳主界面 : MonoBehaviour {

	public Button mButton;
	public GameObject caidan;

	// Use this for initialization
	void Start () {
		//Gets ButtonMount
		Button btnMount = mButton.GetComponent<Button>();
		//add a listener to ButtonMount, executing TaskOnClick() when click ButtonMount
		btnMount.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		//Loading Scene1
		caidan.SetActive (true);
		UnityEngine.SceneManagement.SceneManager.LoadScene(0);
	}

}
