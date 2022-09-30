using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    Transform cam;
    Vector2 camStartPos;
    float distance;
    GameObject[] backgrounds;
    Material[] mat;
    float[] backSpeed;
    [Range(0.01f, 0.6f)]
    public float parallaxSpeed;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main.transform;
        camStartPosm = cam.position;
        int BackCount = transform.childCount;
        mat = new Material[BackCount];
        backSpeed = new float[BackCount];

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
