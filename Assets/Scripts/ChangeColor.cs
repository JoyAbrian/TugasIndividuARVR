using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    [SerializeField] private Material material;

    // Start is called before the first frame update
    void Start()
    {
            
    }

    public void ColorChange()
    {
        GetComponent<Renderer>().material = material;
    }
}
