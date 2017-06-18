using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class durm_sc : MonoBehaviour
{
    public GameObject respawn;
    public GameObject test;

    public Material _on;
    public Material _off;
    public Material _on1;
    public Material _off1;
    public Material _on2;
    public Material _off2;
    private Material[] mats;

    [SerializeField]
    OculusHapticsController rightControllerHaptics;

    public AudioClip impact;
    public AudioClip impact2;
    public AudioClip impact3;
    public new AudioSource audio;
    public bool flagCode = false;

    public Transform aaaaa;
    private RaycastHit hit;
    GameObject x;

    // Use this for initialization
    void Start()
    {
        GameObject[] a = GameObject.FindGameObjectsWithTag("drumbtn");

        mats = a[0].GetComponent<Renderer>().materials;
        mats[0] = _off2;
        a[0].GetComponent<Renderer>().material = mats[0];

        mats = a[1].GetComponent<Renderer>().materials;
        mats[0] = _off;
        a[1].GetComponent<Renderer>().material = mats[0];

        mats = a[2].GetComponent<Renderer>().materials;
        mats[0] = _off1;
        a[2].GetComponent<Renderer>().material = mats[0];


        respawn.GetComponent<flag>().sw.Start();
        audio = respawn.GetComponent<AudioSource>();
        // aaaaa = GetComponent<Transform>();
        //  UnityEngine.Debug.Log(aaaaa.name.ToString());
    }

    // Update is called once per frame
    void Update()
    {

        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            // UnityEngine.Debug.Log("make magic stick bigger");
            UnityEngine.Debug.Log("gun");

            RaycastGun();
        }
    }
    void RaycastGun()
    {
        RaycastHit hit;
        if (Physics.Raycast(aaaaa.position, aaaaa.forward, out hit))
        {
            if (hit.collider.gameObject.tag.ToString() == "drumbtn")
            {

                //   Destroy(hit.collider.gameObject);

                //UnityEngine.Debug.Log(hit.collider.gameObject.name.ToString());
                // OnMouseDown1(
                rightControllerHaptics.Vibrate(OculusHapticsController.VibrationForce.Hard);
                x = hit.collider.gameObject;
                //UnityEngine.Debug.Log(respawn.GetComponent<flag>().mel_flag);
                UnityEngine.Debug.Log(x.name.ToString());
                StartCoroutine(ButtonPress());

            }
        }

    }



    IEnumerator ButtonPress()
    {
        UnityEngine.Debug.Log(this.gameObject.name.ToString());
        if (respawn.GetComponent<flag>().mel_flag == false && x.name.ToString() == "btn0")//0으로 시작
        {

            yield return new WaitForSeconds((float)(2000 - test.GetComponent<flag>().sw.ElapsedMilliseconds % 2000) / 1000);
            // btnevent.GetComponent<Animator>().Play("CINEMA_4D_Main 5",0);

            UnityEngine.Debug.Log(this.gameObject.name.ToString());
            respawn.GetComponent<flag>().savebtn = x.name.ToString();

            respawn.GetComponent<Animator>().Play("Main 0", 0);
            //..GetComponent<Animation>().P
            audio.clip = impact;
            audio.loop = true;
            audio.Play();

            GameObject[] a = GameObject.FindGameObjectsWithTag("drumbtn");

            mats = a[0].GetComponent<Renderer>().materials;
            mats[0] = _off2;
            a[0].GetComponent<Renderer>().material = mats[0];

            mats = a[1].GetComponent<Renderer>().materials;
            mats[0] = _off;
            a[1].GetComponent<Renderer>().material = mats[0];

            mats = a[2].GetComponent<Renderer>().materials;
            mats[0] = _off1;
            a[2].GetComponent<Renderer>().material = mats[0];

            mats = x.GetComponent<Renderer>().materials;
            mats[0] = _on;
            x.GetComponent<Renderer>().material = mats[0];

            respawn.GetComponent<flag>().mel_flag = true;
            //UnityEngine.Debug.Log(time);
        }
        else if (respawn.GetComponent<flag>().mel_flag == false && x.name.ToString() == "btn1")//1로 시작
        {

            yield return new WaitForSeconds((float)(2000 - test.GetComponent<flag>().sw.ElapsedMilliseconds % 2000) / 1000);
            // btnevent.GetComponent<Animator>().Play("CINEMA_4D_Main 2", 0);
            UnityEngine.Debug.Log(this.gameObject.name.ToString());
            respawn.GetComponent<flag>().savebtn = x.name.ToString();
            //sw.Start();

            respawn.GetComponent<Animator>().Play("Main 1", 0);
            audio.clip = impact2;
            audio.loop = true;
            audio.Play();

            GameObject[] a = GameObject.FindGameObjectsWithTag("drumbtn");

            mats = a[0].GetComponent<Renderer>().materials;
            mats[0] = _off2;
            a[0].GetComponent<Renderer>().material = mats[0];

            mats = a[1].GetComponent<Renderer>().materials;
            mats[0] = _off;
            a[1].GetComponent<Renderer>().material = mats[0];

            mats = a[2].GetComponent<Renderer>().materials;
            mats[0] = _off1;
            a[2].GetComponent<Renderer>().material = mats[0];

            mats = x.GetComponent<Renderer>().materials;
            mats[0] = _on1;
            x.GetComponent<Renderer>().material = mats[0];

            respawn.GetComponent<flag>().mel_flag = true;

        }

        else if (respawn.GetComponent<flag>().mel_flag == false && x.name.ToString() == "btn2")//2로 시작
        {

            yield return new WaitForSeconds((float)(2000 - test.GetComponent<flag>().sw.ElapsedMilliseconds % 2000) / 1000);
            // btnevent.GetComponent<Animator>().Play("CINEMA_4D_Main 2", 0);
            UnityEngine.Debug.Log(this.gameObject.name.ToString());
            respawn.GetComponent<flag>().savebtn = x.name.ToString();
            //sw.Start();

            respawn.GetComponent<Animator>().Play("Main 2", 0);
            audio.clip = impact3;
            audio.loop = true;
            audio.Play();

            GameObject[] a = GameObject.FindGameObjectsWithTag("drumbtn");

            mats = a[0].GetComponent<Renderer>().materials;
            mats[0] = _off2;
            a[0].GetComponent<Renderer>().material = mats[0];

            mats = a[1].GetComponent<Renderer>().materials;
            mats[0] = _off;
            a[1].GetComponent<Renderer>().material = mats[0];

            mats = a[2].GetComponent<Renderer>().materials;
            mats[0] = _off1;
            a[2].GetComponent<Renderer>().material = mats[0];

            mats = x.GetComponent<Renderer>().materials;
            mats[0] = _on2;
            x.GetComponent<Renderer>().material = mats[0];

            respawn.GetComponent<flag>().mel_flag = true;

        }
        else if (respawn.GetComponent<flag>().mel_flag == true && respawn.GetComponent<flag>().savebtn == x.name.ToString())
        {
            //sw.Stop();
            UnityEngine.Debug.Log("stop");
            //UnityEngine.Debug.Log(sw.ElapsedMilliseconds.ToString() + "ms");
            // UnityEngine.Debug.Log((float)(2000 - sw.ElapsedMilliseconds % 2000) / 1000);
            yield return new WaitForSeconds((float)(2000 - test.GetComponent<flag>().sw.ElapsedMilliseconds % 2000) / 1000);
            //sw.Reset();

            audio.loop = false;
            audio.Stop();

            GameObject[] a = GameObject.FindGameObjectsWithTag("drumbtn");

            mats = a[0].GetComponent<Renderer>().materials;
            mats[0] = _off2;
            a[0].GetComponent<Renderer>().material = mats[0];

            mats = a[1].GetComponent<Renderer>().materials;
            mats[0] = _off;
            a[1].GetComponent<Renderer>().material = mats[0];

            mats = a[2].GetComponent<Renderer>().materials;
            mats[0] = _off1;
            a[2].GetComponent<Renderer>().material = mats[0];

            respawn.GetComponent<Animator>().Play("Main", 0);

            respawn.GetComponent<flag>().mel_flag = false;

            respawn.GetComponent<flag>().savebtn = x.name.ToString();
        }

        else if ((respawn.GetComponent<flag>().mel_flag == true) && (x.name.ToString() == "btn0"))//&& savebtn != this.gameObject.name.ToString())//다른버튼 -> 0
        {

            // btnevent.GetComponent<Animator>().Play("CINEMA_4D_Main 1", 0);
            UnityEngine.Debug.Log(this.gameObject.name.ToString());
            //sw.Stop();
            // UnityEngine.Debug.Log(sw.ElapsedMilliseconds.ToString() + "ms");
            // UnityEngine.Debug.Log((float)(2000 - sw.ElapsedMilliseconds % 2000) / 1000);
            yield return new WaitForSeconds((float)(2000 - test.GetComponent<flag>().sw.ElapsedMilliseconds % 2000) / 1000);


            //if (respawn.GetComponent<flag>().savebtn == x.name.ToString())
            //{
            //    audio.Stop();
            //    respawn.GetComponent<Animator>().Play("Main", 0);
            //    respawn.GetComponent<flag>().mel_flag = false;
            //}
            //else
            //{

            //  btnevent.GetComponent<Animator>().Play("CINEMA_4D_Main 2", 0);
            audio.Stop();

            GameObject[] a = GameObject.FindGameObjectsWithTag("drumbtn");

            mats = a[0].GetComponent<Renderer>().materials;
            mats[0] = _off2;
            a[0].GetComponent<Renderer>().material = mats[0];

            mats = a[1].GetComponent<Renderer>().materials;
            mats[0] = _off;
            a[1].GetComponent<Renderer>().material = mats[0];

            mats = a[2].GetComponent<Renderer>().materials;
            mats[0] = _off1;
            a[2].GetComponent<Renderer>().material = mats[0];

            mats = x.GetComponent<Renderer>().materials;
            mats[0] = _on;
            x.GetComponent<Renderer>().material = mats[0];

            // respawn.GetComponent<Animator>().Play("Main", 0);
            audio.clip = impact;
            audio.loop = true;
            audio.Play();
            respawn.GetComponent<Animator>().Play("Main 0", 0);
            //sw.Start();

            //}

            respawn.GetComponent<flag>().savebtn = x.name.ToString();


        }
        else if ((respawn.GetComponent<flag>().mel_flag == true) && (x.name.ToString() == "btn1"))//&& savebtn != this.gameObject.name.ToString())//다른버튼 -> 1
        {
            UnityEngine.Debug.Log(this.gameObject.name.ToString());
            //sw.Stop();
            //UnityEngine.Debug.Log(sw.ElapsedMilliseconds.ToString() + "ms");
            //UnityEngine.Debug.Log((float)(2000 - sw.ElapsedMilliseconds % 2000) / 1000);
            yield return new WaitForSeconds((float)(2000 - test.GetComponent<flag>().sw.ElapsedMilliseconds % 2000) / 1000);
            // sw.Reset();
            UnityEngine.Debug.Log(respawn.GetComponent<flag>().savebtn + " " + this.gameObject.name.ToString());
            //if (respawn.GetComponent<flag>().savebtn == x.name.ToString())
            //{
            //    audio.Stop();
            //    respawn.GetComponent<Animator>().Play("Main", 0);
            //    respawn.GetComponent<flag>().mel_flag = false;
            //}
            //else
            //{
            audio.Stop();

            GameObject[] a = GameObject.FindGameObjectsWithTag("drumbtn");

            mats = a[0].GetComponent<Renderer>().materials;
            mats[0] = _off2;
            a[0].GetComponent<Renderer>().material = mats[0];

            mats = a[1].GetComponent<Renderer>().materials;
            mats[0] = _off;
            a[1].GetComponent<Renderer>().material = mats[0];

            mats = a[2].GetComponent<Renderer>().materials;
            mats[0] = _off1;
            a[2].GetComponent<Renderer>().material = mats[0];

            mats = x.GetComponent<Renderer>().materials;
            mats[0] = _on1;
            x.GetComponent<Renderer>().material = mats[0];

            //respawn.GetComponent<Animator>().Play("Main", 0);
            audio.clip = impact2;
            audio.loop = true;
            audio.Play();
            respawn.GetComponent<Animator>().Play("Main 1", 0);
            //sw.Start();
            //}
            respawn.GetComponent<flag>().savebtn = x.name.ToString();

        }

        else if ((respawn.GetComponent<flag>().mel_flag == true) && (x.name.ToString() == "btn2"))//&& savebtn != this.gameObject.name.ToString())//다른버튼 -> 2
        {
            UnityEngine.Debug.Log(this.gameObject.name.ToString());
            //sw.Stop();
            //UnityEngine.Debug.Log(sw.ElapsedMilliseconds.ToString() + "ms");
            //UnityEngine.Debug.Log((float)(2000 - sw.ElapsedMilliseconds % 2000) / 1000);
            yield return new WaitForSeconds((float)(2000 - test.GetComponent<flag>().sw.ElapsedMilliseconds % 2000) / 1000);
            // sw.Reset();
            UnityEngine.Debug.Log(respawn.GetComponent<flag>().savebtn + " " + this.gameObject.name.ToString());
            //if (respawn.GetComponent<flag>().savebtn == x.name.ToString())
            //{
            //    audio.Stop();
            //    respawn.GetComponent<Animator>().Play("Main", 0);
            //    respawn.GetComponent<flag>().mel_flag = false;
            //}
            //else
            //{
            audio.Stop();

            GameObject[] a = GameObject.FindGameObjectsWithTag("drumbtn");

            mats = a[0].GetComponent<Renderer>().materials;
            mats[0] = _off2;
            a[0].GetComponent<Renderer>().material = mats[0];

            mats = a[1].GetComponent<Renderer>().materials;
            mats[0] = _off;
            a[1].GetComponent<Renderer>().material = mats[0];

            mats = a[2].GetComponent<Renderer>().materials;
            mats[0] = _off1;
            a[2].GetComponent<Renderer>().material = mats[0];

            mats = x.GetComponent<Renderer>().materials;
            mats[0] = _on2;
            x.GetComponent<Renderer>().material = mats[0];

            // respawn.GetComponent<Animator>().Play("Main", 0);
            audio.clip = impact3;
            audio.loop = true;
            audio.Play();
            respawn.GetComponent<Animator>().Play("Main 2", 0);
            //sw.Start();
            // }
            respawn.GetComponent<flag>().savebtn = x.name.ToString();

        }

    }
}
