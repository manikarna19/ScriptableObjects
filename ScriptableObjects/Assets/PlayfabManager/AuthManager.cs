using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AuthManager : MonoBehaviour
{
    public PlayfabManager MyPlayfab;
    public string DisplayName;

    public TMP_InputField UserNameIF, EmailIF, PassWordIF, ConfirmPasswordIF;
    public TMP_Text warningRegistertext;
    void Start()
    {
        
    }

  
    void Update()
    {
        
    }
    public void OnRegisterButonClicked()
    {
        DisplayName = UserNameIF.text;
        if (UserNameIF.text == "")
        {
            StartCoroutine(DisplayRegisterWarningMsg(" UserName cannot be empty "));
            return;
        }
        if (EmailIF.text == "")
        {
            StartCoroutine(DisplayRegisterWarningMsg(" Email cannot be empty "));
            return;
        }
        if (PassWordIF.text.Length < 6)
        {
            StartCoroutine(DisplayRegisterWarningMsg(" Passwords must be atleast 6 characters long "));
            return;
        }
        if (ConfirmPasswordIF.text != PassWordIF.text)
        {
            StartCoroutine(DisplayRegisterWarningMsg(" Passwords does not Match "));
            return;
        }
        else
        {
            MyPlayfab.RegisterToPlayfab(UserNameIF.text, EmailIF.text, PassWordIF.text);
            
        }
       
    }
    public IEnumerator DisplayRegisterWarningMsg(string msg)
    {
        warningRegistertext.text = msg;
        yield return new WaitForSeconds(3);
        warningRegistertext.text = "";
    }

    public void ShowErrorMessage()
    {
        if (MyPlayfab.ErrorMessage == "The display name entered is not available.")
        {
            StartCoroutine(DisplayRegisterWarningMsg(" UserName already exists. Please use a different one "));
        }
        else if (MyPlayfab.ErrorMessage == "Email address not available")
        {
            StartCoroutine(DisplayRegisterWarningMsg("Email address already exists. Please use a different one"));
        }
        else if (MyPlayfab.ErrorMessage == "Cannot resolve destination host")
        {
            StartCoroutine(DisplayRegisterWarningMsg(" Please check your internet connection."));
        }
        else
        {
            StartCoroutine(DisplayRegisterWarningMsg(MyPlayfab.ErrorMessage + " . Please Try again"));
        }
    }
    private void OnApplicationQuit()
    {
        MyPlayfab.isLogin = false;
        MyPlayfab.ErrorMessage = null;
    }
}
