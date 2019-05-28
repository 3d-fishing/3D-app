using UnityEngine;
using System.Collections;
using Game_Manager;

namespace Game_Manager {

	public class Game_Scene_Manager : System.Object {
		private static Game_Scene_Manager _instance;
		private static Mouse_Image _Mouse;
		private int IsHair = 0; // 是否头部有装备
		private int IsWeapon = 0; // 是否有武器装备
		private int IsFoot = 0; // 是否有脚部装备

		public static Game_Scene_Manager GetInstance() {
			if (_instance == null) {
				_instance = new Game_Scene_Manager();
			}
			return _instance;
		}

		public void SetMouse(Mouse_Image _mouse) {
			if (_Mouse == null) {
				_Mouse = _mouse;
			}
		}

		public Mouse_Image GetMouse() {
			return _Mouse;
		}

		public void GenAll() {
			IsFoot = 1;
			IsHair = 1;
			IsWeapon = 1;
		}

		public int GetHair() { return IsHair; }
		public int GetWeapon() { return IsWeapon; }
		public int GetFoot() { return IsFoot; }

		public void SetHair(int a) { IsHair = a; }
		public void SetWeapon(int a) { IsWeapon = a; }
		public void SetFoot(int a) { IsFoot = a; }
	}

}

public class Mouse : MonoBehaviour {
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
}
