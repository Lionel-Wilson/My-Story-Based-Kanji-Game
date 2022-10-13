using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class wordlistDisplay : MonoBehaviour
{
    public TextMeshProUGUI wordlist;
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
        wordlist.text = dialogue.activelinewords[dialogue.indexwords].Replace("|", "\n");

    }
}
