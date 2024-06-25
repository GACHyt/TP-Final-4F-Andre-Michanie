using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlObjectScript : MonoBehaviour
{
    public GameObject[] objetos;
    int currentIndex = -1;
    void Start()
    {
        DesactivarTodas();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            currentIndex++;
            if (currentIndex >= objetos.Length)
            {
                currentIndex = 0;
            }
            DesactivarTodas();
            Activar(currentIndex);
        }
    }
    void DesactivarTodas()
    {
        for (int i = 0; i < objetos.Length; i++)
        {
            objetos[i].SetActive(false);
        }
    }

    void Activar(int i)
    {
        objetos[i].SetActive(true);
    }
}
