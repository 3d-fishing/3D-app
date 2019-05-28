using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class 长按 : MonoBehaviour 
{
	public float min;
	public float max;
	public GameObject yugan;
	private bool IsStart = false;
	private float LastTime = 0;

	public GameObject btnObj;
	public GameObject caidan;
	public GameObject caidan2;
	public Sprite   expan;
	public Sprite  back;
	Button btn;
	bool isshow=false ;

	void Start () {

		caidan.SetActive (isshow);
		caidan2.SetActive (isshow);
		btn = btnObj.GetComponent<Button>();
		btn.onClick.AddListener(delegate ()
			{
				isshow=!isshow;
				caidan.SetActive (isshow);
				caidan2.SetActive (isshow);
				if (isshow)
				{
					btn.GetComponent<Image>().sprite=expan ;
				}
				else {
					btn.GetComponent<Image>().sprite=back;
				}
			});
	}

	void Update () {
		
		if (IsStart && min > 0 && LastTime > 0 && Time.time - LastTime > min) {
			yugan.transform.localEulerAngles = new Vector3 (0.0f, 0.0f, 0.0f);
			yugan.transform.localPosition = new Vector3(3.3f,0.0f,5f);
			IsStart = false;
			LastTime = 0;
		} 
	}

	public void LongPress(bool bStart)
	{
		IsStart = bStart;
		if(IsStart)
		{
			LastTime = Time.time;
		}
		else if(LastTime != 0)
		{
			LastTime = 0;
		}    
	}

}
	