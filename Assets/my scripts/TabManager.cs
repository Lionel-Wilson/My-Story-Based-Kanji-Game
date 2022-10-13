using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabManager : MonoBehaviour
{
    [SerializeField] private GameObject[] tabs;

    [SerializeField] private GameObject helpwindow;
    
    GameObject Activetab = null;
    int activeTabindex = 0;

    void Start()
    {
        helpwindow.SetActive(false);
    }

    public void Update()
    {
        //open and close the help window.
        if (Input.GetKeyDown(KeyCode.H))
        {
            if(helpwindow.activeSelf == true)
            {
                helpwindow.SetActive(false);
            }
            else
            {
                helpwindow.SetActive(true);
                //set initial tab to translation tab when opened and deactivate other tabs
                tabs[0].SetActive(true);
                Activetab = tabs[0];
                for (int i = 0; i < tabs.Length; i++)
                {
                    if(tabs[i] != Activetab)
                    {
                        tabs[i].SetActive(false);
                    }
                }
            }
        }

        //test manual tab switcher - incomplete
        if(Input.GetKeyDown(KeyCode.E))
        {
            //check if current tab index + 1 is not > than tabs length
            if(activeTabindex+1 < tabs.Length)
            {
                //make active tab + 1 active tab
                tabs[activeTabindex+1].SetActive(true);
                activeTabindex += 1;
                Activetab = tabs[activeTabindex];
                //deactivate other tabs
                for (int i = 0; i < tabs.Length; i++)
                {
                    if(tabs[i] != Activetab)
                    {
                        tabs[i].SetActive(false);
                    }
                }
            }
            else
            {
                //else make tabs[0] active.
                Activetab = tabs[0];
                activeTabindex = 0;
                tabs[activeTabindex].SetActive(true);
                //deactivate other tabs.
                for (int i = 0; i < tabs.Length; i++)
                {
                    if(tabs[i] != Activetab)
                    {
                        tabs[i].SetActive(false);
                    }
                }

            }
        }    

        if(Input.GetKeyDown(KeyCode.Q))
        {
            if(activeTabindex-1 >= 0)
            {
                //make active tab - 1 active tab
                tabs[activeTabindex-1].SetActive(true);
                activeTabindex -= 1;
                Activetab = tabs[activeTabindex];
                //deactivate other tabs
                for (int i = 0; i < tabs.Length; i++)
                {
                    if(tabs[i] != Activetab)
                    {
                        tabs[i].SetActive(false);
                    }
                }
            }
            else
            {
                //else make tabs[3] active.
                Activetab = tabs[3];
                activeTabindex = 3;
                tabs[activeTabindex].SetActive(true);
                //deactivate other tabs.
                for (int i = 0; i < tabs.Length; i++)
                {
                    if(tabs[i] != Activetab)
                    {
                        tabs[i].SetActive(false);
                    }
                }

            }
        }
    }

}
