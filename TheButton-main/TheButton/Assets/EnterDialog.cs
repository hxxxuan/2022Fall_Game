using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterDialog : MonoBehaviour
{
    public GameObject enterDialog;
    public bool canTalkToSushi;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (canTalkToSushi == true)
        {
            enterDialog.SetActive(true);
        }
   


    }

    private void OnTriggerExit2D(Collider2D collision)
    {
     
            enterDialog.SetActive(false);
       
    }

}
