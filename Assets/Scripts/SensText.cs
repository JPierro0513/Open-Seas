using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SensText : MonoBehaviour {

  TMPro.TextMeshProUGUI sensText;

  void Start()
  {
    sensText = GetComponent<TMPro.TextMeshProUGUI>();
  }

  public void textUpdate (float value)
  {
    sensText.text = "Mouse Sensitivity: " + value;
  }
}