using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[System.Serializable]
public class PacketDataDefine
{
	public int ID;
	public long TimeStamp;
	public int Index;
	public string Content;

	public PacketDataDefine (int id, int index, string content, DateTime datetime)
	{
		ID = id;
		Index = index;
		Content = content;
		TimeStamp = datetime.Ticks;
	}
	public PacketDataDefine (int id, int index, string content)
	{
		ID = id;
		Index = index;
		Content = content;
		TimeStamp = DateTime.Now.Ticks;
	}
	public static int TimeSpan (PacketDataDefine x, PacketDataDefine y)
	{
		return (int)(x.TimeStamp - y.TimeStamp)/ 10000;
	}

	public static int TimeSpan (PacketDataDefine x)
	{
		return (int)( DateTime.Now.Ticks -x.TimeStamp)/ 10000;
	}

	public string ToJson ()
	{
		return JsonUtility.ToJson (this);
	}

	public static PacketDataDefine FromJson (string json)
	{
		return JsonUtility.FromJson<PacketDataDefine> (json);
	}
}
