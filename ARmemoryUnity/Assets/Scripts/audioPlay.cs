using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioPlay : MonoBehaviour
{    
    public Transform target;
    
    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        AudioSource audio = GetComponent<AudioSource>();
        float distToTarget = Vector3.Distance(transform.position, target.position);

        if(audio.isPlaying && distToTarget < 1){
            audio.mute = false;
            audio.volume = 1/distToTarget;
        } else if(distToTarget < 1){
            audio.mute = false;
            audio.Play();
        }else {
            audio.Stop();
        }

    }
}
