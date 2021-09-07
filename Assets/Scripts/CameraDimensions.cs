using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDimensions : MonoBehaviour
{
    void Start() => Camera.main.orthographicSize = 9f / ((float)Camera.main.pixelWidth / Camera.main.pixelHeight); 
}
