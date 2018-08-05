using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMgr : MonoBehaviour {
    public GameObject canvasMain;
    public GameObject canvasTranslation;

    //Translation
    public GameObject ObjekRectangle;
    public GameObject ObjekCube;
	public GameObject ObjekHouse;

    //public GameObject buttonXYZtrans;
    //public GameObject buttonXtrans;
    //public GameObject buttonYtrans;
    //public GameObject buttonZtrans;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OpenTranslation()
    {
        canvasMain.SetActive(false);
        canvasTranslation.SetActive(true);
    }

    //// Translation
    //public void TransX()
    //{
    //    buttonXYZtrans.SetActive(false);
    //    buttonXtrans.SetActive(true);
    //}

    public void TranslateXObjectRight()
    {
        //Objek.transform.Translate(Vector3.right * Time.deltaTime);
        ObjekRectangle.transform.position = new Vector3(ObjekRectangle.transform.position.x + 30f, ObjekRectangle.transform.position.y, ObjekRectangle.transform.position.z);
        ObjekCube.transform.position = new Vector3(ObjekCube.transform.position.x + 30f, ObjekCube.transform.position.y, ObjekCube.transform.position.z);
		ObjekHouse.transform.position = new Vector3(ObjekHouse.transform.position.x + 30f, ObjekHouse.transform.position.y, ObjekHouse.transform.position.z);
    }

    public void TranslateXObjectLeft()
    {
        //Objek.transform.Translate(Vector3.right * Time.deltaTime);
        ObjekRectangle.transform.position = new Vector3(ObjekRectangle.transform.position.x - 30f, ObjekRectangle.transform.position.y, ObjekRectangle.transform.position.z);
        ObjekCube.transform.position = new Vector3(ObjekCube.transform.position.x - 30f, ObjekCube.transform.position.y, ObjekCube.transform.position.z);
		ObjekHouse.transform.position = new Vector3(ObjekHouse.transform.position.x - 30f, ObjekHouse.transform.position.y, ObjekHouse.transform.position.z);
    }

    public void TranslateYObjectUp()
    {
        //Objek.transform.Translate(Vector3.right * Time.deltaTime);
        ObjekRectangle.transform.position = new Vector3(ObjekRectangle.transform.position.x, ObjekRectangle.transform.position.y + 30f, ObjekRectangle.transform.position.z);
        ObjekCube.transform.position = new Vector3(ObjekCube.transform.position.x, ObjekCube.transform.position.y + 30f, ObjekCube.transform.position.z);
		ObjekHouse.transform.position = new Vector3(ObjekHouse.transform.position.x, ObjekHouse.transform.position.y + 30f, ObjekHouse.transform.position.z);
    }

    public void TranslateYObjectDown()
    {
        //Objek.transform.Translate(Vector3.right * Time.deltaTime);
        ObjekRectangle.transform.position = new Vector3(ObjekRectangle.transform.position.x, ObjekRectangle.transform.position.y - 30f, ObjekRectangle.transform.position.z);
        ObjekCube.transform.position = new Vector3(ObjekCube.transform.position.x, ObjekCube.transform.position.y - 30f, ObjekCube.transform.position.z);
		ObjekHouse.transform.position = new Vector3(ObjekHouse.transform.position.x, ObjekHouse.transform.position.y - 30f, ObjekHouse.transform.position.z);
    }

    public void TranslateZObjectUp()
    {
        //Objek.transform.Translate(Vector3.right * Time.deltaTime);
        ObjekRectangle.transform.position = new Vector3(ObjekRectangle.transform.position.x, ObjekRectangle.transform.position.y, ObjekRectangle.transform.position.z + 30f);
        ObjekCube.transform.position = new Vector3(ObjekCube.transform.position.x, ObjekCube.transform.position.y, ObjekCube.transform.position.z + 30f);
		ObjekHouse.transform.position = new Vector3(ObjekHouse.transform.position.x, ObjekHouse.transform.position.y, ObjekHouse.transform.position.z + 30f);
    }

    public void TranslateZObjectDown()
    {
        //Objek.transform.Translate(Vector3.right * Time.deltaTime);
        ObjekRectangle.transform.position = new Vector3(ObjekRectangle.transform.position.x, ObjekRectangle.transform.position.y, ObjekRectangle.transform.position.z - 30f);
        ObjekCube.transform.position = new Vector3(ObjekCube.transform.position.x, ObjekCube.transform.position.y, ObjekCube.transform.position.z - 30f);
		ObjekHouse.transform.position = new Vector3(ObjekHouse.transform.position.x, ObjekHouse.transform.position.y, ObjekHouse.transform.position.z - 30f);
    }
}
