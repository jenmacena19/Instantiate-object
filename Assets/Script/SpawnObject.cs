using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnObject : MonoBehaviour
{
    [SerializeField] List<GameObject> towers;
    public GameObject selectedTower;

    private void Start()
    {
       
    }

    public void selectTower(int index)
    {
        selectedTower = towers[index];
        Debug.Log(selectedTower);
    }

    
}
