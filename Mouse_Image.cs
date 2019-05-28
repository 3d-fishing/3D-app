using UnityEngine;
using System.Collections;
using Game_Manager;
using UnityEngine.UI;

public class Mouse_Image : MonoBehaviour {

	private Game_Scene_Manager gsm;
	private Image mouse_image;
	private int mouse_type = 0;
	public Sprite none;
	public Sprite hair; // 保存相应的装备
	public Sprite weapon; // 保存相应的装备
	public Sprite foot; // 保存相应的装备
	public Color None;
	public Color NotNone;
	public Camera cam;

	void Awake() {
		gsm = Game_Scene_Manager.GetInstance();
		gsm.SetMouse(this);
		mouse_image = GetComponent<Image>();
	}

	public int GetMouseType() {
		return mouse_type;
	}

	public void SetMouseType(int Mouse_type) {
		mouse_type = Mouse_type;
	}

	void Update () {
		if (mouse_type == 0) // 每一帧进行更新，检查鼠标上是否需要有装备，根据mousetype更新，如果mousetype为0则装备无
		{
			mouse_image.sprite = none;
			mouse_image.color = None;
		}
		else
		{ // mousetype不为零，根据mousetype加上相应装备
			//Debug.Log("I am mouse image");
			//Debug.Log(mouse_type);

			mouse_image.color = new Color(1F, 1F, 1F, 1F);
			//Debug.Log(mouse_image.color);
			if (mouse_type == 1) mouse_image.sprite = hair;
			else if (mouse_type == 2) mouse_image.sprite = weapon;
			else if (mouse_type == 3) mouse_image.sprite = foot;
		}
		transform.position = new Vector3 (Input.mousePosition.x-600, Input.mousePosition.y-230, 0);
	}
}