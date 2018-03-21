using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using UnityEngine.UI;

public class AipTapDetect : MonoBehaviour, IInputClickHandler {
    public string first;
    public string second;

    [SerializeField] private bool isFirst;
    private Text textData;


    // Use this for initialization
    void Start () {
        isFirst = true;
        textData = gameObject.GetComponentInChildren<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnInputClicked(InputClickedEventData eventData)
    {
        isFirst = !isFirst;
        textData.text = (isFirst) ? first : second;
    }
}
