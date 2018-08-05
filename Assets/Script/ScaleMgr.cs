using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleMgr : MonoBehaviour {
	public GameObject ObjekRectangle;
	public GameObject ObjekCube;
	public GameObject ObjekHouse;

	public GameObject UIButtonZ;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (ObjekRectangle.activeInHierarchy || ObjekHouse.activeInHierarchy) {
			UIButtonZ.SetActive (false);
		} else {
			UIButtonZ.SetActive (true);
		}
		
	}

	public void ScaleXObjectRight()
	{
		//Objek.transform.Translate(Vector3.right * Time.deltaTime);
		ObjekRectangle.transform.localScale = new Vector3(ObjekRectangle.transform.localScale.x + 0.10f, ObjekRectangle.transform.localScale.y, ObjekRectangle.transform.localScale.z);
		ObjekRectangle.transform.position = new Vector3(ObjekRectangle.transform.position.x + 10f, ObjekRectangle.transform.position.y, ObjekRectangle.transform.position.z);

		ObjekCube.transform.localScale = new Vector3(ObjekCube.transform.localScale.x + 0.10f, ObjekCube.transform.localScale.y, ObjekCube.transform.localScale.z);
		ObjekHouse.transform.localScale = new Vector3(ObjekHouse.transform.localScale.x, ObjekHouse.transform.localScale.y, ObjekHouse.transform.localScale.z + 0.10f);
	}

	public void ScaleXObjectLeft()
	{
		//Objek.transform.Translate(Vector3.right * Time.deltaTime);
		ObjekRectangle.transform.localScale = new Vector3(ObjekRectangle.transform.localScale.x - 0.10f, ObjekRectangle.transform.localScale.y, ObjekRectangle.transform.localScale.z);
		ObjekRectangle.transform.position = new Vector3(ObjekRectangle.transform.position.x - 10f, ObjekRectangle.transform.position.y, ObjekRectangle.transform.position.z);

		ObjekCube.transform.localScale = new Vector3(ObjekCube.transform.localScale.x - 0.10f, ObjekCube.transform.localScale.y, ObjekCube.transform.localScale.z);
		ObjekHouse.transform.localScale = new Vector3(ObjekHouse.transform.localScale.x, ObjekHouse.transform.localScale.y, ObjekHouse.transform.localScale.z - 0.10f);
	}

	public void ScaleYObjectUp()
	{
		//Objek.transform.Translate(Vector3.right * Time.deltaTime);
		ObjekRectangle.transform.localScale = new Vector3(ObjekRectangle.transform.localScale.x, ObjekRectangle.transform.localScale.y + 0.10f, ObjekRectangle.transform.localScale.z);
		ObjekCube.transform.localScale = new Vector3(ObjekCube.transform.localScale.x, ObjekCube.transform.localScale.y + 0.10f, ObjekCube.transform.localScale.z);
		ObjekHouse.transform.localScale = new Vector3(ObjekHouse.transform.localScale.x + 0.10f, ObjekHouse.transform.localScale.y, ObjekHouse.transform.localScale.z);
	}

	public void ScaleYObjectDown()
	{
		//Objek.transform.Translate(Vector3.right * Time.deltaTime);
		ObjekRectangle.transform.localScale = new Vector3(ObjekRectangle.transform.localScale.x, ObjekRectangle.transform.localScale.y - 0.10f, ObjekRectangle.transform.localScale.z);
		ObjekCube.transform.localScale = new Vector3(ObjekCube.transform.localScale.x, ObjekCube.transform.localScale.y - 0.10f, ObjekCube.transform.localScale.z);
		ObjekHouse.transform.localScale = new Vector3(ObjekHouse.transform.localScale.x - 0.10f, ObjekHouse.transform.localScale.y, ObjekHouse.transform.localScale.z);
	}

	public void ScaleZObjectUp()
	{
		//Objek.transform.Translate(Vector3.right * Time.deltaTime);
		ObjekRectangle.transform.localScale = new Vector3(ObjekRectangle.transform.localScale.x, ObjekRectangle.transform.localScale.y, ObjekRectangle.transform.localScale.z + 0.10f);
		ObjekCube.transform.localScale = new Vector3(ObjekCube.transform.localScale.x, ObjekCube.transform.localScale.y, ObjekCube.transform.localScale.z + 0.10f);
		ObjekHouse.transform.localScale = new Vector3(ObjekHouse.transform.localScale.x, ObjekHouse.transform.localScale.y, ObjekHouse.transform.localScale.z + 0.10f);
	}

	public void ScaleZObjectDown()
	{
		//Objek.transform.Translate(Vector3.right * Time.deltaTime);
		ObjekRectangle.transform.localScale = new Vector3(ObjekRectangle.transform.localScale.x, ObjekRectangle.transform.localScale.y, ObjekRectangle.transform.localScale.z - 0.10f);
		ObjekCube.transform.localScale = new Vector3(ObjekCube.transform.localScale.x, ObjekCube.transform.localScale.y, ObjekCube.transform.localScale.z - 0.10f);
		ObjekHouse.transform.localScale = new Vector3(ObjekHouse.transform.localScale.x, ObjekHouse.transform.localScale.y, ObjekHouse.transform.localScale.z - 0.10f);
	}
}
