﻿using System;

using SLua;
using System.Collections.Generic;
public class Lua_GameFrameworkMessage_Msg_RC_DestroyNpc : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			GameFrameworkMessage.Msg_RC_DestroyNpc o;
			o=new GameFrameworkMessage.Msg_RC_DestroyNpc();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_npc_id(IntPtr l) {
		try {
			GameFrameworkMessage.Msg_RC_DestroyNpc self=(GameFrameworkMessage.Msg_RC_DestroyNpc)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.npc_id);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_npc_id(IntPtr l) {
		try {
			GameFrameworkMessage.Msg_RC_DestroyNpc self=(GameFrameworkMessage.Msg_RC_DestroyNpc)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.npc_id=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"GameFrameworkMessage.Msg_RC_DestroyNpc");
		addMember(l,"npc_id",get_npc_id,set_npc_id,true);
		createTypeMetatable(l,constructor, typeof(GameFrameworkMessage.Msg_RC_DestroyNpc));
	}
}
