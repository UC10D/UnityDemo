using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Btn : MonoBehaviour {

    private Button btn;

    
	// Use this for initialization
	void Start () {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(TestOnClick);
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    void TestOnClick() {

        print("11111111111111111111111111111111111111");




    
    }
}
