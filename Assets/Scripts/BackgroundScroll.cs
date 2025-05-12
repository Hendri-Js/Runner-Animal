using System;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{

    [SerializeField] private float ScrollSpeed;
    
    private Material backgroundMaterial;

    private void Awake()
    {
        backgroundMaterial = GetComponent<Renderer>().material;
    }
    
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        backgroundMaterial.mainTextureOffset = new Vector2(Time.time * ScrollSpeed, 0);
    }
}
