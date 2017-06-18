using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{

    public GameObject respawn;
    public bool flagCode = false;

    public AudioClip impact;
    public AudioClip impact2;
    public new AudioSource audio;
    private string x;
    float time;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {

        UnityEngine.Debug.Log(ToString());
        audio = respawn.GetComponent<AudioSource>();

        if (flagCode == false && this.gameObject.name.ToString() == "btn0")
        {
            x = this.gameObject.name.ToString();
            //time = System.DateTime.Now.Second;
            //audio.PlayOneShot(impact,1);
            //respawn.GetComponent<Animator>().Play("CINEMA_4D_Main1", 0);
            respawn.GetComponent<Animator>().PlayInFixedTime("CINEMA_4D_Main1", 0);
            audio.clip = impact;
            audio.Play();
            time = Time.time;
            flagCode = true;
            //UnityEngine.Debug.Log(time);
        }
        else if (flagCode == true && x == this.gameObject.name.ToString())
        {
            UnityEngine.Debug.Log(time);
            //   yield return new WaitForSeconds((float)0.5);//2- time%2);


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
