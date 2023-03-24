using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalTower : MonoBehaviour
{
    public GameObject controller;
    private SpawnObject scriptSpaw;
    void Start()
    {
        scriptSpaw = controller.GetComponent<SpawnObject>();
    }
    void OnMouseDown()
    {
        if (scriptSpaw.selectedTower != null)
        {
            Instantiate(scriptSpaw.selectedTower, Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10)), Quaternion.identity);
            Debug.Log("fUNCIONOU");
        }
    }
}
