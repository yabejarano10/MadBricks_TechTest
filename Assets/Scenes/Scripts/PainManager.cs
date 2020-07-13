using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PainManager : MonoBehaviour
{
    [SerializeField]
    private GameObject brush;
    [SerializeField]
    private FlexibleColorPicker[] colorsPickers;

    [SerializeField]
    private int colorsAmount = 2;

    private Color[] colors;

    private Color mixedColor;
    // Start is called before the first frame update
    void Start()
    {
        colors = new Color[colorsAmount];
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0;i<colors.Length;i++)
        {
            colors[i] = colorsPickers[i].color;
        }
        CombineColors();
    }

    public void CombineColors()
    {
        foreach(Color c in colors)
        {
            mixedColor += c;
        }
        mixedColor /= colors.Length;
    }
    public Color GetColor()
    {
        return mixedColor;
    }
}
