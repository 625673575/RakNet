using UnityEngine;
using System.Collections;
using System.Net.Sockets;
using System.Net;
using RakNet;
using BitStream = RakNet.BitStream;
using System;
using UnityEngine.UI;

public class UDP : MonoBehaviour
{
	public Dropdown comb_reliable;
	public InputField input_IP;
	public InputField input_PORT;
	public Text statText;
	public Text debugText;
	public Transform scrollParent;
	public Text labelPrefab;
	public InputField inputField;
	System.DateTime sendDataTime;

	public  PacketReliability Reliability {
		get{ return (PacketReliability)comb_reliable.value; }
	}

	public void PrintContent (string info)
	{
		Text t = Instantiate (labelPrefab);

		t.gameObject.SetActive (true);
		t.transform.SetParent (scrollParent, false);
		t.text = info;
	}

	public void ClearContent ()
	{
		int count = scrollParent.childCount;
		for (int i = 0; i < count; i++) {
			Destroy (scrollParent.GetChild (i).gameObject);
		}
	}

	TimeSpan startTimeSpan;
	string holdingString;

	Packet p;
	RakPeerInterface client;

	public string ip = "127.0.0.1";
	public int serverPort = 1234;
	public const string PREF_IP = "IP";
	public const string PREF_PORT = "PORT";
	byte packetIdentifier;
	bool bSendRandomPacket = false;
	int frameCount=0;
	void Start ()
	{
		input_IP.text = PlayerPrefs.GetString (PREF_IP, ip);
		input_PORT.text = PlayerPrefs.GetString (PREF_PORT, serverPort.ToString ());
		Application.targetFrameRate = 30;
		Application.logMessageReceived += OnLog;
		frameCount = 0;
		comb_reliable.AddOptions (new System.Collections.Generic.List<string> (Enum.GetNames (typeof(PacketReliability))));
	}

	public void OnApplicationQuit ()
	{
		PlayerPrefs.SetString (PREF_IP, input_IP.text);
		PlayerPrefs.SetString (PREF_PORT, input_PORT.text);
	}

	private void OnLog (string condition, string stackTrace, LogType type)
	{
		debugText.text = type.ToString () + ":" + condition + ":" + stackTrace;
	}
	public void SendInput(){
		SendString (inputField.text, true, Reliability);
	}
	public void SendRandomPacket ()
	{
		var d = new PacketDataDefine (0, frameCount, Guid.NewGuid ().ToString ());
		SendString (d.ToJson (), true, Reliability);
	}

	public void StartSendContent ()
	{
		bSendRandomPacket = true;
	}

	public void EndSendContent ()
	{
		bSendRandomPacket = false;
	}

	private static System.DateTime LastSendTime;

	public void SendString (string s, bool UpdateLocalTime, PacketReliability reliability)
	{
		client.Send (s, s.Length + 1, PacketPriority.LOW_PRIORITY, reliability, (char)0, new AddressOrGUID (new SystemAddress ("192.168.8.111", 60001)), true);
	}

	public void CloseConnection ()
	{
		client.CloseConnection (client.GetSystemAddressFromIndex (0), false);
		client.Shutdown (300);
	}

	public void StartClient ()
	{
		OnApplicationQuit ();
        
		client = RakPeerInterface.GetInstance ();

		SocketDescriptor socketDescriptor = new SocketDescriptor (Convert.ToUInt16 (UnityEngine.Random.Range (81, 65536)), "0");
		socketDescriptor.socketFamily = 2;

		client.Startup (8, socketDescriptor, 1);
		client.SetOccasionalPing (true);

		ConnectionAttemptResult car = client.Connect (input_IP.text, Convert.ToUInt16 (input_PORT.text), "Rumpelstiltskin", "Rumpelstiltskin".Length);
		if (car != RakNet.ConnectionAttemptResult.CONNECTION_ATTEMPT_STARTED)
			Debug.LogError (car);

		Debug.LogWarning ("My IP Addresses:");
		for (uint i = 0; i < client.GetNumberOfAddresses (); i++) {
			Debug.LogWarning (client.GetLocalIP (i).ToString ());
		}
		Debug.LogWarning ("My GUID is " + client.GetGuidFromSystemAddress (RakNet.RakNet.UNASSIGNED_SYSTEM_ADDRESS).ToString ());
	}

	private static byte GetPacketIdentifier (Packet p)
	{
		if (p == null)
			return 255;
		byte buf = p.data [0];
		if (buf == (char)DefaultMessageIDTypes.ID_TIMESTAMP) {
			return (byte)p.data [5];
		} else
			return buf;
	}

	void Update ()
	{
		++frameCount;
		if (client == null)
			return;
		
		for (p = client.Receive (); p != null; client.DeallocatePacket (p), p = client.Receive ()) {
			packetIdentifier = GetPacketIdentifier (p);
			switch ((DefaultMessageIDTypes)packetIdentifier) {
			case DefaultMessageIDTypes.ID_DISCONNECTION_NOTIFICATION:
				Debug.Log ("ID_DISCONNECTION_NOTIFICATION");
				break;
			case DefaultMessageIDTypes.ID_ALREADY_CONNECTED:
				Debug.Log ("ID_ALREADY_CONNECTED with guid " + p.guid);
				break;
			case DefaultMessageIDTypes.ID_INCOMPATIBLE_PROTOCOL_VERSION:
				Debug.Log ("ID_INCOMPATIBLE_PROTOCOL_VERSION ");
				break;
			case DefaultMessageIDTypes.ID_REMOTE_DISCONNECTION_NOTIFICATION:
				Debug.Log ("ID_REMOTE_DISCONNECTION_NOTIFICATION ");
				break;
			case DefaultMessageIDTypes.ID_REMOTE_CONNECTION_LOST: // Server telling the clients of another client disconnecting forcefully.  You can manually broadcast this in a peer to peer enviroment if you want.
				Debug.Log ("ID_REMOTE_CONNECTION_LOST");
				break;
			case DefaultMessageIDTypes.ID_CONNECTION_BANNED: // Banned from this server
				Debug.Log ("We are banned from this server.\n");
				break;
			case DefaultMessageIDTypes.ID_CONNECTION_ATTEMPT_FAILED:
				Debug.Log ("Connection attempt failed ");
				break;
			case DefaultMessageIDTypes.ID_NO_FREE_INCOMING_CONNECTIONS:
				Debug.Log ("Server is full ");
				break;
			case DefaultMessageIDTypes.ID_INVALID_PASSWORD:
				Debug.Log ("ID_INVALID_PASSWORD\n");
				break;
			case DefaultMessageIDTypes.ID_CONNECTION_LOST:
					// Couldn't deliver a reliable packet - i.e. the other system was abnormally
					// terminated
				Debug.Log ("ID_CONNECTION_LOST\n");
				break;
			case DefaultMessageIDTypes.ID_CONNECTION_REQUEST_ACCEPTED:
					// This tells the client they have connected
				Debug.Log ("ID_CONNECTION_REQUEST_ACCEPTED to %s " + p.systemAddress.ToString () + "with GUID " + p.guid.ToString ());
				Debug.Log ("My external address is:" + client.GetExternalID (p.systemAddress).ToString ());
				break;
			case DefaultMessageIDTypes.ID_CONNECTED_PING:
			case DefaultMessageIDTypes.ID_UNCONNECTED_PING:
				Debug.Log ("Ping from " + p.systemAddress.ToString (true));
				break;
			default:
				messageCount++;
				System.DateTime now = System.DateTime.Now;
				string info = System.Text.Encoding.UTF8.GetString (p.data).Trim ();
				try{
					var data =	PacketDataDefine.FromJson (info);
					int millsec = PacketDataDefine.TimeSpan (data);
					int ping = millsec;
					if (data.Index != 1 + lastFrame) {
						++errorCount;
					}
					lastFrame = data.Index;
					totalPing += ping;
					//string[] t = info.Trim().Split();
					//int serverToClientDuration = (now.Second - int.Parse(t[6])) * 1000 + (now.Millisecond - int.Parse(t[7]));
					//int clientToServerDuration = (now.Second - int.Parse(t[2])) * 1000 + (now.Millisecond - int.Parse(t[3]));
					//string outInfo = string.Format("{0}服务器到客户端:{1}ms  客户端到服务器:{2}ms", info, serverToClientDuration, clientToServerDuration);
					string outInfo = string.Format ("Index:{0} Ping:{1}ms Content{2}", data.Index, ping, data.Content);
					PrintContent (outInfo);

					statText.text = string.Format ("平均Ping:{0}  消息总数:{1}  错误顺序:{2}", AveragePing,messageCount,errorCount-1);
					}
				catch{
					PrintContent (info);
				}
				break;
			}
		}

		if (bSendRandomPacket)
			SendRandomPacket ();
		else
			lastFrame=frameCount;
	}
	int lastFrame;
	int errorCount;
	int totalPing;
	int messageCount;
	public int AveragePing{
		get{
			return totalPing / messageCount;
		}
	}

	public void Test(){
		Debug.Log (RakNetPINVOKE.CSharp_RakNet_Add (3, 6));
	}
}