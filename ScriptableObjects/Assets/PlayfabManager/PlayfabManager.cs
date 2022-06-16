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
    public string UserName, Email, MyPassword,MyPlayfabID;
    public bool isNewlyCreated,isRegistered,isLogin;
    public string ErrorMessage;
    public GameEvent RegisterFailed;


    #region Registeration

    public void RegisterToPlayfab(string Username,string Email,string Password)
    {
        MyPassword = Password;
        var request = new RegisterPlayFabUserRequest
        {
            DisplayName = UserName,
            Username = UserName,
            Email = Email,
            Password = Password,
            RequireBothUsernameAndEmail = true
        };
        PlayFabClientAPI.RegisterPlayFabUser(request, OnRegisterSuccess, OnRegisterFailed);
    }

    private void OnRegisterFailed(PlayFabError obj)
    {
        Debug.Log("On RegisterFailed because   " + obj);
        ErrorMessage = obj.ToString();
        RegisterFailed.RaiseEvent();
    }

    private void OnRegisterSuccess(RegisterPlayFabUserResult obj)
    {
        obj.Username = UserName;
        obj.PlayFabId = MyPlayfabID;
        isRegistered = true;
    }

    #endregion

    #region Login


    #endregion

}
