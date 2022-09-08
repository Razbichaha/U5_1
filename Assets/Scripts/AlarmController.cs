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
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _animator.SetBool("isAlarm", false);
        _audioSource.loop = false;
    }
}
