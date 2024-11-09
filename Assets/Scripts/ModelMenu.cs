using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ModelMenu : MonoBehaviour
{
    private UIDocument _document;
    public UIDocument _document2;
    public GameObject _modelo;
    private Button _info, _menu, _zoomin, _zoomout;

    private void Awake(){
        _document = GetComponent<UIDocument>();
        _info = _document.rootVisualElement.Q<Button>("InfoButton");
        _menu = _document.rootVisualElement.Q<Button>("MenuButton");
        _zoomin = _document.rootVisualElement.Q<Button>("ZoomIn");
        _zoomout = _document.rootVisualElement.Q<Button>("ZoomOut");
        _info.RegisterCallback<ClickEvent>(OnClickInfo);
        _menu.RegisterCallback<ClickEvent>(OnClickMenu);
        _zoomin.RegisterCallback<ClickEvent>(OnClickZoomIn);
        _zoomout.RegisterCallback<ClickEvent>(OnClickZoomOut);
        
    }

    private void OnDisable(){
        _info.UnregisterCallback<ClickEvent>(OnClickMenu);
    }

    private void OnClickMenu(ClickEvent evt){
        var button = evt.target as Button;
        if (button != null)
        {
            Debug.Log("Button Clicked: " + button.name);
        }
        _modelo.SetActive(false);
        Debug.Log(_document2);
        _document2.rootVisualElement.style.display = DisplayStyle.Flex;
        /*foreach(UIDocument menu in _menus){
            menu.rootVisualElement.style.display = DisplayStyle.None;
        }*/
    }

    private void OnClickInfo(ClickEvent evt){
        var button = evt.target as Button;
        if (button != null)
        {
            Debug.Log("Button Clicked: " + button.name);
        }
    }

    private void OnClickZoomIn(ClickEvent evt){
        var button = evt.target as Button;
        if (button != null)
        {
            Debug.Log("Button Clicked: " + button.name);
        }
    }

    private void OnClickZoomOut(ClickEvent evt){
        var button = evt.target as Button;
        if (button != null)
        {
            Debug.Log("Button Clicked: " + button.name);
        }
    }

}