using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Dialogue : MonoBehaviour
{
    PlayerMove playerMove;
    [SerializeField] GameObject Playermove;
    
    //Reference - https://www.youtube.com/watch?v=8oTYabhj248
    public TextMeshProUGUI textComponent;
    public TextMeshProUGUI textComponenttrans;
    public TextMeshProUGUI textComponentwordlist;
    public TextMeshProUGUI textComponentgrmr;
    public TextMeshProUGUI textComponentkanji;


    public string[] line1; //where lines to be printed will be.
    public string[] line2; 
    public string[] line3; 
    public string[] line4; 
    public string[] line5; 
    public string[] line6; 
    public string[] line7; 
    public string[] line8; 
    public string[] line9; 

    public string[] line1Trans; //eng translaitons
    public string[] line2Trans; 
    public string[] line3Trans; 
    public string[] line4Trans; 
    public string[] line5Trans; 
    public string[] line6Trans; 
    public string[] line7Trans; 
    public string[] line8Trans; 
    public string[] line9Trans; 

    public string[] line1words; //word list
    public string[] line2words; 
    public string[] line3words; 
    public string[] line4words; 
    public string[] line5words; 
    public string[] line6words; 
    public string[] line7words; 
    public string[] line8words; 
    public string[] line9words; 

    public string[] line1grmr; //grammar list
    public string[] line2grmr; 
    public string[] line3grmr; 
    public string[] line4grmr; 
    public string[] line5grmr; 
    public string[] line6grmr; 
    public string[] line7grmr; 
    public string[] line8grmr; 
    public string[] line9grmr; 


    public string[] line1kanji; //kanji list
    public string[] line2kanji; 
    public string[] line3kanji; 
    public string[] line4kanji; 
    public string[] line5kanji; 
    public string[] line6kanji; 
    public string[] line7kanji; 
    public string[] line8kanji; 
    public string[] line9kanji; 

    public float textSpeed;//speed at which text is being printed

    public string[] activeline;
    public string[] activelineTrans;
    public string[] activelinewords;
    public string[] activelinegrmr;
    public string[] activelinekanji;

    public int index;
    public int indextrans;
    public int indexwords;
    public int indexgrmr;
    public int indexkanji;
    
    void Awake()
    {
        playerMove = Playermove.GetComponent<PlayerMove>();
    }

    // Start is called before the first frame update
    void Start()
    {
        activeline = line1;
        activelineTrans = line1Trans;
        activelinewords = line1words;
        activelinegrmr = line1grmr;
        activelinekanji = line1kanji;
        textComponent.text = string.Empty;
        StartDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            if(textComponent.text == activeline[index])
            {
                NextLine();
                NextLinetrans();
                NextLinewords();
                NextLinegrmr();
                NextLinekanji();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = activeline[index];

            }
        }
    }

    public void StartDialogue()
    {
        playerMove.CanMove = false; //stop player from moving
        gameObject.SetActive(true);
        index = 0;
        indextrans = 0;
        indexwords = 0;
        indexgrmr = 0;
        indexkanji = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        //type each character 1 by 1
        foreach (char c in activeline[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    public void NextLine()
    {
        if (index < activeline.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            gameObject.SetActive(false);
            playerMove.CanMove = true;//allow player to move again
        }
    }
    public void NextLinetrans()
    {
        if (indextrans < activelineTrans.Length - 1)
        {
            indextrans++;
            textComponenttrans.text = activelineTrans[indextrans];
        }
        else
        {
            //gameObject.SetActive(false); - dunno what to put here
        }
    }
    public void NextLinewords()
    {
        if (indexwords < activelinewords.Length - 1)
        {
            indexwords++;
            textComponentwordlist.text = activelinewords[indexwords];
        }
        else
        {
            //gameObject.SetActive(false); - dunno what to put here
        }
    }
    public void NextLinegrmr()
    {
        if (indexgrmr < activelinegrmr.Length - 1)
        {
            indexgrmr++;
            textComponentgrmr.text = activelinegrmr[indexgrmr];
        }
        else
        {
            //gameObject.SetActive(false); - dunno what to put here
        }
    }
    public void NextLinekanji()
    {
        if (indexkanji < activelinekanji.Length - 1)
        {
            indexkanji++;
            textComponentkanji.text = activelinekanji[indexkanji];
        }
        else
        {
            //gameObject.SetActive(false); - dunno what to put here
        }
    }



}
