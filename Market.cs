using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Market : MonoBehaviour
{   
    public Text UbgradeTxt;
    int SellUbgr=10;
    public Text moneyTxt;
    public int countUbgr;
    int money;
    void Start()
    {
        money=PlayerPrefs.GetInt("money");
        SellUbgr=PlayerPrefs.GetInt("SellUbgr");
        countUbgr=PlayerPrefs.GetInt("countUbgr");
        StartCoroutine(IDLEmoney());
    }
    IEnumerator IDLEmoney()
    {  
        yield return new WaitForSeconds(1);
        money+=countUbgr;
        StartCoroutine(IDLEmoney());
    }
    public void ToMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void TradeMaket()
    {
        if(SellUbgr<=money)
        {
            money-=SellUbgr;
            SellUbgr+=20;
            countUbgr++;
            PlayerPrefs.SetInt("SellUbgr",SellUbgr);
            PlayerPrefs.SetInt("money",money);
            PlayerPrefs.SetInt("countUbgr",countUbgr);
        }
    }
    void Update()
    {
        UbgradeTxt.text="Рабы для добычи монет. Цена:"+SellUbgr.ToString();
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
