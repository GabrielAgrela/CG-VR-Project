using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class GameManager : MonoBehaviourPunCallbacks
{

	public void setUsername(string username)
	{
		PhotonNetwork.ConnectUsingSettings();
		PhotonNetwork.NickName = username;
	}



	public override void OnConnectedToMaster()
	{
		PhotonNetwork.JoinLobby(TypedLobby.Default);
		Debug.Log("connected");
		RoomOptions roomOptions = new RoomOptions();
		roomOptions.MaxPlayers=5;
		PhotonNetwork.JoinOrCreateRoom("test123",roomOptions,TypedLobby.Default);
		Debug.Log("JOINING");
	}
	public override void OnJoinedRoom()
	{
		Debug.Log("JOINED");
		PhotonNetwork.LoadLevel("samplescene2");
	}

    // Update is called once per frame
    void Update()
    {

    }
}
