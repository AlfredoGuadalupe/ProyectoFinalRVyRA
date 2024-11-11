using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Info : MonoBehaviour
{
    private UIDocument _document;
    private Button _close;

    private void Awake(){
        _document = GetComponent<UIDocument>();
        _close = _document.rootVisualElement.Q<Button>("Close");
        _close.RegisterCallback<ClickEvent>(OnClickClose);
        
    }

    private void OnDisable(){
        _close.UnregisterCallback<ClickEvent>(OnClickClose);
    }

    private void OnClickClose(ClickEvent evt){
        _document.rootVisualElement.style.display = DisplayStyle.None;
    }
}
