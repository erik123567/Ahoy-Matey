using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class MyNetworkManager : NetworkManager {

	// Update is called once per frame
	void Update () {
		
	}

	public void MyStartHost ()
	{
		Debug.Log("Starting host at " + Time.timeSinceLevelLoad);
		StartHost();
	}

	public override void OnStartHost(){
		Debug.Log("host started at " + Time.timeSinceLevelLoad);
	}

	public override void OnStartClient (NetworkClient myClient)
	{
		Debug.Log(Time.timeSinceLevelLoad+ "clinet start requested");
		InvokeRepeating("PrintDots", 0f, 1f);
	}

	public override void OnClientConnect (NetworkConnection conn)
	{
		Debug.Log(Time.timeSinceLevelLoad + " client is connected to IP " + conn.address);
		CancelInvoke();
	}

	void PrintDots(){
		Debug.Log(".");
	}
}
