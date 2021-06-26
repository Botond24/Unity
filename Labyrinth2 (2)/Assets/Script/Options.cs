using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Options : MonoBehaviour
{
    public Slider Sans;
    public InputField SansInput;
    public float SansValue = 1f;
    // Start is called before the first frame update
    void Start()
    {
        SansInput.text = SansValue.ToString();
        Sans.value = SansValue;
        Sans.onValueChanged.AddListener(delegate {SliderChange(); });
        SansInput.onEndEdit.AddListener(delegate {InputChange(); });
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetFloat("Sans", SansValue);
    }

    void SliderChange()
    {
        SansValue = Sans.value;
        SansInput.text = SansValue.ToString();
    }

    void InputChange()
    {
        SansValue = float.Parse(SansInput.text);
        Sans.value = SansValue;
    }

}
