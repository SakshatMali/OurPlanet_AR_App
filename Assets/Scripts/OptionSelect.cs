using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionSelect : MonoBehaviour
{
    public Text TextBox;
    public List<GameObject> maps;

    private static Transform ob;
    public Dropdown droppol;
    public Dropdown droppsy;
    public GameObject tog;
    //private Transform earth;
    //public GameObject earth;
    // Start is called before the first frame update
    void Start()
    {

        var dropdown = transform.GetComponent<Dropdown>();

        dropdown.options.Clear();

        List<string> opt = new List<string>();
        opt.Add("Physical");
        opt.Add("Political");

        foreach (var i in opt)
        {
            dropdown.options.Add(new Dropdown.OptionData() { text = i });
        }

        dropdown.onValueChanged.AddListener(delegate { OptionSelected(dropdown); });
    }

    void OptionSelected(Dropdown dropdown)
    {
        int i = dropdown.value;
        Debug.Log(i);

        if (tog.GetComponent<Toggle>().isOn)
        {
            Debug.Log("yes");
        }
        else
        {
            Debug.Log("no");
        }

        if (i==0)
        {
            droppsy.gameObject.SetActive(true);
            droppol.gameObject.SetActive(false);
        }

        if (i == 1)
        {
            droppsy.gameObject.SetActive(false);
            droppol.gameObject.SetActive(true);
        }

        TextBox.text = dropdown.options[i].text;

        for (int k = 0; k < maps.Count; k++)
        {
            if (k == i)
            {
                //Debug.Log(i);
                maps[k].SetActive(true);

                ob = maps[k].transform.GetChild(0);
                ob.transform.localScale = new Vector3(.5f, .5f, .5f);
                //Debug.Log("xxx  " + x);
                //this.earth = maps[k].transform.GetChild(0);
                //Debug.Log(this.earth.name);

                //maps[k].transform.GetChild(0).GetChild(0).GetChild(0).gameObject.SetActive(false);
            }

            else
            {
                maps[k].SetActive(false);
            }
        }
    }

    public void Scaleup()
    {
        //Debug.Log("xxx  " + x);
        ob.transform.localScale += new Vector3(.1f, .1f, .1f);
        Debug.Log(ob.transform.localScale);
    }

    public void Scaledown()
    {
        ob.transform.localScale += new Vector3(-.1f, -.1f, -.1f);
        //Debug.Log("xxx  " + x);
        Debug.Log(ob.transform.localScale);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
