using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {
	public GameObject MainCanvas;
	public GameObject canvasTranslation;
	public GameObject canvasRotation;
	public GameObject canvasScaling;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OpenTranslation()
	{
		MainCanvas.SetActive (false);
		canvasTranslation.SetActive (true);
	}

	public void OpenRotation()
	{
		MainCanvas.SetActive (false);
		canvasRotation.SetActive (true);
	}

	public void OpenScaling()
	{
		MainCanvas.SetActive (false);
		canvasScaling.SetActive (true);
	}

	public void BacktoMainCanvas()
	{
		MainCanvas.SetActive (true);

		canvasTranslation.SetActive (false);
		canvasRotation.SetActive (false);
		canvasScaling.SetActive (false);
	}

}
