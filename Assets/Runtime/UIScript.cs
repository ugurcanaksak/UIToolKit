using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UIScript : MonoBehaviour
{
    public UIDocument document;
    

    private void Start()
    {
        var button = document.rootVisualElement.Q<Button>("button");
        var button2 = document.rootVisualElement.Q<Button>("button2");
        var button3 = document.rootVisualElement.Q<Button>("button3");
        var slider = document.rootVisualElement.Q<Slider>("Brightness");

        button.RegisterCallback<ClickEvent>(LeftClicked);
        button2.RegisterCallback<ClickEvent>(UpClicked);
        button3.RegisterCallback<ClickEvent>(RightClicked);

        slider.RegisterCallback<ChangeEvent<float>>(OnBrightnessChange);
    }

    private void RightClicked(ClickEvent evt)
    {
        Debug.Log("Right Clicked");
    }

        private void LeftClicked(ClickEvent evt)
    {
        Debug.Log("Left Clicked");
    }

        private void UpClicked(ClickEvent evt)
    {
        Debug.Log("Up Clicked");
    }

        private void OnBrightnessChange(ChangeEvent<float> bri)
    {
        Debug.Log($"Brightness: {bri.newValue}");
    }
}
