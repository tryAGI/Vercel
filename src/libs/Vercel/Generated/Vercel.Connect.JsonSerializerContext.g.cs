
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata
    )]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.ConnectConnectorCreateResultCreatedByVariant1, global::Vercel.ConnectConnectorCreateResultCreatedByVariant2, global::Vercel.ConnectConnectorCreateResultCreatedByVariant3>), TypeInfoPropertyName = "ConnectConnectorCreateResultCreatedByVariant3_86d7771f4b3e5f74")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.ConnectConnectorCreateResultUpdatedByVariant1, global::Vercel.ConnectConnectorCreateResultUpdatedByVariant2, global::Vercel.ConnectConnectorCreateResultUpdatedByVariant3>), TypeInfoPropertyName = "ConnectConnectorCreateResultUpdatedByVariant3_d1ea6c0faf76ca06")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.ConnectConnectorCreateResultCreatedByVariant1, global::Vercel.ConnectConnectorCreateResultCreatedByVariant2, global::Vercel.ConnectConnectorCreateResultCreatedByVariant3>?), TypeInfoPropertyName = "ConnectConnectorCreateResultCreatedByVariant3_58bd1c1396eb832b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.ConnectConnectorCreateResultUpdatedByVariant1, global::Vercel.ConnectConnectorCreateResultUpdatedByVariant2, global::Vercel.ConnectConnectorCreateResultUpdatedByVariant3>?), TypeInfoPropertyName = "ConnectConnectorCreateResultUpdatedByVariant3_0429955b8d5edbc1")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>), TypeInfoPropertyName = "DictionaryStringString_System_Collections_Generic_Dictionary_string_string")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectTriggerDestination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectTriggerConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnector))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorAppTokens))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.ConnectConnectorCreatedByVariant1, global::Vercel.ConnectConnectorCreatedByVariant2, global::Vercel.ConnectConnectorCreatedByVariant3>), TypeInfoPropertyName = "OneOfConnectConnectorCreatedByVariant1ConnectConnectorCreatedByVariant2ConnectConnectorCreatedByVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreatedByVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreatedByVariant1Type), TypeInfoPropertyName = "ConnectConnectorCreatedByVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreatedByVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreatedByVariant2Type), TypeInfoPropertyName = "ConnectConnectorCreatedByVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreatedByVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.ConnectConnectorCreatedByVariant3Environment?>), TypeInfoPropertyName = "OneOfStringConnectConnectorCreatedByVariant3Environment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreatedByVariant3Environment), TypeInfoPropertyName = "ConnectConnectorCreatedByVariant3Environment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreatedByVariant3Type), TypeInfoPropertyName = "ConnectConnectorCreatedByVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreationMode), TypeInfoPropertyName = "ConnectConnectorCreationMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorManaged))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorMcpEventsUiVisibility), TypeInfoPropertyName = "ConnectConnectorMcpEventsUiVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorSupportsIcon), TypeInfoPropertyName = "ConnectConnectorSupportsIcon2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.ConnectTriggerDestination>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorType), TypeInfoPropertyName = "ConnectConnectorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.ConnectConnectorUpdatedByVariant1, global::Vercel.ConnectConnectorUpdatedByVariant2, global::Vercel.ConnectConnectorUpdatedByVariant3>), TypeInfoPropertyName = "OneOfConnectConnectorUpdatedByVariant1ConnectConnectorUpdatedByVariant2ConnectConnectorUpdatedByVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUpdatedByVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUpdatedByVariant1Type), TypeInfoPropertyName = "ConnectConnectorUpdatedByVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUpdatedByVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUpdatedByVariant2Type), TypeInfoPropertyName = "ConnectConnectorUpdatedByVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUpdatedByVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.ConnectConnectorUpdatedByVariant3Environment?>), TypeInfoPropertyName = "OneOfStringConnectConnectorUpdatedByVariant3Environment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUpdatedByVariant3Environment), TypeInfoPropertyName = "ConnectConnectorUpdatedByVariant3Environment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUpdatedByVariant3Type), TypeInfoPropertyName = "ConnectConnectorUpdatedByVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUserTokens))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectPagination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.ConnectConnector>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateResultAppTokens))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateResultCreatedByVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateResultCreatedByVariant1Type), TypeInfoPropertyName = "ConnectConnectorCreateResultCreatedByVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateResultCreatedByVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateResultCreatedByVariant2Type), TypeInfoPropertyName = "ConnectConnectorCreateResultCreatedByVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateResultCreatedByVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.ConnectConnectorCreateResultCreatedByVariant3Environment?>), TypeInfoPropertyName = "OneOfStringConnectConnectorCreateResultCreatedByVariant3Environment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateResultCreatedByVariant3Environment), TypeInfoPropertyName = "ConnectConnectorCreateResultCreatedByVariant3Environment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateResultCreatedByVariant3Type), TypeInfoPropertyName = "ConnectConnectorCreateResultCreatedByVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateResultCreationMode), TypeInfoPropertyName = "ConnectConnectorCreateResultCreationMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateResultManaged))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateResultMcpEventsUiVisibility), TypeInfoPropertyName = "ConnectConnectorCreateResultMcpEventsUiVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateResultSupportsIcon), TypeInfoPropertyName = "ConnectConnectorCreateResultSupportsIcon2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateResultType), TypeInfoPropertyName = "ConnectConnectorCreateResultType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateResultUpdatedByVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateResultUpdatedByVariant1Type), TypeInfoPropertyName = "ConnectConnectorCreateResultUpdatedByVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateResultUpdatedByVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateResultUpdatedByVariant2Type), TypeInfoPropertyName = "ConnectConnectorCreateResultUpdatedByVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateResultUpdatedByVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.ConnectConnectorCreateResultUpdatedByVariant3Environment?>), TypeInfoPropertyName = "OneOfStringConnectConnectorCreateResultUpdatedByVariant3Environment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateResultUpdatedByVariant3Environment), TypeInfoPropertyName = "ConnectConnectorCreateResultUpdatedByVariant3Environment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateResultUpdatedByVariant3Type), TypeInfoPropertyName = "ConnectConnectorCreateResultUpdatedByVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateResultUserTokens))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateData), TypeInfoPropertyName = "ConnectConnectorCreateData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateDataTypeOauth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKShared448ea965c003fe05))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateDataTypeApiKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateDataTypeApiKeySubjectType), TypeInfoPropertyName = "ConnectConnectorCreateDataTypeApiKeySubjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.ConnectConnectorCreateDataTypeApiKeyValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateDataTypeApiKeyValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateDataTypeGithub))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateDataTypeLinear))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateDataTypeLinq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateDataTypeSalesforce))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateDataTypeSendblue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateDataTypeSlack))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateDataTypeSnowflake))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateDataTypeSnowflakeWif))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateDataTypePhoton))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectCreateConnectorRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectReconsent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectReconsentScope), TypeInfoPropertyName = "ConnectReconsentScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectServiceSyncError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectServiceSync))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.ConnectServiceSyncError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectServiceSyncStatus), TypeInfoPropertyName = "ConnectServiceSyncStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUpdateResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUpdateData), TypeInfoPropertyName = "ConnectConnectorUpdateData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUpdateDataTypeOauth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUpdateDataTypeApiKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.ConnectConnectorUpdateDataTypeApiKeyToAddItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUpdateDataTypeApiKeyToAddItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.ConnectConnectorUpdateDataTypeApiKeyToUpdateItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUpdateDataTypeApiKeyToUpdateItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUpdateDataTypeGithub))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUpdateDataTypeLinear))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUpdateDataTypeSalesforce))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUpdateDataTypeSlack))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUpdateDataTypeSnowflake))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUpdateDataTypeSnowflakeWif))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUpdateDataTypeLinq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUpdateDataTypeSendblue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUpdateDataTypePhoton))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectUpdateConnectorRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectTriggerDestinationInput), TypeInfoPropertyName = "ConnectTriggerDestinationInput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectTriggerDestinationInputDefaultDeployment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectTriggerDestinationInputBranch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectTriggerDestinationInputCustomEnvironment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectReplaceTriggerDestinationsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.ConnectTriggerDestinationInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectProjectConnection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.OneOf<string, global::Vercel.ConnectProjectConnectionEnabledEnvironment?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.ConnectProjectConnectionEnabledEnvironment?>), TypeInfoPropertyName = "OneOfStringConnectProjectConnectionEnabledEnvironment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectProjectConnectionEnabledEnvironment), TypeInfoPropertyName = "ConnectProjectConnectionEnabledEnvironment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectProjectConnectionProject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.ConnectProjectConnectionProjectCustomEnvironment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectProjectConnectionProjectCustomEnvironment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorProjectConnectionList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.ConnectProjectConnection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectUpsertProjectConnectionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.AnyOf<global::Vercel.ConnectUpsertProjectConnectionRequestEnvironment?, string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AnyOf<global::Vercel.ConnectUpsertProjectConnectionRequestEnvironment?, string>), TypeInfoPropertyName = "AnyOfConnectUpsertProjectConnectionRequestEnvironmentString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectUpsertProjectConnectionRequestEnvironment), TypeInfoPropertyName = "ConnectUpsertProjectConnectionRequestEnvironment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectProjectConnectorConnectionList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectErrorError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKShared448ea965c003fe05Jwks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared448ea965c003fe05JwksKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKShared448ea965c003fe05JwksKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKShared448ea965c003fe05JwksKeyUse), TypeInfoPropertyName = "AutoSDKShared448ea965c003fe05JwksKeyUse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetConnectorTokenRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateConnectorAuthorizationRequestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListConnectorsSort), TypeInfoPropertyName = "ListConnectorsSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetConnectorTokenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateConnectorAuthorizationRequestResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateConnectorAuthorizationRequestResponseConnector))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string?>), TypeInfoPropertyName = "DictionaryStringString_System_Collections_Generic_Dictionary_string_string_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.ConnectConnectorCreatedByVariant1, global::Vercel.ConnectConnectorCreatedByVariant2, global::Vercel.ConnectConnectorCreatedByVariant3>?), TypeInfoPropertyName = "NullableOneOfConnectConnectorCreatedByVariant1ConnectConnectorCreatedByVariant2ConnectConnectorCreatedByVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreatedByVariant1Type?), TypeInfoPropertyName = "NullableConnectConnectorCreatedByVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreatedByVariant2Type?), TypeInfoPropertyName = "NullableConnectConnectorCreatedByVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.ConnectConnectorCreatedByVariant3Environment?>?), TypeInfoPropertyName = "NullableOneOfStringConnectConnectorCreatedByVariant3Environment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreatedByVariant3Environment?), TypeInfoPropertyName = "NullableConnectConnectorCreatedByVariant3Environment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreatedByVariant3Type?), TypeInfoPropertyName = "NullableConnectConnectorCreatedByVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreationMode?), TypeInfoPropertyName = "NullableConnectConnectorCreationMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorMcpEventsUiVisibility?), TypeInfoPropertyName = "NullableConnectConnectorMcpEventsUiVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorSupportsIcon?), TypeInfoPropertyName = "NullableConnectConnectorSupportsIcon2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorType?), TypeInfoPropertyName = "NullableConnectConnectorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.ConnectConnectorUpdatedByVariant1, global::Vercel.ConnectConnectorUpdatedByVariant2, global::Vercel.ConnectConnectorUpdatedByVariant3>?), TypeInfoPropertyName = "NullableOneOfConnectConnectorUpdatedByVariant1ConnectConnectorUpdatedByVariant2ConnectConnectorUpdatedByVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUpdatedByVariant1Type?), TypeInfoPropertyName = "NullableConnectConnectorUpdatedByVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUpdatedByVariant2Type?), TypeInfoPropertyName = "NullableConnectConnectorUpdatedByVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.ConnectConnectorUpdatedByVariant3Environment?>?), TypeInfoPropertyName = "NullableOneOfStringConnectConnectorUpdatedByVariant3Environment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUpdatedByVariant3Environment?), TypeInfoPropertyName = "NullableConnectConnectorUpdatedByVariant3Environment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUpdatedByVariant3Type?), TypeInfoPropertyName = "NullableConnectConnectorUpdatedByVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateResultCreatedByVariant1Type?), TypeInfoPropertyName = "NullableConnectConnectorCreateResultCreatedByVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateResultCreatedByVariant2Type?), TypeInfoPropertyName = "NullableConnectConnectorCreateResultCreatedByVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.ConnectConnectorCreateResultCreatedByVariant3Environment?>?), TypeInfoPropertyName = "NullableOneOfStringConnectConnectorCreateResultCreatedByVariant3Environment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateResultCreatedByVariant3Environment?), TypeInfoPropertyName = "NullableConnectConnectorCreateResultCreatedByVariant3Environment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateResultCreatedByVariant3Type?), TypeInfoPropertyName = "NullableConnectConnectorCreateResultCreatedByVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateResultCreationMode?), TypeInfoPropertyName = "NullableConnectConnectorCreateResultCreationMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateResultMcpEventsUiVisibility?), TypeInfoPropertyName = "NullableConnectConnectorCreateResultMcpEventsUiVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateResultSupportsIcon?), TypeInfoPropertyName = "NullableConnectConnectorCreateResultSupportsIcon2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateResultType?), TypeInfoPropertyName = "NullableConnectConnectorCreateResultType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateResultUpdatedByVariant1Type?), TypeInfoPropertyName = "NullableConnectConnectorCreateResultUpdatedByVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateResultUpdatedByVariant2Type?), TypeInfoPropertyName = "NullableConnectConnectorCreateResultUpdatedByVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.ConnectConnectorCreateResultUpdatedByVariant3Environment?>?), TypeInfoPropertyName = "NullableOneOfStringConnectConnectorCreateResultUpdatedByVariant3Environment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateResultUpdatedByVariant3Environment?), TypeInfoPropertyName = "NullableConnectConnectorCreateResultUpdatedByVariant3Environment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateResultUpdatedByVariant3Type?), TypeInfoPropertyName = "NullableConnectConnectorCreateResultUpdatedByVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateData?), TypeInfoPropertyName = "NullableConnectConnectorCreateData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateDataTypeApiKeySubjectType?), TypeInfoPropertyName = "NullableConnectConnectorCreateDataTypeApiKeySubjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectReconsentScope?), TypeInfoPropertyName = "NullableConnectReconsentScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectServiceSyncStatus?), TypeInfoPropertyName = "NullableConnectServiceSyncStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUpdateData?), TypeInfoPropertyName = "NullableConnectConnectorUpdateData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectTriggerDestinationInput?), TypeInfoPropertyName = "NullableConnectTriggerDestinationInput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.ConnectProjectConnectionEnabledEnvironment?>?), TypeInfoPropertyName = "NullableOneOfStringConnectProjectConnectionEnabledEnvironment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectProjectConnectionEnabledEnvironment?), TypeInfoPropertyName = "NullableConnectProjectConnectionEnabledEnvironment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AnyOf<global::Vercel.ConnectUpsertProjectConnectionRequestEnvironment?, string>?), TypeInfoPropertyName = "NullableAnyOfConnectUpsertProjectConnectionRequestEnvironmentString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectUpsertProjectConnectionRequestEnvironment?), TypeInfoPropertyName = "NullableConnectUpsertProjectConnectionRequestEnvironment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKShared448ea965c003fe05JwksKeyUse?), TypeInfoPropertyName = "NullableAutoSDKShared448ea965c003fe05JwksKeyUse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListConnectorsSort?), TypeInfoPropertyName = "NullableListConnectorsSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.ConnectTriggerDestination>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.ConnectConnector>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.ConnectConnectorCreateDataTypeApiKeyValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.ConnectServiceSyncError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.ConnectConnectorUpdateDataTypeApiKeyToAddItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.ConnectConnectorUpdateDataTypeApiKeyToUpdateItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.ConnectTriggerDestinationInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.OneOf<string, global::Vercel.ConnectProjectConnectionEnabledEnvironment?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.ConnectProjectConnectionProjectCustomEnvironment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.ConnectProjectConnection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.AnyOf<global::Vercel.ConnectUpsertProjectConnectionRequestEnvironment?, string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.AutoSDKShared448ea965c003fe05JwksKey>))]
    internal sealed partial class ConnectSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConnectSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ConnectSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ConnectSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            global::Vercel.PartitionCoreSourceGenerationContext.AddConverters(options);
            options.Converters.Add(new global::Vercel.JsonConverters.ConnectConnectorCreateDataJsonConverter());
            options.Converters.Add(new global::Vercel.JsonConverters.ConnectConnectorUpdateDataJsonConverter());
            options.Converters.Add(new global::Vercel.JsonConverters.ConnectTriggerDestinationInputJsonConverter());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.ConnectConnectorCreatedByVariant1, global::Vercel.ConnectConnectorCreatedByVariant2, global::Vercel.ConnectConnectorCreatedByVariant3>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.ConnectConnectorCreatedByVariant3Environment?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.ConnectConnectorUpdatedByVariant1, global::Vercel.ConnectConnectorUpdatedByVariant2, global::Vercel.ConnectConnectorUpdatedByVariant3>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.ConnectConnectorUpdatedByVariant3Environment?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.ConnectConnectorCreateResultCreatedByVariant1, global::Vercel.ConnectConnectorCreateResultCreatedByVariant2, global::Vercel.ConnectConnectorCreateResultCreatedByVariant3>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.ConnectConnectorCreateResultCreatedByVariant3Environment?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.ConnectConnectorCreateResultUpdatedByVariant1, global::Vercel.ConnectConnectorCreateResultUpdatedByVariant2, global::Vercel.ConnectConnectorCreateResultUpdatedByVariant3>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.ConnectConnectorCreateResultUpdatedByVariant3Environment?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.ConnectProjectConnectionEnabledEnvironment?>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.ConnectUpsertProjectConnectionRequestEnvironment?, string>());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Vercel.ConnectConnectorCreatedByVariant1Type)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorCreatedByVariant1Type?)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorCreatedByVariant2Type)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorCreatedByVariant2Type?)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorCreatedByVariant3Environment)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorCreatedByVariant3Environment?)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorCreatedByVariant3Type)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorCreatedByVariant3Type?)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorCreationMode)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorCreationMode?)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorMcpEventsUiVisibility)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorMcpEventsUiVisibility?)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorSupportsIcon)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorSupportsIcon?)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorType)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorType?)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorUpdatedByVariant1Type)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorUpdatedByVariant1Type?)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorUpdatedByVariant2Type)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorUpdatedByVariant2Type?)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorUpdatedByVariant3Environment)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorUpdatedByVariant3Environment?)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorUpdatedByVariant3Type)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorUpdatedByVariant3Type?)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultCreatedByVariant1Type)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultCreatedByVariant1Type?)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultCreatedByVariant2Type)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultCreatedByVariant2Type?)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultCreatedByVariant3Environment)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultCreatedByVariant3Environment?)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultCreatedByVariant3Type)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultCreatedByVariant3Type?)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultCreationMode)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultCreationMode?)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultMcpEventsUiVisibility)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultMcpEventsUiVisibility?)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultSupportsIcon)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultSupportsIcon?)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultType)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultType?)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultUpdatedByVariant1Type)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultUpdatedByVariant1Type?)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultUpdatedByVariant2Type)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultUpdatedByVariant2Type?)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultUpdatedByVariant3Environment)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultUpdatedByVariant3Environment?)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultUpdatedByVariant3Type)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultUpdatedByVariant3Type?)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorCreateDataTypeApiKeySubjectType)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorCreateDataTypeApiKeySubjectType?)

                    || typeToConvert == typeof(global::Vercel.ConnectReconsentScope)

                    || typeToConvert == typeof(global::Vercel.ConnectReconsentScope?)

                    || typeToConvert == typeof(global::Vercel.ConnectServiceSyncStatus)

                    || typeToConvert == typeof(global::Vercel.ConnectServiceSyncStatus?)

                    || typeToConvert == typeof(global::Vercel.ConnectProjectConnectionEnabledEnvironment)

                    || typeToConvert == typeof(global::Vercel.ConnectProjectConnectionEnabledEnvironment?)

                    || typeToConvert == typeof(global::Vercel.ConnectUpsertProjectConnectionRequestEnvironment)

                    || typeToConvert == typeof(global::Vercel.ConnectUpsertProjectConnectionRequestEnvironment?)

                    || typeToConvert == typeof(global::Vercel.AutoSDKShared448ea965c003fe05JwksKeyUse)

                    || typeToConvert == typeof(global::Vercel.AutoSDKShared448ea965c003fe05JwksKeyUse?)

                    || typeToConvert == typeof(global::Vercel.ListConnectorsSort)

                    || typeToConvert == typeof(global::Vercel.ListConnectorsSort?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Vercel.ConnectConnectorCreatedByVariant1Type))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorCreatedByVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorCreatedByVariant1Type?))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorCreatedByVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorCreatedByVariant2Type))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorCreatedByVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorCreatedByVariant2Type?))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorCreatedByVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorCreatedByVariant3Environment))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorCreatedByVariant3EnvironmentJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorCreatedByVariant3Environment?))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorCreatedByVariant3EnvironmentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorCreatedByVariant3Type))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorCreatedByVariant3TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorCreatedByVariant3Type?))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorCreatedByVariant3TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorCreationMode))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorCreationModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorCreationMode?))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorCreationModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorMcpEventsUiVisibility))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorMcpEventsUiVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorMcpEventsUiVisibility?))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorMcpEventsUiVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorSupportsIcon))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorSupportsIconJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorSupportsIcon?))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorSupportsIconNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorType))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorType?))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorUpdatedByVariant1Type))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorUpdatedByVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorUpdatedByVariant1Type?))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorUpdatedByVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorUpdatedByVariant2Type))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorUpdatedByVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorUpdatedByVariant2Type?))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorUpdatedByVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorUpdatedByVariant3Environment))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorUpdatedByVariant3EnvironmentJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorUpdatedByVariant3Environment?))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorUpdatedByVariant3EnvironmentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorUpdatedByVariant3Type))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorUpdatedByVariant3TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorUpdatedByVariant3Type?))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorUpdatedByVariant3TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultCreatedByVariant1Type))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorCreateResultCreatedByVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultCreatedByVariant1Type?))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorCreateResultCreatedByVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultCreatedByVariant2Type))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorCreateResultCreatedByVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultCreatedByVariant2Type?))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorCreateResultCreatedByVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultCreatedByVariant3Environment))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorCreateResultCreatedByVariant3EnvironmentJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultCreatedByVariant3Environment?))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorCreateResultCreatedByVariant3EnvironmentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultCreatedByVariant3Type))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorCreateResultCreatedByVariant3TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultCreatedByVariant3Type?))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorCreateResultCreatedByVariant3TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultCreationMode))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorCreateResultCreationModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultCreationMode?))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorCreateResultCreationModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultMcpEventsUiVisibility))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorCreateResultMcpEventsUiVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultMcpEventsUiVisibility?))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorCreateResultMcpEventsUiVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultSupportsIcon))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorCreateResultSupportsIconJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultSupportsIcon?))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorCreateResultSupportsIconNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultType))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorCreateResultTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultType?))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorCreateResultTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultUpdatedByVariant1Type))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorCreateResultUpdatedByVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultUpdatedByVariant1Type?))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorCreateResultUpdatedByVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultUpdatedByVariant2Type))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorCreateResultUpdatedByVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultUpdatedByVariant2Type?))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorCreateResultUpdatedByVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultUpdatedByVariant3Environment))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorCreateResultUpdatedByVariant3EnvironmentJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultUpdatedByVariant3Environment?))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorCreateResultUpdatedByVariant3EnvironmentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultUpdatedByVariant3Type))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorCreateResultUpdatedByVariant3TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultUpdatedByVariant3Type?))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorCreateResultUpdatedByVariant3TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorCreateDataTypeApiKeySubjectType))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorCreateDataTypeApiKeySubjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorCreateDataTypeApiKeySubjectType?))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorCreateDataTypeApiKeySubjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectReconsentScope))
                {
                    return new global::Vercel.JsonConverters.ConnectReconsentScopeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectReconsentScope?))
                {
                    return new global::Vercel.JsonConverters.ConnectReconsentScopeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectServiceSyncStatus))
                {
                    return new global::Vercel.JsonConverters.ConnectServiceSyncStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectServiceSyncStatus?))
                {
                    return new global::Vercel.JsonConverters.ConnectServiceSyncStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectProjectConnectionEnabledEnvironment))
                {
                    return new global::Vercel.JsonConverters.ConnectProjectConnectionEnabledEnvironmentJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectProjectConnectionEnabledEnvironment?))
                {
                    return new global::Vercel.JsonConverters.ConnectProjectConnectionEnabledEnvironmentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectUpsertProjectConnectionRequestEnvironment))
                {
                    return new global::Vercel.JsonConverters.ConnectUpsertProjectConnectionRequestEnvironmentJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectUpsertProjectConnectionRequestEnvironment?))
                {
                    return new global::Vercel.JsonConverters.ConnectUpsertProjectConnectionRequestEnvironmentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AutoSDKShared448ea965c003fe05JwksKeyUse))
                {
                    return new global::Vercel.JsonConverters.AutoSDKShared448ea965c003fe05JwksKeyUseJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AutoSDKShared448ea965c003fe05JwksKeyUse?))
                {
                    return new global::Vercel.JsonConverters.AutoSDKShared448ea965c003fe05JwksKeyUseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ListConnectorsSort))
                {
                    return new global::Vercel.JsonConverters.ListConnectorsSortJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ListConnectorsSort?))
                {
                    return new global::Vercel.JsonConverters.ListConnectorsSortNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[2];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new ConnectSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => global::Vercel.PartitionCoreSourceGenerationContext.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}