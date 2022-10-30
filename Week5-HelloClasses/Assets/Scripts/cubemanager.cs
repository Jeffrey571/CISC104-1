using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CubeManager : MonoBehaviour
{

    public Cube MyCube;

    public Slider Slider;
    private float cubeheighText;
    private float cubelengthText;
    private float cubewidthText;

    public GameObject cubeheighText;
    public GameObject cubelengthText;
    public GameObject cubewidthText;

    private TextMeshProUGUI cubeheighText { get; set; }
    private TextMeshProUGUI cubelengthText { get; set; }
    private TextMeshProUGUI cubewidthText { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        cubeheighText = cubeheighText.GetComponent<TextMeshProUGUI>();
        cubelengthText = cubelengthText.GetComponent<TextMeshProUGUI>();
        cubewidthText = cubewidText.GetComponent<TextMeshProUGUI>();

        MyCube = new Cube(0, 0, 0);

        CalculateGeometricProperties();
    }

    // Update is called once per frame
    void Update()
    {
        cubeheighText.text = "Cube heigth: " + MyCube.GetHeight();
        cubelengthText.text = "Cube length: " + MyCube.GetLength();
        cubewidthText.text = "Cube width: " + MyCube.GetWidth();
    }

    public void SliderChanged(float newValue)
    {
    GetValuesFromSliders();

    }

    private void SliderChanged(float newValue)
    {
        //cubeheighText.TextMeshProUGUI = 4.0 float;
        cubeheighText.
        cubelengthText.TextMeshProUGUI = 4.0 float;
        cubewidthText.TextMeshProUGUI = 6.0 float;
    }
}
