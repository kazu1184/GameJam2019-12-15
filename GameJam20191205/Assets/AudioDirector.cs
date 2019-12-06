using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioDirector : MonoBehaviour
{
    public AudioSource AS;
    public AudioClip TAP, SuccessRhythm, missRhythm;

    // Start is called before the first frame update
    void Start()
    {
        AS = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTap()
    {
        AS.PlayOneShot(TAP);
    }

    public void OnSuccessRhythm()
    {
        AS.PlayOneShot(SuccessRhythm);
    }

    public void OnmissRhythm()
    {
        AS.PlayOneShot(missRhythm);
    }

}
