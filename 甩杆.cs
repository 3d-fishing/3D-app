using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class 甩杆 : MonoBehaviour {

	public GameObject btnObj;
	public GameObject yugan;
	public GameObject yu1;
	public GameObject yuwenzi1;
	public GameObject yu2;
	public GameObject yuwenzi2;
	public GameObject shibai;
	public Sprite   expan;
	public Sprite  back;
	Button btn;
	bool isshow=false ;

	// Use this for initialization
	void Start () {
		btn = btnObj.GetComponent<Button>();
		btn.onClick.AddListener(delegate ()
			{
				yu1.SetActive (false);
				yu2.SetActive (false);
				yuwenzi1.SetActive (false);
				yuwenzi2.SetActive (false);
				shibai.SetActive (false);
				isshow=!isshow;
				if (isshow)
				{
					btn.GetComponent<Image>().sprite=expan ;
					yugan.transform.localEulerAngles = new Vector3 (65.0f, 0.0f, 0.0f); 
					yugan.transform.localPosition = new Vector3(3.0f,0.0f,-1f);
				}
				else {
					btn.GetComponent<Image>().sprite=back;
				}
			});
		
	}

	// Update is called once per frame
	void Update () {
		
	}
}