using UnityEngine;

public class Frog : MonoBehaviour, IAnimal
{
    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void Initialize()
    {
        Debug.Log("Frog initialized");
    }

    public void MakeSound()
    {
        audioSource.Play();
    }
}