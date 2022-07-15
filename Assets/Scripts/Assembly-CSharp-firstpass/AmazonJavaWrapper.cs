using System;
using UnityEngine;

public class AmazonJavaWrapper : IDisposable
{
	private AndroidJavaObject jo;

	public AmazonJavaWrapper()
	{
	}

	public AmazonJavaWrapper(AndroidJavaObject o)
	{
	}

	public AndroidJavaObject getJavaObject()
	{
		return jo;
	}

	public void setAndroidJavaObject(AndroidJavaObject o)
	{
		jo = o;
	}

	public IntPtr GetRawObject()
	{
		return default(IntPtr);
	}

	public IntPtr GetRawClass()
	{
		return default(IntPtr);
	}

	public void Set<FieldType>(string fieldName, FieldType type)
	{
	}

	public FieldType Get<FieldType>(string fieldName)
	{
		return default(FieldType);
	}

	public void SetStatic<FieldType>(string fieldName, FieldType type)
	{
	}

	public FieldType GetStatic<FieldType>(string fieldName)
	{
		return default(FieldType);
	}

	public void CallStatic(string method, params object[] args)
	{
	}

	public void Call(string method, params object[] args)
	{
	}

	public ReturnType CallStatic<ReturnType>(string method, params object[] args)
	{
		return default(ReturnType);
	}

	public ReturnType Call<ReturnType>(string method, params object[] args)
	{
		return default(ReturnType);
	}

	public void Dispose()
	{
		if (jo != null)
		{
			jo.Dispose();
		}
	}
}
