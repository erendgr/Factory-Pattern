using UnityEngine;

public class Crocodile : MonoBehaviour, IAnimal
{
    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void Initialize()
    {
        Debug.Log("Crocodile initialized");
    }

    public void MakeSound()
    {
        audioSource.Play();
    }
}