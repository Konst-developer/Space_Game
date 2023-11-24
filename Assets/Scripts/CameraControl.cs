using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Character personage = new Character("Новый персонаж", "Самый обычный персонаж");
        personage.printInfo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
