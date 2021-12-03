using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MenuUiStart : MonoBehaviour
{
    public InputField input;

    private void Start()
    {
        input = gameObject.GetComponent<InputField>();
    }


}
