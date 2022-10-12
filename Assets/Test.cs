using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    public Image Img;
    public void OnFound()
    {
        Img.color = Color.green;
    }
    public void OnNotFound()
    {
        Img.color = Color.red;
    }
}
