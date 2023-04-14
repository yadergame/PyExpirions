using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class CardScript : MonoBehaviour,IPointerClickHandler
{
    [SerializeField]Vector3 Cord;
    bool UEbla=false;
    public void OnPointerClick(PointerEventData eventData)
    {
        if(!UEbla)
        {   
            transform.position=new Vector3(0,2.2f,-5);
            Vector3 rotate=transform.eulerAngles;
            rotate.z=15;
            transform.rotation = Quaternion.Euler(rotate);
            UEbla=true;
        }
        else
        {
            Vector3 rotate=transform.eulerAngles;
            rotate.z=90;
            transform.rotation = Quaternion.Euler(rotate);
            transform.position=Cord;
            UEbla=false;
        }
    }
    void Start()
    {
        Cord=this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
