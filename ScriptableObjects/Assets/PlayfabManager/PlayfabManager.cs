using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;
using UnityEngine.UI;
using TMPro;
using System;

[CreateAssetMenu()]
public class PlayfabManager :ScriptableObject
{
    public string UserName, MyEmail, MyPassword,MyPlayfabID;
    public bool isNewlyCreated,isRegistered,isLogin;
    public string ErrorMessage;
    public GameEvent RegisterFailed;


    #region Registeration

    public void RegisterToPlayfab(string Username,string Email,string Password)
    {
        MyPassword = Password;
        MyEmail = Email;
        var request = new RegisterPlayFabUserRequest
        {
            Username = Username,
            Email = Email,
            Password = Password,
            RequireBothUsernameAndEmail = true
        };
        PlayFabClientAPI.RegisterPlayFabUser(request, OnRegisterSuccess, OnRegisterFailed);
    }

    private void OnRegisterFailed(PlayFabError obj)
    {
        Debug.Log("On RegisterFailed because   " + obj);
        ErrorMessage = "";
        ErrorMessage = obj.ToString();
        RegisterFailed.RaiseEvent();
    }

    private void OnRegisterSuccess(RegisterPlayFabUserResult obj)
    {
        Debug.Log(" registered Successfulluy");
        UserName = obj.Username;
        MyPlayfabID = obj.PlayFabId;
        isRegistered = true;
    }

    #endregion

    #region Login


    #endregion

}
