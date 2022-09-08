//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class AlarmController : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private AudioSource _audioSource;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _animator.SetBool("isAlarm", true);
        _audioSource.Play();
        _audioSource.loop = true;
       // _audioSource.mute = false;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _animator.SetBool("isAlarm", false);
        _audioSource.loop = false;
       // _audioSource.Stop();
       // _audioSource.mute = true;
    }
}
