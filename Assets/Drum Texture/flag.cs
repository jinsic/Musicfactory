using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class flag : MonoBehaviour {
    public bool mel_flag;
    public bool base_flag;
    public bool code_flag;
    public string savebtn;
    public Stopwatch sw = new Stopwatch();
    // Use this for initialization
    void Start () {
        mel_flag = false;
        base_flag = false;
        code_flag = false;
}
	
	// Update is called once per frame
	void Update () {
		
	}
}
