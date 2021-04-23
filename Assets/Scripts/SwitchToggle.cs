using UnityEngine ;
using UnityEngine.UI ;
using DG.Tweening ;

public class SwitchToggle : MonoBehaviour {
   [SerializeField] RectTransform uiHandleRectTransform ;
   [SerializeField] Color backgroundActiveColor ;
   [SerializeField] Color handleActiveColor ;

   Image backgroundImage, handleImage ;

   Color backgroundDefaultColor, handleDefaultColor ;

   Toggle toggle ;

   Vector2 handlePosition ;

    private static Transform ob;

    //private Quaternion iniposyy;
    //private Quaternion iniposii;

    public Dropdown droppol;
    public Dropdown droppsy;

    public GameObject polly;
    public GameObject phssy;

    public Text TextBox;

    private ObjectSpawn obs;

    void Awake ( ) {
      toggle = GetComponent <Toggle> ( ) ;

      handlePosition = uiHandleRectTransform.anchoredPosition ;

      backgroundImage = uiHandleRectTransform.parent.GetComponent <Image> ( ) ;
      handleImage = uiHandleRectTransform.GetComponent <Image> ( ) ;

      backgroundDefaultColor = backgroundImage.color ;
      handleDefaultColor = handleImage.color ;

      toggle.onValueChanged.AddListener (OnSwitch) ;

        //iniposii = polly.transform.rotation;
        //iniposyy = phssy.transform.rotation;

        obs = FindObjectOfType<ObjectSpawn>();

      if (toggle.isOn)
        {
            OnSwitch(true);
            droppol.gameObject.SetActive(true);
            polly.SetActive(true);

            droppsy.gameObject.SetActive(false);
            phssy.SetActive(false);

            TextBox.text = "Political";

            ob = polly.transform.GetChild(0);

        }
        /*else
        {
            droppol.gameObject.SetActive(false);
            polly.SetActive(false);

            droppsy.gameObject.SetActive(true);
            phssy.SetActive(true);
        }*/
         
   }

   void OnSwitch (bool on) {
      //uiHandleRectTransform.anchoredPosition = on ? handlePosition * -1 : handlePosition ; // no anim
      uiHandleRectTransform.DOAnchorPos (on ? handlePosition * -1 : handlePosition, .4f).SetEase (Ease.InOutBack) ;

      //backgroundImage.color = on ? backgroundActiveColor : backgroundDefaultColor ; // no anim
      backgroundImage.DOColor (on ? backgroundActiveColor : backgroundDefaultColor, .6f) ;

      //handleImage.color = on ? handleActiveColor : handleDefaultColor ; // no anim
      handleImage.DOColor (on ? handleActiveColor : handleDefaultColor, .4f) ;
   }

   void OnDestroy ( ) {
      toggle.onValueChanged.RemoveListener (OnSwitch) ;
   }

    void Update()
    {

        if (obs.earth == false)
        {
            if (toggle.isOn)
            {
                //OnSwitch(true);
                droppol.gameObject.SetActive(true);
                polly.SetActive(true);

                droppsy.gameObject.SetActive(false);
                phssy.SetActive(false);

                TextBox.text = "Political";

                ob = polly.transform.GetChild(0);

            }
            else
            {
                droppol.gameObject.SetActive(false);
                polly.SetActive(false);

                droppsy.gameObject.SetActive(true);
                phssy.SetActive(true);

                TextBox.text = "Physical";

                ob = phssy.transform.GetChild(0);
            }
        }
    }

    public void Scaleup()
    {
        //Debug.Log("xxx  " + x);
        ob.transform.localScale += new Vector3(.1f, .1f, .1f);
        //Debug.Log(ob.transform.localScale);
    }

    public void Scaledown()
    {
        ob.transform.localScale += new Vector3(-.1f, -.1f, -.1f);
        //Debug.Log("xxx  " + x);
        //Debug.Log(ob.transform.localScale);
    }

    public void Repos()
    {
        ob.transform.rotation = Quaternion.Euler(0,165,0);
    }
}
