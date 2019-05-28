using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class 出现杆 : MonoBehaviour {
	
	public GameObject btnObj ;
	public GameObject caidan1;
	public GameObject caidan2;
	public GameObject yugan;
	public Sprite   expan;
	public Sprite  back;
	Button btn;
	bool isshow=false ;

	// Use this for initialization
	void Start () {
		caidan1.SetActive (isshow);
		caidan2.SetActive (isshow);
		yugan.SetActive (isshow);
		btn = btnObj.GetComponent<Button>();
		btn.onClick.AddListener(delegate ()
			{
				isshow=!isshow;
				caidan1.SetActive (isshow);
				caidan2.SetActive (isshow);
				yugan.SetActive(isshow);
				if (isshow)
				{
					btn.GetComponent<Image>().sprite=expan ;
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
