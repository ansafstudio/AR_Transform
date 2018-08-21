using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

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
		
		//if (ObjekRectangle.activeInHierarchy || ObjekHouse.activeInHierarchy) {
		if (DefaultTrackableEventHandler.rectangleActive || DefaultTrackableEventHandler.houseActive) {
			UIButtonZ.SetActive (false);
		} else {
			UIButtonZ.SetActive (true);
		}
		
	}

	public void ScaleXObjectRight()
	{
		//Objek.transform.Translate(Vector3.right * Time.deltaTime);
		ObjekRectangle.transform.localScale = new Vector3(ObjekRectangle.transform.localScale.x + 0.15f, ObjekRectangle.transform.localScale.y, ObjekRectangle.transform.localScale.z);
		//ObjekRectangle.transform.position = new Vector3(ObjekRectangle.transform.position.x + 15f, ObjekRectangle.transform.position.y, ObjekRectangle.transform.position.z);

		ObjekCube.transform.localScale = new Vector3(ObjekCube.transform.localScale.x + 0.15f, ObjekCube.transform.localScale.y, ObjekCube.transform.localScale.z);
		//ObjekCube.transform.position = new Vector3(ObjekCube.transform.position.x + 15f, ObjekCube.transform.position.y, ObjekCube.transform.position.z);

		ObjekHouse.transform.localScale = new Vector3(ObjekHouse.transform.localScale.x + 1.0f, ObjekHouse.transform.localScale.y, ObjekHouse.transform.localScale.z/* + 0.13f*/);
		//ObjekHouse.transform.position = new Vector3(ObjekHouse.transform.position.x + 14f, ObjekHouse.transform.position.y, ObjekHouse.transform.position.z);
	}

	public void ScaleXObjectLeft()
	{
		//Objek.transform.Translate(Vector3.right * Time.deltaTime);
		ObjekRectangle.transform.localScale = new Vector3(ObjekRectangle.transform.localScale.x - 0.15f, ObjekRectangle.transform.localScale.y, ObjekRectangle.transform.localScale.z);
		//ObjekRectangle.transform.position = new Vector3(ObjekRectangle.transform.position.x - 15f, ObjekRectangle.transform.position.y, ObjekRectangle.transform.position.z);

		ObjekCube.transform.localScale = new Vector3(ObjekCube.transform.localScale.x - 0.15f, ObjekCube.transform.localScale.y, ObjekCube.transform.localScale.z);
		//ObjekCube.transform.position = new Vector3(ObjekCube.transform.position.x - 15f, ObjekCube.transform.position.y, ObjekCube.transform.position.z);

		ObjekHouse.transform.localScale = new Vector3(ObjekHouse.transform.localScale.x - 1.0f, ObjekHouse.transform.localScale.y, ObjekHouse.transform.localScale.z/* - 0.13f*/);
		//ObjekHouse.transform.position = new Vector3(ObjekHouse.transform.position.x - 14f, ObjekHouse.transform.position.y, ObjekHouse.transform.position.z);
	}

	public void ScaleYObjectUp()
	{
		//Objek.transform.Translate(Vector3.right * Time.deltaTime);
		ObjekRectangle.transform.localScale = new Vector3(ObjekRectangle.transform.localScale.x, ObjekRectangle.transform.localScale.y + 0.15f, ObjekRectangle.transform.localScale.z);
		//ObjekRectangle.transform.position = new Vector3(ObjekRectangle.transform.position.x, ObjekRectangle.transform.position.y + 15f, ObjekRectangle.transform.position.z);

		ObjekCube.transform.localScale = new Vector3(ObjekCube.transform.localScale.x, ObjekCube.transform.localScale.y + 0.15f, ObjekCube.transform.localScale.z);
		//ObjekCube.transform.position = new Vector3(ObjekCube.transform.position.x, ObjekCube.transform.position.y + 15f, ObjekCube.transform.position.z);

		ObjekHouse.transform.localScale = new Vector3(ObjekHouse.transform.localScale.x/* + 0.07f*/, ObjekHouse.transform.localScale.y + 0.5f, ObjekHouse.transform.localScale.z);
		//ObjekHouse.transform.position = new Vector3(ObjekHouse.transform.position.x, ObjekHouse.transform.position.y + 22f, ObjekHouse.transform.position.z);
	}

	public void ScaleYObjectDown()
	{
		//Objek.transform.Translate(Vector3.right * Time.deltaTime);
		ObjekRectangle.transform.localScale = new Vector3(ObjekRectangle.transform.localScale.x, ObjekRectangle.transform.localScale.y - 0.15f, ObjekRectangle.transform.localScale.z);
		//ObjekRectangle.transform.position = new Vector3(ObjekRectangle.transform.position.x, ObjekRectangle.transform.position.y - 15f, ObjekRectangle.transform.position.z);

		ObjekCube.transform.localScale = new Vector3(ObjekCube.transform.localScale.x, ObjekCube.transform.localScale.y - 0.15f, ObjekCube.transform.localScale.z);
		//ObjekCube.transform.position = new Vector3(ObjekCube.transform.position.x, ObjekCube.transform.position.y - 15f, ObjekCube.transform.position.z);

		ObjekHouse.transform.localScale = new Vector3(ObjekHouse.transform.localScale.x/* - 0.07f*/, ObjekHouse.transform.localScale.y - 0.5f, ObjekHouse.transform.localScale.z);
		//ObjekHouse.transform.position = new Vector3(ObjekHouse.transform.position.x, ObjekHouse.transform.position.y - 22f, ObjekHouse.transform.position.z);
	}

	public void ScaleZObjectUp()
	{
		//Objek.transform.Translate(Vector3.right * Time.deltaTime);
		ObjekRectangle.transform.localScale = new Vector3(ObjekRectangle.transform.localScale.x, ObjekRectangle.transform.localScale.y, ObjekRectangle.transform.localScale.z + 0.10f);

		ObjekCube.transform.localScale = new Vector3(ObjekCube.transform.localScale.x, ObjekCube.transform.localScale.y, ObjekCube.transform.localScale.z + 0.15f);
		//ObjekCube.transform.position = new Vector3(ObjekCube.transform.position.x, ObjekCube.transform.position.y, ObjekCube.transform.position.z + 15f);

		ObjekHouse.transform.localScale = new Vector3(ObjekHouse.transform.localScale.x, ObjekHouse.transform.localScale.y, ObjekHouse.transform.localScale.z + 0.10f);
	}

	public void ScaleZObjectDown()
	{
		//Objek.transform.Translate(Vector3.right * Time.deltaTime);
		ObjekRectangle.transform.localScale = new Vector3(ObjekRectangle.transform.localScale.x, ObjekRectangle.transform.localScale.y, ObjekRectangle.transform.localScale.z - 0.10f);

		ObjekCube.transform.localScale = new Vector3(ObjekCube.transform.localScale.x, ObjekCube.transform.localScale.y, ObjekCube.transform.localScale.z - 0.15f);
		//ObjekCube.transform.position = new Vector3(ObjekCube.transform.position.x, ObjekCube.transform.position.y, ObjekCube.transform.position.z - 15f);

		ObjekHouse.transform.localScale = new Vector3(ObjekHouse.transform.localScale.x, ObjekHouse.transform.localScale.y, ObjekHouse.transform.localScale.z - 0.10f);
	}
}
