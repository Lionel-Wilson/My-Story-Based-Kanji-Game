using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class translationDisplay : MonoBehaviour
{
    public TextMeshProUGUI JPLine;
    public TextMeshProUGUI currentTranslation;
    Dialogue dialogue; 
    [SerializeField] GameObject Dialoguebox;
    
    void Awake()
    {
        dialogue = Dialoguebox.GetComponent<Dialogue>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        JPLine.text = dialogue.activeline[dialogue.index];
        currentTranslation.text = dialogue.activelineTrans[dialogue.indextrans];

    }
}
