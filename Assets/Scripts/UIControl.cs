using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIControl : MonoBehaviour
{
    public RectTransform canvas;
    bool added = false;

    void Start()
    {
        RectTransform t = GetComponent<RectTransform>();

        t.sizeDelta = canvas.sizeDelta;
    }

    private void Update()
    {
        if (!added)
        {
            if (RightController.control)
            {
                RightController.control.closeUI += CloseUI;
                added = true;
            }
        }
    }

    void CloseUI()
    {
        canvas.transform.parent.gameObject.SetActive(false);
    }
}
