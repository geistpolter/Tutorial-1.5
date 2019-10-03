using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTrigger : MonoBehaviour
{
    public AudioSource musicSource;

    public AudioClip musicClipWalk;

    public AudioClip musicClipRun;

    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        //Makes walk music play
        if (Input.GetKeyDown(KeyCode.W))
        {
            musicSource.clip = musicClipWalk;
            musicSource.Play();
            anim.SetInteger("State", 1);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            musicSource.Stop();
            anim.SetInteger("State", 0);
        }

        //Makes run music play
        if (Input.GetKeyDown(KeyCode.R))
        {
            musicSource.clip = musicClipRun;
            musicSource.Play();
            anim.SetInteger("State", 2);
        }
        if (Input.GetKeyUp(KeyCode.R))
        {
            musicSource.Stop();
            anim.SetInteger("State", 0);
        }

        //The loopty loop
        if (Input.GetKeyDown(KeyCode.L))
        {
            musicSource.loop = true;
        }

        if (Input.GetKeyUp(KeyCode.L))
        {
            musicSource.loop = false;
        }
    }
}
