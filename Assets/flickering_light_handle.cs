using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flickering_light_handle : MonoBehaviour
{
    public Light _Light;

    public float MinTime;
    public float MaxTime;
    private float Timer;

    // 오디오 추가 시 public AudioSource AS;
    // public AudioClip LightAudio;

    void Start()
    {
        Timer = Random.Range(MinTime, MaxTime);
    }

    void Update()
    {
        HandleFlickering();
    }

    void HandleFlickering()
    {
        if (Timer > 0)
            Timer -= Time.deltaTime;

        if (Timer <= 0)
        {
            _Light.enabled = !_Light.enabled;
            Timer = Random.Range(MinTime, MaxTime);
            // AS.PlayOneShot(LightAudio);
        }
    }
}




