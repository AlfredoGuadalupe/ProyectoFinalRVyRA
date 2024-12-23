using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MainMenu : MonoBehaviour
{
    private UIDocument _document,_infomenu;
    public GameObject[] _modelos;
    private GameObject _model;
    public UIDocument _modelmenu;
    public UIDocument[] _infos;
    public float _zoomfactor = 1f, _maxzoom = 5f;
    private float _minzoom = 1f;
    private Button _david,_monalisa,_macchina,_noche,_olive,_vitruvio,_info, _menu, _zoomin, _zoomout;
    private List<Button> _buttons;
    private int _currentModel;

    private void Start(){
        _zoomout = _modelmenu.rootVisualElement.Q<Button>("ZoomOut");
        _zoomout.SetEnabled(false);
        _modelmenu.rootVisualElement.style.display = DisplayStyle.None;
        foreach(UIDocument menu in _infos){
            menu.rootVisualElement.style.display = DisplayStyle.None;
        }
    }
    private void Awake(){
        _document = GetComponent<UIDocument>();
        _david = _document.rootVisualElement.Q<Button>("David");
        _monalisa = _document.rootVisualElement.Q<Button>("MonaLisa");
        _macchina = _document.rootVisualElement.Q<Button>("DaVinciMacchina");
        _noche = _document.rootVisualElement.Q<Button>("NocheEstrellada");
        _olive = _document.rootVisualElement.Q<Button>("OliveTrees");
        _vitruvio = _document.rootVisualElement.Q<Button>("Vitruvio");
        _buttons = _document.rootVisualElement.Query<Button>().ToList();
        _david.RegisterCallback<ClickEvent>(OnClickDavid);
        _monalisa.RegisterCallback<ClickEvent>(OnClickMona);
        _macchina.RegisterCallback<ClickEvent>(OnClickMacchina);
        _noche.RegisterCallback<ClickEvent>(OnClickNoche);
        _olive.RegisterCallback<ClickEvent>(OnClickOlive);
        _vitruvio.RegisterCallback<ClickEvent>(OnClickVitruvio);
        _info = _modelmenu.rootVisualElement.Q<Button>("InfoButton");
        _menu = _modelmenu.rootVisualElement.Q<Button>("MenuButton");
        _zoomin = _modelmenu.rootVisualElement.Q<Button>("ZoomIn");
        _zoomout = _modelmenu.rootVisualElement.Q<Button>("ZoomOut");
        _info.RegisterCallback<ClickEvent>(OnClickInfo);
        _menu.RegisterCallback<ClickEvent>(OnClickMenu);
        _zoomin.RegisterCallback<ClickEvent>(OnClickZoomIn);
        _zoomout.RegisterCallback<ClickEvent>(OnClickZoomOut);
    }
    private void OnDisable(){
        _david.UnregisterCallback<ClickEvent>(OnClickDavid);
        _monalisa.UnregisterCallback<ClickEvent>(OnClickMona);
        _macchina.UnregisterCallback<ClickEvent>(OnClickMacchina);
        _noche.UnregisterCallback<ClickEvent>(OnClickNoche);
        _olive.UnregisterCallback<ClickEvent>(OnClickOlive);
        _vitruvio.UnregisterCallback<ClickEvent>(OnClickVitruvio);
        _info.UnregisterCallback<ClickEvent>(OnClickInfo);
        _menu.UnregisterCallback<ClickEvent>(OnClickMenu);
        _zoomin.UnregisterCallback<ClickEvent>(OnClickZoomIn);
        _zoomout.UnregisterCallback<ClickEvent>(OnClickZoomOut);
    }

    private void OnClickDavid(ClickEvent evt){
        var button = evt.target as Button;
        if (button != null)
        {
            Debug.Log("Button Clicked: " + button.name);
        }
        _document.rootVisualElement.style.display = DisplayStyle.None;
        _currentModel = _buttons.IndexOf(_david);
        Debug.Log("Index of button: " + _currentModel);
        _modelos[_currentModel].SetActive(true);
        _model = _modelos[_currentModel];
        _infomenu = _infos[_currentModel];
        _modelmenu.rootVisualElement.style.display = DisplayStyle.Flex;
    }

    private void OnClickMona(ClickEvent evt){
        var button = evt.target as Button;
        if (button != null)
        {
            Debug.Log("Button Clicked: " + button.name);
        }
        _document.rootVisualElement.style.display = DisplayStyle.None;
        _currentModel = _buttons.IndexOf(_monalisa);
        Debug.Log("Index of button: " + _currentModel);
        _modelos[_currentModel].SetActive(true);
        _model = _modelos[_currentModel];
        _infomenu = _infos[_currentModel];
        _modelmenu.rootVisualElement.style.display = DisplayStyle.Flex;
    }

    private void OnClickMacchina(ClickEvent evt){
        var button = evt.target as Button;
        if (button != null)
        {
            Debug.Log("Button Clicked: " + button.name);
        }
        _document.rootVisualElement.style.display = DisplayStyle.None;
        _currentModel = _buttons.IndexOf(_macchina);
        Debug.Log("Index of button: " + _currentModel);
        _modelos[_currentModel].SetActive(true);
        _model = _modelos[_currentModel];
        _infomenu = _infos[_currentModel];
        _modelmenu.rootVisualElement.style.display = DisplayStyle.Flex;
    }

    private void OnClickNoche(ClickEvent evt){
        var button = evt.target as Button;
        if (button != null)
        {
            Debug.Log("Button Clicked: " + button.name);
        }
        _document.rootVisualElement.style.display = DisplayStyle.None;
        _currentModel = _buttons.IndexOf(_noche);
        Debug.Log("Index of button: " + _currentModel);
        _modelos[_currentModel].SetActive(true);
        _model = _modelos[_currentModel];
        _infomenu = _infos[_currentModel];
        _modelmenu.rootVisualElement.style.display = DisplayStyle.Flex;
    }

    private void OnClickOlive(ClickEvent evt){
        var button = evt.target as Button;
        if (button != null)
        {
            Debug.Log("Button Clicked: " + button.name);
        }
        _document.rootVisualElement.style.display = DisplayStyle.None;
        _currentModel = _buttons.IndexOf(_olive);
        Debug.Log("Index of button: " + _currentModel);
        _modelos[_currentModel].SetActive(true);
        _model = _modelos[_currentModel];
        _infomenu = _infos[_currentModel];
        _modelmenu.rootVisualElement.style.display = DisplayStyle.Flex;
    }

    private void OnClickVitruvio(ClickEvent evt){
        var button = evt.target as Button;
        if (button != null)
        {
            Debug.Log("Button Clicked: " + button.name);
        }
        _document.rootVisualElement.style.display = DisplayStyle.None;
        _currentModel = _buttons.IndexOf(_vitruvio);
        Debug.Log("Index of button: " + _currentModel);
        _modelos[_currentModel].SetActive(true);
        _model = _modelos[_currentModel];
        _infomenu = _infos[_currentModel];
        _modelmenu.rootVisualElement.style.display = DisplayStyle.Flex;
    }

    private void OnClickMenu(ClickEvent evt){
        var button = evt.target as Button;
        if (button != null)
        {
            Debug.Log("Button Clicked: " + button.name);
        }
        _modelmenu.rootVisualElement.style.display = DisplayStyle.None;
        _model.SetActive(false);
        _document.rootVisualElement.style.display = DisplayStyle.Flex;
    }

    private void OnClickInfo(ClickEvent evt){
        var button = evt.target as Button;
        if (button != null)
        {
            Debug.Log("Button Clicked: " + button.name);
        }
        _infomenu.rootVisualElement.style.display = DisplayStyle.Flex;
    }

    private void OnClickZoomIn(ClickEvent evt){
        var button = evt.target as Button;
        if (button != null)
        {
            Debug.Log("Button Clicked: " + button.name);
        }
        if(_model.transform.localScale.x < _maxzoom){
            _model.transform.localScale = new Vector3(_model.transform.localScale.x + _zoomfactor, _model.transform.localScale.y + _zoomfactor, _model.transform.localScale.z + _zoomfactor);
        }
    }

    private void OnClickZoomOut(ClickEvent evt){
        var button = evt.target as Button;
        if (button != null)
        {
            Debug.Log("Button Clicked: " + button.name);
        }
        if(_model.transform.localScale.x > _minzoom){
            _model.transform.localScale = new Vector3(_model.transform.localScale.x - _zoomfactor, _model.transform.localScale.y - _zoomfactor, _model.transform.localScale.z - _zoomfactor);
        }
    }

    void Update(){
        if(_model != null && _model.transform.localScale.x == _maxzoom)
        {
            _zoomin.SetEnabled(false);
            if(_zoomout.enabledSelf == false)
            {
                _zoomout.SetEnabled(true);
            }
        }
        else if(_model != null && _model.transform.localScale.x < _maxzoom && _model.transform.localScale.x > _minzoom)
        {
            _zoomin.SetEnabled(true);
            _zoomout.SetEnabled(true);
        }
        else if(_model != null && _model.transform.localScale.x == _minzoom)
        {
            _zoomout.SetEnabled(false);
            if(_zoomin.enabledSelf == false)
            {
                _zoomin.SetEnabled(true);
            }
        }
    }
}