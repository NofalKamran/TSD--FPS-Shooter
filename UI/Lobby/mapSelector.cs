using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mapSelector : MonoBehaviour
{
    public Scrollbar scrollb;
    public bool enabler = false; private bool enablerMinus = false;
    [SerializeField]
    GameObject border;
    // Start is called before the first frame update
    void Start()
    {
        scrollb.value=0f;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enabler)
        {
            scrollb.value = Mathf.MoveTowards(scrollb.value, 1, 0.1f);
            //Color color2 = new Color(166f, 166f, 166f,0.5f);
            //border.GetComponent<Image>().color = new Color(255, 255, 255, Mathf.MoveTowards(255, 150, 0.1f));
        }
        else if (enablerMinus)
        {

            scrollb.value = Mathf.MoveTowards(scrollb.value,0, 0.1f);
        }

    }
    public void buttonPress()
    {
        enabler = true;
       StartCoroutine(offNabler());
         
         
         
    }
    public void buttonPressLeft()
    {
        enablerMinus = true;
        StartCoroutine(offNabler2());



    }
    public void borderAnimate()
    {
        Color color2 = new Color(166f, 166f, 166f);
      border.GetComponent<Image>().color = Color.Lerp(border.GetComponent<Image>().color, color2, 1f); 
       // print("Border color" + border.GetComponent<Image>().color);
    }
    IEnumerator offNabler()
    {
        yield return new WaitForSeconds(0.2f);
        enabler= false;
    }
    IEnumerator offNabler2()
    {
        yield return new WaitForSeconds(0.2f);
        enablerMinus = false;
    }
}
