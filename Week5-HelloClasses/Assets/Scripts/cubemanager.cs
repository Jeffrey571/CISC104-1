using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CubeManager : MonoBehaviour
{

    public Cube MyCube;
    public Slider heightSlider;
    public Slider widthSlider;
    public Slider lengthSlider;
    private float cubeheight;
    private float cubelength;
    private float cubewidth;

    public GameObject cubeheighTextObject;
    public GameObject cubelengthTextObject;
    public GameObject cubewidthTextObject;
    public GameObject cubeinfoTextObject;

    private TextMeshProUGUI cubeheighText { get; set; }
    private TextMeshProUGUI cubelengthText { get; set; }
    private TextMeshProUGUI cubewidthText { get; set; }
    private TextMeshProUGUI cubeinfoText { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        cubeheighText = cubeheighTextObject.GetComponent<TextMeshProUGUI>();
        cubelengthText = cubelengthTextObject.GetComponent<TextMeshProUGUI>();
        cubewidthText = cubewidthTextObject.GetComponent<TextMeshProUGUI>();
        cubeinfoText = cubeinfoTextObject.GetComponent<TextMeshProUGUI>();
        MyCube = new Cube(0, 0, 0);

        CalculateGeometricProperties();
    }

    private void CalculateGeometricProperties()
    {
        // Get values from sliders
        MyCube.SetHeight(heightSlider.value);
        MyCube.SetLength(lengthSlider.value);
        MyCube.SetWidth(widthSlider.value);

        // Update UI

    }

    // Update is called once per frame
    void Update()
    {
        cubeheighText.text = "Cube heigth: " + MyCube.GetHeight();
        cubelengthText.text = "Cube length: " + MyCube.GetLength();
        cubewidthText.text = "Cube width: " + MyCube.GetWidth();

        cubeinfoText.text = "Cube Volume: " + MyCube.GetVolume() + ", Edge Length: " + MyCube.GetEdgeLength();

    }

    public void SliderChanged(float newValue)
    {
        CalculateGeometricProperties();
    }

}
