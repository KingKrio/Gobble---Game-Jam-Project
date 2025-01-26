using GoSharpCore;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnBubble : MonoBehaviour
{

    public Sprite black;
    public Sprite white;

    // Start is called before the first frame update
    void Start()
    {
       // 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void placeBubble()
    {
        this.GetComponent<Image>().gameObject.SetActive(true);
        if (this.transform.parent.transform.parent.transform.GetComponentInParent<GameLogic>().getCurrentColour() == 0)
        {
            this.GetComponentInChildren<Image>().sprite = black;
            this.transform.parent.transform.parent.transform.GetComponentInParent<GameLogic>().changeColour(1);
        }
        else
        {
            this.GetComponentInChildren<Image>().sprite = white;
            this.transform.parent.transform.parent.transform.GetComponentInParent<GameLogic>().changeColour(0);
        }
    }
}
