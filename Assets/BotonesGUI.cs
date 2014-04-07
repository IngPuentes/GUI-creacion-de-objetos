using UnityEngine;
using System.Collections;

public class BotonesGUI : MonoBehaviour {
	int pos =0;
	int pos1=0;
	int pos2=0;

	float r = 0.0f;
	float g = 0.0f;
	float b = 0.0f;
	GameObject cube1;
	GameObject esfera1;
	GameObject capsula1;
	public GUISkin customSkin;
	void OnGUI () {
		GUI.skin = customSkin;
		GUI.Label (new Rect (260, 80, 100, 100), "ROJO");
		GUI.Label (new Rect (260, 100, 100, 100), "VERDE");
		GUI.Label (new Rect (260, 120, 100, 100), "AZUL");

		r = GUI.HorizontalSlider (new Rect (0,90,250,30),r, 0.0f, 1.0f);
		g = GUI.HorizontalSlider (new Rect (0,120,250,30),g, 0.0f, 1.0f);
		b = GUI.HorizontalSlider (new Rect (0,150,250,30),b, 0.0f, 1.0f);

		if (GUI.Button (new Rect (0,0,100,30), "Crear Cubo")) {
			pos +=3;
			cube1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
			cube1.transform.position = new Vector3(0, 0, pos);
			cube1.transform.localScale = new Vector3 (2,2,2);
			cube1.transform.rotation = Quaternion.Euler (0,0,0);
			cube1.renderer.material.color=new Color(r,g,b,250f);


		}
		if (GUI.Button (new Rect (0,35,100,30), "Crear esfera")) {
			pos1 +=3;
			esfera1 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
			esfera1.transform.position = new Vector3(3, 0, pos1);
			esfera1.transform.localScale = new Vector3 (2,2,2);
			esfera1.transform.rotation = Quaternion.Euler (0,0,0);
			esfera1.renderer.material.color=new Color(r,g,b);
		}
		if (GUI.Button (new Rect (110,0,100,30), "Crear Capsula")) {
			pos2+=3;
			capsula1 = GameObject.CreatePrimitive(PrimitiveType.Capsule);
			capsula1.transform.position = new Vector3(6, 0, pos2);
			capsula1.transform.localScale = new Vector3 (2,2,2);
			capsula1.transform.rotation = Quaternion.Euler (0,0,0);
			capsula1.renderer.material.color=new Color(r,g,b);
		}
	}
	void Update(){
		cube1.renderer.material.color=new Color(r,g,b);
		esfera1.renderer.material.color=new Color(r,g,b);
		capsula1.renderer.material.color=new Color(r,g,b);
		}
}