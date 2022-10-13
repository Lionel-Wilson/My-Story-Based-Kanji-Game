using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class removeself : MonoBehaviour
{
    [SerializeField] GameObject checkpoint;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            checkpoint.SetActive(false);
            
        }
    }
}
