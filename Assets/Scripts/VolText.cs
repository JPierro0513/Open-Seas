using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class VolText : MonoBehaviour {

  TMPro.TextMeshProUGUI volText;

  void Start()
  {
    volText = GetComponent<TMPro.TextMeshProUGUI>();
  }

  public void textUpdate (float value)
  {
    volText.text = "Volume: " + value + "%";
  }
}