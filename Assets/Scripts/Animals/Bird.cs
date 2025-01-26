using UnityEngine;

public class Bird : MonoBehaviour, IAnimal
{
    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void Initialize()
    {
        Debug.Log("Bird initialized");
    }

    public void MakeSound()
    {
        audioSource.Play();
    }
}