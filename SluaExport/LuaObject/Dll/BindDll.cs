﻿using System;
using System.Collections.Generic;
namespace SLua {
	[LuaBinder(2)]
	public class BindDll {
		public static Action<IntPtr>[] GetBindList() {
			Action<IntPtr>[] list= {
				Lua_GameFrameworkMessage_GmUserBasic.reg,
				Lua_GameFrameworkMessage_GmUserInfo.reg,
				Lua_GameFrameworkMessage_ItemDataMsg.reg,
				Lua_GameFrameworkMessage_Msg_CL_GmAddExp.reg,
				Lua_GameFrameworkMessage_Msg_CL_GmCode.reg,
				Lua_GameFrameworkMessage_Msg_CL_GmForbidChat.reg,
				Lua_GameFrameworkMessage_Msg_CL_GmGeneralOperation.reg,
				Lua_GameFrameworkMessage_Msg_CL_GmHomeNotice.reg,
				Lua_GameFrameworkMessage_Msg_CL_GmKickUser.reg,
				Lua_GameFrameworkMessage_Msg_CL_GmLockUser.reg,
				Lua_GameFrameworkMessage_Msg_CL_GmQueryAccount.reg,
				Lua_GameFrameworkMessage_Msg_CL_GmQueryUserByFuzzyNickname.reg,
				Lua_GameFrameworkMessage_Msg_CL_GmQueryUserByGuid.reg,
				Lua_GameFrameworkMessage_Msg_CL_GmQueryUserByNickname.reg,
				Lua_GameFrameworkMessage_Msg_CL_GmUnlockUser.reg,
				Lua_GameFrameworkMessage_Msg_CL_GmUpdateMaxUserCount.reg,
				Lua_GameFrameworkMessage_Msg_CL_PublishNotice.reg,
				Lua_GameFrameworkMessage_Msg_CL_SendMail.reg,
				Lua_GameFrameworkMessage_Msg_LC_GmAddExp.reg,
				Lua_GameFrameworkMessage_Msg_LC_GmForbidChat.reg,
				Lua_GameFrameworkMessage_Msg_LC_GmGeneralOperation.reg,
				Lua_GameFrameworkMessage_Msg_LC_GmHomeNotice.reg,
				Lua_GameFrameworkMessage_Msg_LC_GmKickUser.reg,
				Lua_GameFrameworkMessage_Msg_LC_GmLockUser.reg,
				Lua_GameFrameworkMessage_Msg_LC_GmQueryAccount.reg,
				Lua_GameFrameworkMessage_Msg_LC_GmQueryUser.reg,
				Lua_GameFrameworkMessage_Msg_LC_GmQueryUserByFuzzyNickname.reg,
				Lua_GameFrameworkMessage_Msg_LC_GmUnlockUser.reg,
				Lua_GameFrameworkMessage_Msg_LC_PublishNotice.reg,
				Lua_GameFrameworkMessage_Msg_LC_SendMail.reg,
				Lua_GameFrameworkMessage_GmResultEnum.reg,
				Lua_GameFrameworkMessage_GmStateEnum.reg,
				Lua_GameFrameworkMessage_LobbyGmMessageDefine.reg,
				Lua_GameFrameworkMessage_LobbyGmMessageDefine2Type.reg,
				Lua_GameFrameworkMessage_AccountLogin.reg,
				Lua_GameFrameworkMessage_AccountLoginResult.reg,
				Lua_GameFrameworkMessage_AccountLoginResult_AccountLoginResultEnum.reg,
				Lua_GameFrameworkMessage_AccountLogout.reg,
				Lua_GameFrameworkMessage_ChangeName.reg,
				Lua_GameFrameworkMessage_ChangeNameResult.reg,
				Lua_GameFrameworkMessage_ChangeNameResult_ChangeNameResultEnum.reg,
				Lua_GameFrameworkMessage_ChangeSceneRoom.reg,
				Lua_GameFrameworkMessage_DirectLogin.reg,
				Lua_GameFrameworkMessage_EnterScene.reg,
				Lua_GameFrameworkMessage_EnterSceneResult.reg,
				Lua_GameFrameworkMessage_FriendInfoForMessage.reg,
				Lua_GameFrameworkMessage_GetQueueingCount.reg,
				Lua_GameFrameworkMessage_GmCode.reg,
				Lua_GameFrameworkMessage_ItemInfoForMessage.reg,
				Lua_GameFrameworkMessage_KickUser.reg,
				Lua_GameFrameworkMessage_Logout.reg,
				Lua_GameFrameworkMessage_MailInfoForMessage.reg,
				Lua_GameFrameworkMessage_MailItemForMessage.reg,
				Lua_GameFrameworkMessage_MemberInfoForMessage.reg,
				Lua_GameFrameworkMessage_Msg_CL_AddFriend.reg,
				Lua_GameFrameworkMessage_Msg_CL_DeleteMail.reg,
				Lua_GameFrameworkMessage_Msg_CL_DiscardItem.reg,
				Lua_GameFrameworkMessage_Msg_CL_GetMailList.reg,
				Lua_GameFrameworkMessage_Msg_CL_MarkBlack.reg,
				Lua_GameFrameworkMessage_Msg_CL_ReadMail.reg,
				Lua_GameFrameworkMessage_Msg_CL_ReceiveMail.reg,
				Lua_GameFrameworkMessage_Msg_CL_RemoveFriend.reg,
				Lua_GameFrameworkMessage_Msg_CL_UseItem.reg,
				Lua_GameFrameworkMessage_Msg_CLC_StoryMessage.reg,
				Lua_GameFrameworkMessage_Msg_CLC_StoryMessage_MessageArg.reg,
				Lua_GameFrameworkMessage_Msg_LC_AddFriend.reg,
				Lua_GameFrameworkMessage_Msg_LC_HighlightPrompt.reg,
				Lua_GameFrameworkMessage_Msg_LC_LackOfSpace.reg,
				Lua_GameFrameworkMessage_Msg_LC_MarkBlack.reg,
				Lua_GameFrameworkMessage_Msg_LC_NotifyNewMail.reg,
				Lua_GameFrameworkMessage_Msg_LC_PublishEvent.reg,
				Lua_GameFrameworkMessage_Msg_LC_PublishEvent_EventArg.reg,
				Lua_GameFrameworkMessage_Msg_LC_RemoveFriend.reg,
				Lua_GameFrameworkMessage_Msg_LC_SendGfxMessage.reg,
				Lua_GameFrameworkMessage_Msg_LC_SendGfxMessage_EventArg.reg,
				Lua_GameFrameworkMessage_Msg_LC_SyncFriendList.reg,
				Lua_GameFrameworkMessage_Msg_LC_SyncItemList.reg,
				Lua_GameFrameworkMessage_Msg_LC_SyncMailList.reg,
				Lua_GameFrameworkMessage_Msg_LC_SyncMemberList.reg,
				Lua_GameFrameworkMessage_Msg_LC_SyncRoleInfo.reg,
				Lua_GameFrameworkMessage_NodeMessageWithAccount.reg,
				Lua_GameFrameworkMessage_NodeMessageWithAccountAndGuid.reg,
				Lua_GameFrameworkMessage_NodeMessageWithGuid.reg,
				Lua_GameFrameworkMessage_NodeRegister.reg,
				Lua_GameFrameworkMessage_NodeRegisterResult.reg,
				Lua_GameFrameworkMessage_QueueingCountResult.reg,
				Lua_GameFrameworkMessage_QuitRoom.reg,
				Lua_GameFrameworkMessage_RequestNickname.reg,
				Lua_GameFrameworkMessage_RequestNicknameResult.reg,
				Lua_GameFrameworkMessage_RequestSceneRoomInfo.reg,
				Lua_GameFrameworkMessage_RequestSceneRoomList.reg,
				Lua_GameFrameworkMessage_RoleEnter.reg,
				Lua_GameFrameworkMessage_RoleEnterResult.reg,
				Lua_GameFrameworkMessage_RoleEnterResult_RoleEnterResultEnum.reg,
				Lua_GameFrameworkMessage_ServerShutdown.reg,
				Lua_GameFrameworkMessage_TooManyOperations.reg,
				Lua_GameFrameworkMessage_UserHeartbeat.reg,
				Lua_GameFrameworkMessage_VersionVerify.reg,
				Lua_GameFrameworkMessage_VersionVerifyResult.reg,
				Lua_GameFrameworkMessage_LobbyArgType.reg,
				Lua_GameFrameworkMessage_LobbyMessageDefine.reg,
				Lua_GameFrameworkMessage_LobbyMessageDefine2Type.reg,
				Lua_GameFrameworkMessage_Msg_CR_DlgClosed.reg,
				Lua_GameFrameworkMessage_Msg_CR_Enter.reg,
				Lua_GameFrameworkMessage_Msg_CR_GmCommand.reg,
				Lua_GameFrameworkMessage_Msg_CR_Observer.reg,
				Lua_GameFrameworkMessage_Msg_CR_Quit.reg,
				Lua_GameFrameworkMessage_Msg_CR_ShakeHands.reg,
				Lua_GameFrameworkMessage_Msg_CR_Skill.reg,
				Lua_GameFrameworkMessage_Msg_CR_StopSkill.reg,
				Lua_GameFrameworkMessage_Msg_CR_SwitchDebug.reg,
				Lua_GameFrameworkMessage_Msg_CR_UserMoveToPos.reg,
				Lua_GameFrameworkMessage_Msg_CRC_StoryMessage.reg,
				Lua_GameFrameworkMessage_Msg_CRC_StoryMessage_MessageArg.reg,
				Lua_GameFrameworkMessage_Msg_Ping.reg,
				Lua_GameFrameworkMessage_Msg_Pong.reg,
				Lua_GameFrameworkMessage_Msg_RC_AddImpact.reg,
				Lua_GameFrameworkMessage_Msg_RC_AddSkill.reg,
				Lua_GameFrameworkMessage_Msg_RC_AdjustPosition.reg,
				Lua_GameFrameworkMessage_Msg_RC_CampChanged.reg,
				Lua_GameFrameworkMessage_Msg_RC_ChangeScene.reg,
				Lua_GameFrameworkMessage_Msg_RC_CreateNpc.reg,
				Lua_GameFrameworkMessage_Msg_RC_DebugSpaceInfo.reg,
				Lua_GameFrameworkMessage_Msg_RC_DebugSpaceInfo_DebugSpaceInfo.reg,
				Lua_GameFrameworkMessage_Msg_RC_DestroyNpc.reg,
				Lua_GameFrameworkMessage_Msg_RC_HighlightPrompt.reg,
				Lua_GameFrameworkMessage_Msg_RC_ImpactDamage.reg,
				Lua_GameFrameworkMessage_Msg_RC_ImpactDamage_Flag.reg,
				Lua_GameFrameworkMessage_Msg_RC_LockFrame.reg,
				Lua_GameFrameworkMessage_Msg_RC_NpcDead.reg,
				Lua_GameFrameworkMessage_Msg_RC_NpcFace.reg,
				Lua_GameFrameworkMessage_Msg_RC_NpcMove.reg,
				Lua_GameFrameworkMessage_Msg_RC_NpcSkill.reg,
				Lua_GameFrameworkMessage_Msg_RC_NpcStopSkill.reg,
				Lua_GameFrameworkMessage_Msg_RC_PlayAnimation.reg,
				Lua_GameFrameworkMessage_Msg_RC_PublishEvent.reg,
				Lua_GameFrameworkMessage_Msg_RC_PublishEvent_EventArg.reg,
				Lua_GameFrameworkMessage_Msg_RC_RemoveImpact.reg,
				Lua_GameFrameworkMessage_Msg_RC_RemoveSkill.reg,
				Lua_GameFrameworkMessage_Msg_RC_SendGfxMessage.reg,
				Lua_GameFrameworkMessage_Msg_RC_SendGfxMessage_EventArg.reg,
				Lua_GameFrameworkMessage_Msg_RC_ShakeHands_Ret.reg,
				Lua_GameFrameworkMessage_Msg_RC_ShakeHands_Ret_RetType.reg,
				Lua_GameFrameworkMessage_Msg_RC_ShowDlg.reg,
				Lua_GameFrameworkMessage_Msg_RC_SyncNpcOwnerId.reg,
				Lua_GameFrameworkMessage_Msg_RC_SyncProperty.reg,
				Lua_GameFrameworkMessage_Position.reg,
				Lua_GameFrameworkMessage_ArgType.reg,
				Lua_GameFrameworkMessage_RoomMessageDefine.reg,
				Lua_GameFrameworkMessage_RoomMessageDefine2Type.reg,
				Lua_ProtoBuf_BclHelpers.reg,
				Lua_ProtoBuf_BclHelpers_NetObjectOptions.reg,
				Lua_ProtoBuf_IExtension.reg,
				Lua_ProtoBuf_BufferExtension.reg,
				Lua_ProtoBuf_ProtoBeforeSerializationAttribute.reg,
				Lua_ProtoBuf_ProtoAfterSerializationAttribute.reg,
				Lua_ProtoBuf_ProtoBeforeDeserializationAttribute.reg,
				Lua_ProtoBuf_ProtoAfterDeserializationAttribute.reg,
				Lua_ProtoBuf_DataFormat.reg,
				Lua_ProtoBuf_IExtensible.reg,
				Lua_ProtoBuf_Extensible.reg,
				Lua_ProtoBuf_ImplicitFields.reg,
				Lua_ProtoBuf_Meta_BasicList.reg,
				Lua_ProtoBuf_Meta_BasicList_NodeEnumerator.reg,
				Lua_ProtoBuf_Meta_TypeFormatEventArgs.reg,
				Lua_ProtoBuf_Meta_TypeModel.reg,
				Lua_ProtoBuf_PrefixStyle.reg,
				Lua_ProtoBuf_ProtoContractAttribute.reg,
				Lua_ProtoBuf_ProtoEnumAttribute.reg,
				Lua_ProtoBuf_ProtoException.reg,
				Lua_ProtoBuf_ProtoIgnoreAttribute.reg,
				Lua_ProtoBuf_ProtoPartialIgnoreAttribute.reg,
				Lua_ProtoBuf_ProtoIncludeAttribute.reg,
				Lua_ProtoBuf_ProtoMemberAttribute.reg,
				Lua_ProtoBuf_MemberSerializationOptions.reg,
				Lua_ProtoBuf_ProtoPartialMemberAttribute.reg,
				Lua_ProtoBuf_ProtoReader.reg,
				Lua_ProtoBuf_ProtoWriter.reg,
				Lua_ProtoBuf_SerializationContext.reg,
				Lua_ProtoBuf_Serializer.reg,
				Lua_ProtoBuf_SubItemToken.reg,
				Lua_ProtoBuf_WireType.reg,
				Lua_GameFramework_Network_Serialize.reg,
				Lua_GameFramework_LockTargetInfo.reg,
				Lua_GameFramework_PluginFramework.reg,
				Lua_GameFramework_DslUtility.reg,
				Lua_GameFramework_GameControler.reg,
				Lua_GameFramework_EntityViewModel.reg,
				Lua_GameFramework_EntityController.reg,
				Lua_GameFramework_EntityViewModelManager.reg,
				Lua_GameFramework_Plugin_IAttrExpressionPlugin.reg,
				Lua_GameFramework_Plugin_ISkillTriggerPlugin.reg,
				Lua_IStartupPlugin.reg,
				Lua_IStartupPluginFactory.reg,
				Lua_GameFramework_Plugin_IStoryCommandPlugin.reg,
				Lua_GameFramework_Plugin_ISimpleStoryCommandPlugin.reg,
				Lua_GameFramework_Plugin_IStoryValuePlugin.reg,
				Lua_GameFramework_Plugin_ISimpleStoryValuePlugin.reg,
				Lua_ITickPlugin.reg,
				Lua_ITickPluginFactory.reg,
				Lua_IObjectPluginFactory.reg,
				Lua_PluginManager.reg,
				Lua_GameFramework_Plugin_IPluginProxy.reg,
				Lua_GameFramework_Plugin_PluginProxy.reg,
				Lua_IntUobjDict.reg,
				Lua_StrUobjDict.reg,
				Lua_ObjUobjDict.reg,
				Lua_UobjIntDict.reg,
				Lua_UobjStrDict.reg,
				Lua_UobjObjDict.reg,
				Lua_UobjUobjDict.reg,
				Lua_UobjHashSet.reg,
				Lua_UobjQueue.reg,
				Lua_UobjStack.reg,
				Lua_AiQueryComparer.reg,
				Lua_GameFramework_AbstractScriptBehavior.reg,
				Lua_GameFramework_AssetBundleManager.reg,
				Lua_GameFramework_ResourceSystem.reg,
				Lua_GameFramework_ResourceSystem_OjbectEx.reg,
				Lua_GameFramework_SpriteManager.reg,
				Lua_GameFramework_UiResourceSystem.reg,
				Lua_GameFramework_Skill_PredefinedSkill.reg,
				Lua_GameFramework_Skill_GfxSkillSenderInfo.reg,
				Lua_GameFramework_Skill_GfxSkillSystem.reg,
				Lua_SkillSystem_AbstractSkillTriger.reg,
				Lua_GameFramework_Skill_Trigers_AnimationSpeedTriger.reg,
				Lua_GameFramework_Skill_Trigers_TargetManager.reg,
				Lua_GameFramework_Skill_Trigers_SelectTargetTrigger.reg,
				Lua_GameFramework_Skill_Trigers_FaceToTargetTrigger.reg,
				Lua_GameFramework_Skill_Trigers_ClearTargetsTrigger.reg,
				Lua_GameFramework_Skill_Trigers_EffectManager.reg,
				Lua_GameFramework_Skill_Trigers_SendStoryMessageTrigger.reg,
				Lua_GameFramework_Skill_Trigers_SendGfxMessageTrigger.reg,
				Lua_GameFramework_Skill_Trigers_SendGfxMessageWithTagTrigger.reg,
				Lua_GameFramework_Skill_Trigers_PublishGfxEventTrigger.reg,
				Lua_GameFramework_Skill_Trigers_KeepTargetTrigger.reg,
				Lua_GameFramework_Skill_Trigers_UseImpactTrigger.reg,
				Lua_GameFramework_Skill_Trigers_BuffToTargetTrigger.reg,
				Lua_GameFramework_Skill_Trigers_BuffToSelfTrigger.reg,
				Lua_GameFramework_Skill_Trigers_ImpactTrigger.reg,
				Lua_GameFramework_Skill_Trigers_PeriodicallyImpactTrigger.reg,
				Lua_GameFramework_Skill_Trigers_StopAtTargetType.reg,
				Lua_GameFramework_Skill_Trigers_MoveSectionInfo.reg,
				Lua_GameFramework_Skill_Trigers_CurveMovementTrigger.reg,
				Lua_GameFramework_Skill_Trigers_StorePosTrigger.reg,
				Lua_GameFramework_Skill_Trigers_RestorePosTrigger.reg,
				Lua_GameFramework_Skill_Trigers_RotateTrigger.reg,
				Lua_GameFramework_Skill_Trigers_AudioManager.reg,
				Lua_GameFramework_Skill_Trigers_PlaySoundTriger.reg,
				Lua_GameFramework_Skill_Trigers_StopSoundTrigger.reg,
				Lua_GameFramework_Skill_Trigers_AdjustSectionDurationTrigger.reg,
				Lua_GameFramework_Skill_Trigers_KeepSectionForBuffTrigger.reg,
				Lua_GameFramework_Skill_Trigers_StopSectionTrigger.reg,
				Lua_GameFramework_Skill_Trigers_GotoSectionTrigger.reg,
				Lua_GameFramework_Skill_Trigers_StopEffectTrigger.reg,
				Lua_GameFramework_Skill_Trigers_TransformTrigger.reg,
				Lua_GameFramework_Skill_Trigers_TeleportTrigger.reg,
				Lua_GameFramework_Skill_Trigers_TriggerUtil.reg,
				Lua_GameFramework_Story_GfxStorySystem.reg,
				Lua_GameFramework_Story_UiStoryInitializer.reg,
				Lua_GameFramework_ClientInfo.reg,
				Lua_GameFramework_Utility.reg,
				Lua_PointController.reg,
				Lua_GameFramework_IActionQueue.reg,
				Lua_GameFramework_ClientConcurrentActionProcessor.reg,
				Lua_GameFramework_ClientAsyncActionProcessor.reg,
				Lua_GameFramework_ClientDelayActionProcessor.reg,
				Lua_GameFramework_ClientConcurrentPoolAllocatedAction.reg,
				Lua_GameFramework_ClientConcurrentTypedDataCollection.reg,
				Lua_System_Threading_ClientInterlocked.reg,
				Lua_System_Threading_ClientSpinLock.reg,
				Lua_System_Threading_ClientSimpleRwLock.reg,
				Lua_System_Threading_ClientSpinWait.reg,
				Lua_GameFramework_MyClientTashDispatcher.reg,
				Lua_GameFramework_MyClientThread.reg,
				Lua_GameFramework_BinaryTable.reg,
				Lua_GameFramework_BinaryTable_FileHeader.reg,
				Lua_GameFramework_Txt2Binary.reg,
				Lua_GameFramework_DataRecordUtility.reg,
				Lua_GameFramework_ResourceReadProxy.reg,
				Lua_GameFramework_IDataRecord.reg,
				Lua_GameFramework_Geometry.reg,
				Lua_GameFramework_Geometry3D.reg,
				Lua_GameFramework_GlobalVariables.reg,
				Lua_GameFramework_Log_Type.reg,
				Lua_GameFramework_LogSystem.reg,
				Lua_GameFramework_ProxyPublishData.reg,
				Lua_GameFramework_PublishSubscribeSystem.reg,
				Lua_GameFramework_StoryCommandGroupDefine.reg,
				Lua_GameFramework_StoryValueGroupDefine.reg,
				Lua_Dict.reg,
				Lua_GameFramework_Converter.reg,
				Lua_IntList.reg,
				Lua_StrList.reg,
				Lua_IntIntDict.reg,
				Lua_IntStrDict.reg,
				Lua_IntObjDict.reg,
				Lua_StrIntDict.reg,
				Lua_StrStrDict.reg,
				Lua_StrObjDict.reg,
				Lua_ObjIntDict.reg,
				Lua_ObjStrDict.reg,
				Lua_ObjObjDict.reg,
				Lua_IntHashSet.reg,
				Lua_StrHashSet.reg,
				Lua_ObjHashSet.reg,
				Lua_ObjQueue.reg,
				Lua_StrQueue.reg,
				Lua_ObjStack.reg,
				Lua_StrStack.reg,
				Lua_GameFramework_Helper.reg,
				Lua_GameFramework_Helper_Random.reg,
				Lua_GameFramework_HomePath.reg,
				Lua_GameFramework_KeyString.reg,
				Lua_IntComparer.reg,
				Lua_UintComparer.reg,
				Lua_LongComparer.reg,
				Lua_UlongComparer.reg,
				Lua_GameFramework_PoolAllocatedAction.reg,
				Lua_GameFramework_TimeUtility.reg,
				Lua_GameFramework_TimeSnapshot.reg,
				Lua_GameFramework_TypedDataCollection.reg,
				Lua_GameFramework_CustomDataCollection.reg,
				Lua_Dsl_ISyntaxComponent.reg,
				Lua_Dsl_AbstractSyntaxComponent.reg,
				Lua_Dsl_NullSyntax.reg,
				Lua_Dsl_ValueData.reg,
				Lua_Dsl_CallData.reg,
				Lua_Dsl_CallData_ParamClassEnum.reg,
				Lua_Dsl_FunctionData.reg,
				Lua_Dsl_FunctionData_ExtentClassEnum.reg,
				Lua_Dsl_StatementData.reg,
				Lua_Dsl_DslInfo.reg,
				Lua_Dsl_DslFile.reg,
				Lua_Dsl_Utility.reg,
				Lua_GameFramework_AiData_ForMoveCommand.reg,
				Lua_GameFramework_PredefinedAiStateId.reg,
				Lua_GameFramework_AiStoryInstanceInfo.reg,
				Lua_GameFramework_AiStateInfo.reg,
				Lua_GameFramework_AttrCalculator.reg,
				Lua_GameFramework_AttrCalc_AttrExpressionList.reg,
				Lua_GameFramework_AttrCalc_IAttrExpression.reg,
				Lua_GameFramework_AttrCalc_IAttrExpressionFactory.reg,
				Lua_GameFramework_AttrCalc_AbstractAttrExpression.reg,
				Lua_GameFramework_AttrCalc_DslCalculator.reg,
				Lua_GameFramework_AttrCalc_DslCalculator2.reg,
				Lua_GameFramework_GeneralOperationResult.reg,
				Lua_GameFramework_StoryListenFlagEnum.reg,
				Lua_GameFramework_StoryListenFlagUtility.reg,
				Lua_GameFramework_EntityInfo.reg,
				Lua_GameFramework_EntityInfo_AttackerInfo.reg,
				Lua_GameFramework_CombatStatisticInfo.reg,
				Lua_GameFramework_KdTreeObject.reg,
				Lua_GameFramework_KdObjectTree.reg,
				Lua_GameFramework_MovementStateInfo.reg,
				Lua_GameFramework_CampIdEnum.reg,
				Lua_GameFramework_CharacterRelation.reg,
				Lua_GameFramework_CharacterPropertyEnum.reg,
				Lua_GameFramework_CharacterStateUtility.reg,
				Lua_GameFramework_CalculatorCommandInfo.reg,
				Lua_GameFramework_CharacterProperty.reg,
				Lua_GameFramework_EntityManager.reg,
				Lua_GameFramework_EntityTypeEnum.reg,
				Lua_GameFramework_DropEntityTypeEnum.reg,
				Lua_GameFramework_SceneContextInfo.reg,
				Lua_GameFramework_SceneLogicInfoManager.reg,
				Lua_GameFramework_SceneLogicConfig.reg,
				Lua_GameFramework_SceneLogicId.reg,
				Lua_GameFramework_SceneLogicInfo.reg,
				Lua_GameFramework_TimeoutLogicInfo.reg,
				Lua_GameFramework_SandClockLogicInfo.reg,
				Lua_GameFramework_BlackBoard.reg,
				Lua_GameFramework_SceneOperationResultEnum.reg,
				Lua_GameFramework_SceneTypeEnum.reg,
				Lua_GameFramework_ImpactInfo.reg,
				Lua_GameFramework_SkillOrImpactType.reg,
				Lua_GameFramework_SkillTargetType.reg,
				Lua_GameFramework_SkillAoeType.reg,
				Lua_GameFramework_SkillInfo.reg,
				Lua_GameFramework_SkillStateInfo.reg,
				Lua_TableConfig_Actor.reg,
				Lua_TableConfig_ActorProvider.reg,
				Lua_TableConfig_AttrDefine.reg,
				Lua_TableConfig_AttrDefineProvider.reg,
				Lua_TableConfig_Const.reg,
				Lua_TableConfig_ConstProvider.reg,
				Lua_TableConfig_Formation.reg,
				Lua_TableConfig_Formation_PosDir.reg,
				Lua_TableConfig_FormationProvider.reg,
				Lua_TableConfig_ImpactData.reg,
				Lua_TableConfig_ImpactDataProvider.reg,
				Lua_TableConfig_Level.reg,
				Lua_TableConfig_LevelProvider.reg,
				Lua_TableConfig_LevelMonster.reg,
				Lua_TableConfig_LevelMonsterProvider.reg,
				Lua_TableConfig_Skill.reg,
				Lua_TableConfig_SkillProvider.reg,
				Lua_TableConfig_SkillData.reg,
				Lua_TableConfig_SkillDataProvider.reg,
				Lua_TableConfig_SkillEvent.reg,
				Lua_TableConfig_SkillEventProvider.reg,
				Lua_TableConfig_SkillResources.reg,
				Lua_TableConfig_SkillResourcesProvider.reg,
				Lua_TableConfig_StoryDlg.reg,
				Lua_TableConfig_StoryDlgProvider.reg,
				Lua_TableConfig_StrDictionary.reg,
				Lua_TableConfig_StrDictionaryProvider.reg,
				Lua_TableConfig_UI.reg,
				Lua_TableConfig_UIProvider.reg,
				Lua_TableConfig_UserScript.reg,
				Lua_TableConfig_UserScriptProvider.reg,
				Lua_TableConfig_SkillDamageData.reg,
				Lua_FilePathDefine_Client.reg,
				Lua_FilePathDefine_Server.reg,
				Lua_GameFramework_TableConfigUtility.reg,
				Lua_ScriptRuntime_BoundingBox.reg,
				Lua_ScriptRuntime_BoundingFrustum.reg,
				Lua_ScriptRuntime_BoundingSphere.reg,
				Lua_ScriptRuntime_ClipStatus.reg,
				Lua_ScriptRuntime_Color32.reg,
				Lua_ScriptRuntime_ColorF.reg,
				Lua_ScriptRuntime_MathHelper.reg,
				Lua_ScriptRuntime_Matrix44.reg,
				Lua_ScriptRuntime_Plane.reg,
				Lua_ScriptRuntime_PlaneIntersectionStatus.reg,
				Lua_ScriptRuntime_Quaternion.reg,
				Lua_ScriptRuntime_Ray.reg,
				Lua_ScriptRuntime_Vector2.reg,
				Lua_ScriptRuntime_Vector3.reg,
				Lua_ScriptRuntime_Vector4.reg,
				Lua_SkillSystem_IPropertyVisitor.reg,
				Lua_SkillSystem_IProperty.reg,
				Lua_SkillSystem_IPropertyAccessor.reg,
				Lua_SkillSystem_PropertyAccessorHelper.reg,
				Lua_SkillSystem_ISkillTriger.reg,
				Lua_SkillSystem_DummyTriger.reg,
				Lua_SkillSystem_SkillTriggerProxy.reg,
				Lua_SkillSystem_SkillParamUtility.reg,
				Lua_SkillSystem_SkillResourceParam.reg,
				Lua_SkillSystem_SkillStringParam.reg,
				Lua_SkillSystem_SkillIntParam.reg,
				Lua_SkillSystem_SkillLongParam.reg,
				Lua_SkillSystem_SkillFloatParam.reg,
				Lua_SkillSystem_SkillDoubleParam.reg,
				Lua_SkillSystem_SkillObjectParam.reg,
				Lua_SkillSystem_ISkillTrigerFactory.reg,
				Lua_SkillSystem_SkillConfigManager.reg,
				Lua_SkillSystem_IntSkillInstanceDict.reg,
				Lua_SkillSystem_SkillSection.reg,
				Lua_SkillSystem_SkillMessageHandler.reg,
				Lua_SkillSystem_InplaceSkillPropertyInfo.reg,
				Lua_SkillSystem_SkillInstance.reg,
				Lua_SkillSystem_SkillTrigerManager.reg,
				Lua_StorySystem_CustomCommandValueParser.reg,
				Lua_StorySystem_IStoryCommand.reg,
				Lua_StorySystem_AbstractStoryCommand.reg,
				Lua_StorySystem_IStoryCommandFactory.reg,
				Lua_StorySystem_CommonCommands_DummyCommand.reg,
				Lua_StorySystem_IStoryValueFactory.reg,
				Lua_StorySystem_CommonValues_DummyValue.reg,
				Lua_StorySystem_IStoryValue.reg,
				Lua_StorySystem_StoryValue.reg,
				Lua_StorySystem_StoryCommandManager.reg,
				Lua_StorySystem_StoryConfigManager.reg,
				Lua_StorySystem_StoryMessageHandler.reg,
				Lua_StorySystem_StoryInstance.reg,
				Lua_StorySystem_StoryValueHelper.reg,
				Lua_StorySystem_StoryValueResult.reg,
				Lua_StorySystem_IStoryValueParam.reg,
				Lua_StorySystem_StoryValueParam.reg,
				Lua_StorySystem_StoryValueParams.reg,
				Lua_StorySystem_StoryValueManager.reg,
			};
			return list;
		}
	}
}
