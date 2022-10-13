using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialoguetrigger : MonoBehaviour
{

    Dialogue dialogue;
    [SerializeField] GameObject Dialoguebox;
    [SerializeField] GameObject bedroomMirror;
    [SerializeField] GameObject doorway;
    [SerializeField] GameObject bathroomMirror;
    [SerializeField] GameObject bedSide;
    [SerializeField] GameObject shower;
    [SerializeField] GameObject fridge;
    [SerializeField] GameObject infrontofTv;
    [SerializeField] GameObject exit;

    // Start is called before the first frame update
    void Awake()
    {
        dialogue = Dialoguebox.GetComponent<Dialogue>();
        bedroomMirror.SetActive(true);
        doorway.SetActive(false);
        bathroomMirror.SetActive(false);
        bedSide.SetActive(false);
        shower.SetActive(false);
        fridge.SetActive(false);
        infrontofTv.SetActive(false);
        exit.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //change lines depending on checkpoint
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("point0")) //infront of the mirror
        {
            dialogue.activeline = dialogue.line2;
            dialogue.activelineTrans = dialogue.line2Trans;
            dialogue.activelinewords = dialogue.line2words;
            dialogue.activelinekanji = dialogue.line2kanji;
            dialogue.activelinegrmr = dialogue.line2grmr;

            dialogue.textComponent.text = string.Empty;
            dialogue.textComponenttrans.text = string.Empty;
            dialogue.textComponentgrmr.text = string.Empty;
            dialogue.textComponentkanji.text = string.Empty;

            dialogue.StartDialogue();
            bedroomMirror.SetActive(false);
            doorway.SetActive(true);
            
        }
        if (other.CompareTag("point1"))//doorway
        {
            dialogue.activeline = dialogue.line3;
            dialogue.activelineTrans = dialogue.line3Trans;
            dialogue.activelinewords = dialogue.line3words;
            dialogue.activelinekanji = dialogue.line3kanji;
            dialogue.activelinegrmr = dialogue.line3grmr;

            dialogue.textComponent.text = string.Empty;
            dialogue.textComponenttrans.text = string.Empty;
            dialogue.textComponentwordlist.text = string.Empty;
            dialogue.textComponentgrmr.text = string.Empty;
            dialogue.textComponentkanji.text = string.Empty;

            dialogue.StartDialogue();
            doorway.SetActive(false);
            bathroomMirror.SetActive(true);
        }
        if (other.CompareTag("point2"))//bathroomMirror
        {
            dialogue.activeline = dialogue.line4;
            dialogue.activelineTrans = dialogue.line4Trans;
            dialogue.activelinewords = dialogue.line4words;
            dialogue.activelinekanji = dialogue.line4kanji;
            dialogue.activelinegrmr = dialogue.line4grmr;


            dialogue.textComponent.text = string.Empty;
            dialogue.textComponenttrans.text = string.Empty;
            dialogue.textComponentwordlist.text = string.Empty;
            dialogue.textComponentgrmr.text = string.Empty;
            dialogue.textComponentkanji.text = string.Empty;

            dialogue.StartDialogue();
            bedroomMirror.SetActive(false);
            bedSide.SetActive(true);
        }
        if (other.CompareTag("point3"))//bedSide
        {
            dialogue.activeline = dialogue.line5;
            dialogue.activelineTrans = dialogue.line5Trans;
            dialogue.activelinewords = dialogue.line5words;
            dialogue.activelinekanji = dialogue.line5kanji;
            dialogue.activelinegrmr = dialogue.line5grmr;


            dialogue.textComponent.text = string.Empty;
            dialogue.textComponenttrans.text = string.Empty;
            dialogue.textComponentwordlist.text = string.Empty;
            dialogue.textComponentgrmr.text = string.Empty;
            dialogue.textComponentkanji.text = string.Empty;
            dialogue.StartDialogue();
            bedSide.SetActive(false);
            shower.SetActive(true);
        }
        if (other.CompareTag("point4"))//shower
        {
            dialogue.activeline = dialogue.line6;
            dialogue.activelineTrans = dialogue.line6Trans;
            dialogue.activelinewords = dialogue.line6words;
            dialogue.activelinekanji = dialogue.line6kanji;
            dialogue.activelinegrmr = dialogue.line6grmr;

            dialogue.textComponent.text = string.Empty;
            dialogue.textComponenttrans.text = string.Empty;
            dialogue.textComponentwordlist.text = string.Empty;
            dialogue.textComponentgrmr.text = string.Empty;
            dialogue.textComponentkanji.text = string.Empty;
            dialogue.StartDialogue();
            shower.SetActive(false);
            fridge.SetActive(true);
        }
        if (other.CompareTag("point5"))//fridge
        {
            dialogue.activeline = dialogue.line7;
            dialogue.activelineTrans = dialogue.line7Trans;
            dialogue.activelinewords = dialogue.line7words;
            dialogue.activelinekanji = dialogue.line7kanji;
            dialogue.activelinegrmr = dialogue.line7grmr;

            dialogue.textComponent.text = string.Empty;
            dialogue.textComponenttrans.text = string.Empty;
            dialogue.textComponentwordlist.text = string.Empty;
            dialogue.textComponentgrmr.text = string.Empty;
            dialogue.textComponentkanji.text = string.Empty;
            dialogue.StartDialogue();
            fridge.SetActive(false);
            infrontofTv.SetActive(true);
        }
        if (other.CompareTag("point6"))//infrontofTv
        {
            dialogue.activeline = dialogue.line8;
            dialogue.activelineTrans = dialogue.line8Trans;
            dialogue.activelinewords = dialogue.line8words;
            dialogue.activelinekanji = dialogue.line8kanji;
            dialogue.activelinegrmr = dialogue.line8grmr;

            dialogue.textComponent.text = string.Empty;
            dialogue.textComponenttrans.text = string.Empty;
            dialogue.textComponentwordlist.text = string.Empty;
            dialogue.textComponentgrmr.text = string.Empty;
            dialogue.textComponentkanji.text = string.Empty;
            dialogue.StartDialogue();
            infrontofTv.SetActive(false);
            exit.SetActive(true);
        }
        if (other.CompareTag("point7"))//exit
        {
            dialogue.activeline = dialogue.line9;
            dialogue.activelineTrans = dialogue.line9Trans;
            dialogue.activelinewords = dialogue.line9words;
            dialogue.activelinekanji = dialogue.line9kanji;
            dialogue.activelinegrmr = dialogue.line9grmr;

            dialogue.textComponent.text = string.Empty;
            dialogue.textComponenttrans.text = string.Empty;
            dialogue.textComponentwordlist.text = string.Empty;
            dialogue.textComponentgrmr.text = string.Empty;
            dialogue.textComponentkanji.text = string.Empty;
            dialogue.StartDialogue();
        }
    }
}
