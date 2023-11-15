using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetScreens : MonoBehaviour
{
    public Material mat;
    public Texture2D[] img;

    private Material m;
    private int count = 0;

    void Start()
    {
        m = Instantiate(mat);

        SetTexture(img[count]);

        gameObject.GetComponent<MeshRenderer>().material = m;
    }

    void SetTexture(Texture2D i)
    {
        m.mainTexture = i;
        m.SetTexture("_EmissionMap", i);
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "WebXRCameraSet")
        {
            RightController.control.buttonClick += InputHandler;
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.name == "WebXRCameraSet")
        {
            RightController.control.buttonClick -= InputHandler;
        }
    }

    void InputHandler()
    {
        if (img.Length - 1 > count)
        {
            count++;
            SetTexture(img[count]);
        }
    }
}
