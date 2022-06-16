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

    #region Registeration

    public void RegisterToPlayfab(string Username,string Email,string Password,string ConfirmPassword)
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
    }

    private void OnRegisterSuccess(RegisterPlayFabUserResult obj)
    {
        obj.Username = UserName;
        obj.PlayFabId = MyPlayfabID;
        isRegistered = true;
    }

    #endregion

}
