﻿using System;

using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_InputField_OnChangeEvent : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.UI.InputField.OnChangeEvent o;
			o=new UnityEngine.UI.InputField.OnChangeEvent();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AddListener(IntPtr l) {
		try {
			UnityEngine.UI.InputField.OnChangeEvent self=(UnityEngine.UI.InputField.OnChangeEvent)checkSelf(l);
			UnityEngine.Events.UnityAction<System.String> a1;
			LuaDelegation.checkDelegate(l,2,out a1);
			self.AddListener(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RemoveListener(IntPtr l) {
		try {
			UnityEngine.UI.InputField.OnChangeEvent self=(UnityEngine.UI.InputField.OnChangeEvent)checkSelf(l);
			UnityEngine.Events.UnityAction<System.String> a1;
			LuaDelegation.checkDelegate(l,2,out a1);
			self.RemoveListener(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Invoke(IntPtr l) {
		try {
			UnityEngine.UI.InputField.OnChangeEvent self=(UnityEngine.UI.InputField.OnChangeEvent)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			self.Invoke(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetPersistentEventCount(IntPtr l) {
		try {
			UnityEngine.UI.InputField.OnChangeEvent self=(UnityEngine.UI.InputField.OnChangeEvent)checkSelf(l);
			var ret=self.GetPersistentEventCount();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetPersistentTarget(IntPtr l) {
		try {
			UnityEngine.UI.InputField.OnChangeEvent self=(UnityEngine.UI.InputField.OnChangeEvent)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetPersistentTarget(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetPersistentMethodName(IntPtr l) {
		try {
			UnityEngine.UI.InputField.OnChangeEvent self=(UnityEngine.UI.InputField.OnChangeEvent)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetPersistentMethodName(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetPersistentListenerState(IntPtr l) {
		try {
			UnityEngine.UI.InputField.OnChangeEvent self=(UnityEngine.UI.InputField.OnChangeEvent)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			UnityEngine.Events.UnityEventCallState a2;
			checkEnum(l,3,out a2);
			self.SetPersistentListenerState(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RemoveAllListeners(IntPtr l) {
		try {
			UnityEngine.UI.InputField.OnChangeEvent self=(UnityEngine.UI.InputField.OnChangeEvent)checkSelf(l);
			self.RemoveAllListeners();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		LuaUnityEvent_string.reg(l);
		getTypeTable(l,"UnityEngine.UI.InputField.OnChangeEvent");
		addMember(l,AddListener);
		addMember(l,RemoveListener);
		addMember(l,Invoke);
		addMember(l,GetPersistentEventCount);
		addMember(l,GetPersistentTarget);
		addMember(l,GetPersistentMethodName);
		addMember(l,SetPersistentListenerState);
		addMember(l,RemoveAllListeners);
		createTypeMetatable(l,constructor, typeof(UnityEngine.UI.InputField.OnChangeEvent),typeof(LuaUnityEvent_string));
	}
}
