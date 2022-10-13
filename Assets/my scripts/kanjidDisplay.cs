using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class kanjidDisplay : MonoBehaviour
{
    public TextMeshProUGUI kanjidisplay;
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
        kanjidisplay.text = dialogue.activelinekanji[dialogue.indexkanji].Replace("|", "\n");

    }
}
