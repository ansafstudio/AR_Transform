using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationMgr : MonoBehaviour {
	public GameObject ObjekRectangle;
    public GameObject ObjekCube;
	public GameObject ObjekHouse;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void RotateXObjectRight()
    {
        //Objek.transform.Translate(Vector3.right * Time.deltaTime);
		ObjekRectangle.transform.eulerAngles = new Vector3(ObjekRectangle.transform.eulerAngles.x, ObjekRectangle.transform.eulerAngles.y - 15f, ObjekRectangle.transform.eulerAngles.z);
		ObjekCube.transform.eulerAngles = new Vector3(ObjekCube.transform.eulerAngles.x, ObjekCube.transform.eulerAngles.y - 15f, ObjekCube.transform.eulerAngles.z);
		ObjekHouse.transform.eulerAngles = new Vector3(ObjekHouse.transform.eulerAngles.x, ObjekHouse.transform.eulerAngles.y - 15f, ObjekHouse.transform.eulerAngles.z);
    }

	public void RotateXObjectLeft()
	{
		//Objek.transform.Translate(Vector3.right * Time.deltaTime);
		ObjekRectangle.transform.eulerAngles = new Vector3(ObjekRectangle.transform.eulerAngles.x, ObjekRectangle.transform.eulerAngles.y + 15f, ObjekRectangle.transform.eulerAngles.z);
		ObjekCube.transform.eulerAngles = new Vector3(ObjekCube.transform.eulerAngles.x, ObjekCube.transform.eulerAngles.y + 15f, ObjekCube.transform.eulerAngles.z);
		ObjekHouse.transform.eulerAngles = new Vector3(ObjekHouse.transform.eulerAngles.x, ObjekHouse.transform.eulerAngles.y + 15f, ObjekHouse.transform.eulerAngles.z);
	}

	public void RotateYObjectUp()
	{
		//Objek.transform.Translate(Vector3.right * Time.deltaTime);
		ObjekRectangle.transform.eulerAngles = new Vector3(ObjekRectangle.transform.eulerAngles.x + 15f, ObjekRectangle.transform.eulerAngles.y, ObjekRectangle.transform.eulerAngles.z);
		ObjekCube.transform.eulerAngles = new Vector3(ObjekCube.transform.eulerAngles.x + 15f, ObjekCube.transform.eulerAngles.y, ObjekCube.transform.eulerAngles.z);
		ObjekHouse.transform.eulerAngles = new Vector3(ObjekHouse.transform.eulerAngles.x + 15f, ObjekHouse.transform.eulerAngles.y, ObjekHouse.transform.eulerAngles.z);
	}

	public void RotateYObjectDown()
	{
		//Objek.transform.Translate(Vector3.right * Time.deltaTime);
		ObjekRectangle.transform.eulerAngles = new Vector3(ObjekRectangle.transform.eulerAngles.x - 15f, ObjekRectangle.transform.eulerAngles.y, ObjekRectangle.transform.eulerAngles.z);
		ObjekCube.transform.eulerAngles = new Vector3(ObjekCube.transform.eulerAngles.x - 15f, ObjekCube.transform.eulerAngles.y, ObjekCube.transform.eulerAngles.z);
		ObjekHouse.transform.eulerAngles = new Vector3(ObjekHouse.transform.eulerAngles.x - 15f, ObjekHouse.transform.eulerAngles.y, ObjekHouse.transform.eulerAngles.z);
	}

	public void RotateZObjectUp()
	{
		//Objek.transform.Translate(Vector3.right * Time.deltaTime);
		ObjekRectangle.transform.eulerAngles = new Vector3(ObjekRectangle.transform.eulerAngles.x, ObjekRectangle.transform.eulerAngles.y, ObjekRectangle.transform.eulerAngles.z + 15f);
		ObjekCube.transform.eulerAngles = new Vector3(ObjekCube.transform.eulerAngles.x, ObjekCube.transform.eulerAngles.y, ObjekCube.transform.eulerAngles.z + 15f);
		ObjekHouse.transform.eulerAngles = new Vector3(ObjekHouse.transform.eulerAngles.x, ObjekHouse.transform.eulerAngles.y, ObjekHouse.transform.eulerAngles.z + 15f);
	}

	public void RotateZObjectDown()
	{
		//Objek.transform.Translate(Vector3.right * Time.deltaTime);
		ObjekRectangle.transform.eulerAngles = new Vector3(ObjekRectangle.transform.eulerAngles.x, ObjekRectangle.transform.eulerAngles.y, ObjekRectangle.transform.eulerAngles.z - 15f);
		ObjekCube.transform.eulerAngles = new Vector3(ObjekCube.transform.eulerAngles.x, ObjekCube.transform.eulerAngles.y, ObjekCube.transform.eulerAngles.z - 15f);
		ObjekHouse.transform.eulerAngles = new Vector3(ObjekHouse.transform.eulerAngles.x, ObjekHouse.transform.eulerAngles.y, ObjekHouse.transform.eulerAngles.z - 15f);
	}
}
