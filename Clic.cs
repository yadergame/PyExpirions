using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Clic : MonoBehaviour
{
    [SerializeField]int money;
    public Text UbgradeTxt;
    int SellUbgr=10;
    int countUbgr;
    
    
    public Text moneyTxt;
    void Start() 
    {
        money=PlayerPrefs.GetInt("money");
        countUbgr=PlayerPrefs.GetInt("countUbgr");
        StartCoroutine(IDLEmoney());
    }
    public void ButtonClick()
    {   
        money++;
        PlayerPrefs.SetInt("money",money);
    }
    public void ToCraftMenuScene()
    {
        SceneManager.LoadScene(1);
    }
    IEnumerator IDLEmoney()
    {  
        yield return new WaitForSeconds(1);
        money+=countUbgr;
        StartCoroutine(IDLEmoney());
    }
    public void Restart()
    {
        PlayerPrefs.SetInt("money",0);
        PlayerPrefs.SetInt("CountUbgr",0);
        PlayerPrefs.SetInt("money",0);
        PlayerPrefs.SetInt("SellUbgr",0);
    }
    void Update()
    {
        if(money>1000)
        {
            moneyTxt.text=(money/1000).ToString()+"k";
        }
        else
        {
            moneyTxt.text=money.ToString();
        }
    }  
}
