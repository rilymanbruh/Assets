using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class FireballCaster : MonoBehaviour
{
    public Fireball fireballPrefab;
    public Transform fireballSourceTransform;
    public AudioClip shotSound;
    private AudioSource _shotAudioSource;
    

    // Start is called before the first frame update
    void Start()
    {
        _shotAudioSource = GetComponentInChildren<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, fireballSourceTransform.position, fireballSourceTransform.rotation);

            _shotAudioSource.PlayOneShot(shotSound);
        }
    }

}
