using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour {
    
    public GameObject respawn;
    public bool flagCode = false;

    public AudioClip impact;
    public AudioClip impact2;
    public new AudioSource audio;
    float time;
    float timecheck = 0.01f;
    void Start()
    {
        //UnityEngine.Debug.Log(impact.ToString());
        //UnityEngine.Debug.Log(impact2.ToString());

    }

    // Update is called once per frame
    void Update () {

    }

    IEnumerator OnMouseDown()
    {
       
        UnityEngine.Debug.Log(ToString());
        audio = respawn.GetComponent<AudioSource>();

        if (flagCode == false)//&& ToString() == "btn0")
        {
            //time = System.DateTime.Now.Second;
            //audio.PlayOneShot(impact,1);
            //respawn.GetComponent<Animator>().Play("CINEMA_4D_Main1", 0);
            respawn.GetComponent<Animator>().PlayInFixedTime("CINEMA_4D_Main1",0);
            audio.clip = impact;
            audio.Play();
            time = Time.time;
            flagCode = true;
            //UnityEngine.Debug.Log(time);
        }
        else
        {
            UnityEngine.Debug.Log(time);
            yield return new WaitForSeconds((float)0.5);//2- time%2);

                
            respawn.GetComponent<Animator>().Play("New State", 0);
            audio.Stop();
            flagCode = false;
            UnityEngine.Debug.Log(flagCode);
            time = 0;
           
        }
        //respawn.GetComponent<Animator>().PlayInFixedTime("CINEMA_4D_Main1", 0);
        //  if (respawn == null)
        // respawn = GameObject.FindWithTag("Melody_Tag");
        // Debug.Log(respawn.ToString());
    }
}
