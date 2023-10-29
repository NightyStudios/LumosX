using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebL : MonoBehaviour
{
    public void Link(string LinkID)
    {
        Application.OpenURL(LinkID);
    }
}
