using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Test : MonoBehaviour {
    private VisualElement root;


    void Start() {
        Debug.Log("Starting");
        var doc = GetComponent<UIDocument>();
        root = doc.rootVisualElement;
        var ve = new VisualElement();
        ve.style.width = 100;
        ve.style.height = 100;
        ve.style.backgroundColor = Color.green;
        root.Add(ve);
    }

    void Update() {
        //Debug.Log(root.childCount);

    }
}
