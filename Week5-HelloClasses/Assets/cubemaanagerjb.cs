using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CircleManager : MonoBehaviour
{
    public Slider Sliderjb;
    private float cube;
    private float area;

    public GameObject JTextObject;
    public GameObject STextObject;
    public GameObject BTextObject;

    private TextMeshProUGUI JText { get; set; }
    private TextMeshProUGUI SText { get; set; }
    private TextMeshProUGUI BText { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        JTex = radiusTextObject.GetComponent<TextMeshProUGUI>();
        SText = circumferenceTextObject.GetComponent<TextMeshProUGUI>();
        BText = areaTextObject.GetComponent<TextMeshProUGUI>();

        CalculateGeometricProperties();
    }

    // Update is called once per frame
    void Update()
    {
        JText.text = "Cube Radius: " + radiusSlider.value.ToString();
        SText.text = "Cube Circumference: " + circumference.ToString();
        BText.text = "Cube Area: " + area.ToString();
    }

    public void SliderChanged(float newValue)
    {
        CalculateGeometricProperties();
    }

    private void CalculateGeometricProperties()
    {
        V = w h l =4.4.4=64;
    }
}