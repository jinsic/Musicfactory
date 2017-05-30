using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class mel_sc : MonoBehaviour
{

    public GameObject respawn;
    public bool flagCode = false;

    public AudioClip impact;
    public AudioClip impact2;
    public new AudioSource audio;
    float time;
    Stopwatch sw = new Stopwatch();

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }



    IEnumerator OnMouseDown()
    {

        //        UnityEngine.Debug.Log(ToString());
        audio = respawn.GetComponent<AudioSource>();

        if (flagCode == false)
        {
            sw.Start();

            time = System.DateTime.Now.Second;
            //audio.PlayOneShot(impact,1);
            //respawn.GetComponent<Animator>().Play("CINEMA_4D_Main1", 0);
            respawn.GetComponent<Animator>().PlayInFixedTime("mel_mo 0", 0);
            audio.clip = impact;
            audio.Play();

            flagCode = true;
            //UnityEngine.Debug.Log(time);
        }
        else
        {
            sw.Stop();
            UnityEngine.Debug.Log(sw.ElapsedMilliseconds.ToString() + "ms");
            UnityEngine.Debug.Log((float)(2000 - sw.ElapsedMilliseconds % 2000) / 1000);
            yield return new WaitForSeconds((float)(2000-sw.ElapsedMilliseconds%2000)/1000);
            sw.Reset();
            //respawn.GetComponent<Animator>().StopPlayback();

            audio.Stop();
            respawn.GetComponent<Animator>().PlayInFixedTime("Main", 0);
            audio.clip = impact2;
            audio.Play();
            respawn.GetComponent<Animator>().PlayInFixedTime("Main 0", 0);
            //     audio.Stop();
            flagCode = false;
            //   UnityEngine.Debug.Log(flagCode);


        }
        //respawn.GetComponent<Animator>().PlayInFixedTime("CINEMA_4D_Main1", 0);
        //  if (respawn == null)
        // respawn = GameObject.FindWithTag("Melody_Tag");
        // Debug.Log(respawn.ToString());
    }
}
