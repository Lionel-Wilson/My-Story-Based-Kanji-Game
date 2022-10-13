using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class grammarDisplay : MonoBehaviour
{
    public TextMeshProUGUI grammarexp;
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
        grammarexp.text = dialogue.activelinegrmr[dialogue.indexgrmr].Replace("|", "\n");
    }
}
