using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class FarmManager : MonoBehaviour
{
    [SerializeField] private LayerMask layerMask;
    [SerializeField] private Vector3 offset;
    [SerializeField] private Factory[] factories;
    
    private Factory factory;

    private void Update()
    {
        SpawnAnimalOnClick();
    }

    private void SpawnAnimalOnClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            factory = factories[Random.Range(0, factories.Length)];
            
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            Debug.Log("clicked 1");
            if (Physics.Raycast(ray, out hitInfo, Mathf.Infinity, layerMask) && factory != null)
            {
                Debug.Log("clicked 2");
                Debug.Log(hitInfo.transform.name);
                factory.CreateAnimal(hitInfo.point + offset);    
            }
        }
    }
}