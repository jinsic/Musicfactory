using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particle_sc : MonoBehaviour
{

    public GameObject mel1;
    public GameObject durm1;
    public GameObject code1;
    public GameObject base1;

    public ParticleSystem system1_1;
    public ParticleSystem system1_2;
    public ParticleSystem system2_1;
    public ParticleSystem system2_2;
    public ParticleSystem system3_1;
    public ParticleSystem system3_2;
    public ParticleSystem system4_1;
    public ParticleSystem system4_2;
    public ParticleSystem system5_1;
    public ParticleSystem system5_2;
    public ParticleSystem system6_1;
    public ParticleSystem system6_2;
    public ParticleSystem system7_1;
    public ParticleSystem system7_2;
    public ParticleSystem system8_1;
    public ParticleSystem system8_2;

    bool iscall = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (mel1.GetComponent<flag>().mel_flag && durm1.GetComponent<flag>().mel_flag && code1.GetComponent<flag>().mel_flag && base1.GetComponent<flag>().mel_flag)
        {
            if (iscall == false)
            {

                Debug.Log("d");
                system1_1.Play();
                system1_2.Play();
                system2_1.Play();
                system2_2.Play();
                system3_1.Play();
                system3_2.Play();

                system4_1.Play();
                system4_2.Play();


                system5_1.Play();
                system5_2.Play();
                system6_1.Play();
                system6_2.Play();
                system7_1.Play();
                system7_2.Play();

                system8_1.Play();
                system8_2.Play();


                iscall = true;
            }
        }

        else
        {

            system1_1.Stop();
            system1_2.Stop();
            system2_1.Stop();
            system2_2.Stop();
            system3_1.Stop();
            system3_2.Stop();

            system4_1.Stop();
            system4_2.Stop();


            system5_1.Stop();
            system5_2.Stop();
            system6_1.Stop();
            system6_2.Stop();
            system7_1.Stop();
            system7_2.Stop();

            system8_1.Stop();
            system8_2.Stop();



            iscall = false;

        }

    }
}
