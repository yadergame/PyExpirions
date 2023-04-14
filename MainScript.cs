using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScript : MonoBehaviour
{   
    public int Healthpoint=4;
    [SerializeField]GameObject[] Svechi=new GameObject[4];

    // Update is called once per frame
    void Update()
    {
        for(int i=0;i==3;i++)
        {
            if(Healthpoint<i+1)
            {
                Svechi[i].SetActive(false);
            }
            else
            {
                Svechi[i].SetActive(true);
            }
        }
        if(Input.GetKeyDown(KeyCode.R)){ Healthpoint+=1;}
        if(Input.GetKeyDown(KeyCode.G)){ Healthpoint-=1;}
        PlayerPrefs.SetInt("HP",Healthpoint);   
    }
}
