using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MainMenu : MonoBehaviour
{
    private UIDocument _document;
    public GameObject[] _modelos;
    public GameObject _doc;
    private Button _button;

    private void Awake(){
        _document = GetComponent<UIDocument>();
        _button = _document.rootVisualElement.Q<Button>("MonaLisa");
        _button.RegisterCallback<ClickEvent>(OnClick);
    }
    private void OnDisable(){
        _button.UnregisterCallback<ClickEvent>(OnClick);
    }

    private void OnClick(ClickEvent evt){
        var button = evt.target as Button;
        if (button != null)
        {
            Debug.Log("Button Clicked: " + button.name);
        }
        //_doc.SetActive(false);
        _document.rootVisualElement.style.display = DisplayStyle.None;
        Debug.Log(_modelos.Length);
        _modelos[0].SetActive(true);
        /*foreach(UIDocument menu in _menus){
            menu.rootVisualElement.style.display = DisplayStyle.None;
        }*/
    }
}