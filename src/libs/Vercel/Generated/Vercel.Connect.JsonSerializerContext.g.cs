
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.ConnectCreateConnectorRequestTriggerDestinationDefaultDeployment, global::Vercel.ConnectCreateConnectorRequestTriggerDestinationBranch, global::Vercel.ConnectCreateConnectorRequestTriggerDestinationCustomEnvironment>), TypeInfoPropertyName = "ConnectCreateConnectorRequestTriggerDestinationCustomEnvironment_9bd60b1c152f3fcb")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AnyOf<global::Vercel.GetConnectorTokenRequestSubjectTypeApp, global::Vercel.GetConnectorTokenRequestSubjectTypeUser, global::Vercel.GetConnectorTokenRequestSubjectTypeJwtBearer, global::Vercel.GetConnectorTokenRequestSubjectTypeToken, global::Vercel.GetConnectorTokenRequestSubjectTypeOther>), TypeInfoPropertyName = "GetConnectorTokenRequestSubjectTypeOther_ebabd7c849c6ee3f")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AnyOf<global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeApp, global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeUser, global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeJwtBearer, global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeToken, global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeOther>), TypeInfoPropertyName = "CreateConnectorAuthorizationRequestRequestSubjectTypeOther_0339f7bb6dad496f")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.ConnectCreateConnectorRequestTriggerDestinationDefaultDeployment, global::Vercel.ConnectCreateConnectorRequestTriggerDestinationBranch, global::Vercel.ConnectCreateConnectorRequestTriggerDestinationCustomEnvironment>?), TypeInfoPropertyName = "ConnectCreateConnectorRequestTriggerDestinationCustomEnvironment_2fb5011fd0044493")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AnyOf<global::Vercel.GetConnectorTokenRequestSubjectTypeApp, global::Vercel.GetConnectorTokenRequestSubjectTypeUser, global::Vercel.GetConnectorTokenRequestSubjectTypeJwtBearer, global::Vercel.GetConnectorTokenRequestSubjectTypeToken, global::Vercel.GetConnectorTokenRequestSubjectTypeOther>?), TypeInfoPropertyName = "GetConnectorTokenRequestSubjectTypeOther_d34ea1913f9b5b00")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AnyOf<global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeApp, global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeUser, global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeJwtBearer, global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeToken, global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeOther>?), TypeInfoPropertyName = "CreateConnectorAuthorizationRequestRequestSubjectTypeOther_2b6d60932389a9b1")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectTriggerDestination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectTriggerConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnector))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorAppTokens))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.ConnectConnectorCreatedByVariant1, global::Vercel.ConnectConnectorCreatedByVariant2>), TypeInfoPropertyName = "OneOfConnectConnectorCreatedByVariant1ConnectConnectorCreatedByVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreatedByVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreatedByVariant1Type), TypeInfoPropertyName = "ConnectConnectorCreatedByVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreatedByVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.ConnectConnectorCreatedByVariant2Environment?>), TypeInfoPropertyName = "OneOfStringConnectConnectorCreatedByVariant2Environment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreatedByVariant2Environment), TypeInfoPropertyName = "ConnectConnectorCreatedByVariant2Environment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreatedByVariant2Type), TypeInfoPropertyName = "ConnectConnectorCreatedByVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreationMode), TypeInfoPropertyName = "ConnectConnectorCreationMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorManaged))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorSupportsIcon), TypeInfoPropertyName = "ConnectConnectorSupportsIcon2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.ConnectTriggerDestination>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorType), TypeInfoPropertyName = "ConnectConnectorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.ConnectConnectorUpdatedByVariant1, global::Vercel.ConnectConnectorUpdatedByVariant2>), TypeInfoPropertyName = "OneOfConnectConnectorUpdatedByVariant1ConnectConnectorUpdatedByVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUpdatedByVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUpdatedByVariant1Type), TypeInfoPropertyName = "ConnectConnectorUpdatedByVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUpdatedByVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.ConnectConnectorUpdatedByVariant2Environment?>), TypeInfoPropertyName = "OneOfStringConnectConnectorUpdatedByVariant2Environment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUpdatedByVariant2Environment), TypeInfoPropertyName = "ConnectConnectorUpdatedByVariant2Environment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUpdatedByVariant2Type), TypeInfoPropertyName = "ConnectConnectorUpdatedByVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUserTokens))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectPagination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.ConnectConnector>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateResultAppTokens))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.ConnectConnectorCreateResultCreatedByVariant1, global::Vercel.ConnectConnectorCreateResultCreatedByVariant2>), TypeInfoPropertyName = "OneOfConnectConnectorCreateResultCreatedByVariant1ConnectConnectorCreateResultCreatedByVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateResultCreatedByVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateResultCreatedByVariant1Type), TypeInfoPropertyName = "ConnectConnectorCreateResultCreatedByVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateResultCreatedByVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.CreatedByEnvironment?>), TypeInfoPropertyName = "OneOfStringCreatedByEnvironment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreatedByEnvironment), TypeInfoPropertyName = "CreatedByEnvironment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateResultCreatedByVariant2Type), TypeInfoPropertyName = "ConnectConnectorCreateResultCreatedByVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateResultCreationMode), TypeInfoPropertyName = "ConnectConnectorCreateResultCreationMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateResultManaged))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateResultSupportsIcon), TypeInfoPropertyName = "ConnectConnectorCreateResultSupportsIcon2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateResultType), TypeInfoPropertyName = "ConnectConnectorCreateResultType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.ConnectConnectorCreateResultUpdatedByVariant1, global::Vercel.ConnectConnectorCreateResultUpdatedByVariant2>), TypeInfoPropertyName = "OneOfConnectConnectorCreateResultUpdatedByVariant1ConnectConnectorCreateResultUpdatedByVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateResultUpdatedByVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateResultUpdatedByVariant1Type), TypeInfoPropertyName = "ConnectConnectorCreateResultUpdatedByVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateResultUpdatedByVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.UpdatedByEnvironment?>), TypeInfoPropertyName = "OneOfStringUpdatedByEnvironment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdatedByEnvironment), TypeInfoPropertyName = "UpdatedByEnvironment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateResultUpdatedByVariant2Type), TypeInfoPropertyName = "ConnectConnectorCreateResultUpdatedByVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateResultUserTokens))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateData), TypeInfoPropertyName = "ConnectConnectorCreateData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateDataTypeOauth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKSharedd059cb0ee80bd86d))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateDataTypeOauthUserAuthorization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateDataTypeOauthRefreshTokens))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateDataTypeOauthClientCredentials))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateDataTypeOauthForwardedClaims))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateDataTypeOauthJwtBearer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateDataTypeOauthClientAssertion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateDataTypeApiKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateDataTypeApiKeySubjectType), TypeInfoPropertyName = "ConnectConnectorCreateDataTypeApiKeySubjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.ConnectConnectorCreateDataTypeApiKeyValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateDataTypeApiKeyValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateDataTypeGithub))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateDataTypeGithubOwner))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateDataTypeGithubOwnerType), TypeInfoPropertyName = "ConnectConnectorCreateDataTypeGithubOwnerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateDataTypeLinear))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateDataTypeLinearOwnerOrganization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateDataTypeLinearApplication))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateDataTypeLinq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateDataTypeSalesforce))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateDataTypeSendblue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateDataTypeSlack))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateDataTypeSlackSlackTeam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.ConnectConnectorCreateDataTypeSlackSlashCommand>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateDataTypeSlackSlashCommand))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.ConnectConnectorCreateDataTypeSlackShortcut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateDataTypeSlackShortcut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateDataTypeSlackShortcutType), TypeInfoPropertyName = "ConnectConnectorCreateDataTypeSlackShortcutType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateDataTypeSnowflake))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateDataTypeSnowflakeWif))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateDataTypePhoton))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectCreateConnectorRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.AnyOf<global::Vercel.ConnectCreateConnectorRequestEnvironment?, string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AnyOf<global::Vercel.ConnectCreateConnectorRequestEnvironment?, string>), TypeInfoPropertyName = "AnyOfConnectCreateConnectorRequestEnvironmentString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectCreateConnectorRequestEnvironment), TypeInfoPropertyName = "ConnectCreateConnectorRequestEnvironment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectCreateConnectorRequestTriggerDestinationDefaultDeployment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectCreateConnectorRequestTriggerDestinationBranch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectCreateConnectorRequestTriggerDestinationCustomEnvironment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectReconsent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectReconsentScope), TypeInfoPropertyName = "ConnectReconsentScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectServiceSyncError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectServiceSync))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.ConnectServiceSyncError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectServiceSyncStatus), TypeInfoPropertyName = "ConnectServiceSyncStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUpdateResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUpdateData), TypeInfoPropertyName = "ConnectConnectorUpdateData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUpdateDataTypeOauth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUpdateDataTypeOauthUserAuthorization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUpdateDataTypeOauthRefreshTokens))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUpdateDataTypeOauthClientCredentials))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUpdateDataTypeOauthForwardedClaims))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUpdateDataTypeOauthJwtBearer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUpdateDataTypeOauthClientAssertion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUpdateDataTypeApiKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.ConnectConnectorUpdateDataTypeApiKeyToAddItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUpdateDataTypeApiKeyToAddItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.ConnectConnectorUpdateDataTypeApiKeyToUpdateItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUpdateDataTypeApiKeyToUpdateItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AnyOf<int?, string>), TypeInfoPropertyName = "AnyOfInt32String2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUpdateDataTypeGithub))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUpdateDataTypeGithubOwner))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUpdateDataTypeGithubOwnerType), TypeInfoPropertyName = "ConnectConnectorUpdateDataTypeGithubOwnerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUpdateDataTypeLinear))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUpdateDataTypeLinearOwnerOrganization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUpdateDataTypeLinearApplication))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUpdateDataTypeSalesforce))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUpdateDataTypeSlack))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUpdateDataTypeSlackSlackTeam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.ConnectConnectorUpdateDataTypeSlackSlashCommand>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUpdateDataTypeSlackSlashCommand))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.ConnectConnectorUpdateDataTypeSlackShortcut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUpdateDataTypeSlackShortcut))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUpdateDataTypeSlackShortcutType), TypeInfoPropertyName = "ConnectConnectorUpdateDataTypeSlackShortcutType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKSharedd059cb0ee80bd86dJwks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedd059cb0ee80bd86dJwksKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKSharedd059cb0ee80bd86dJwksKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKSharedd059cb0ee80bd86dJwksKeyUse), TypeInfoPropertyName = "AutoSDKSharedd059cb0ee80bd86dJwksKeyUse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetConnectorTokenRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetConnectorTokenRequestSubjectTypeApp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetConnectorTokenRequestSubjectTypeAppType), TypeInfoPropertyName = "GetConnectorTokenRequestSubjectTypeAppType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetConnectorTokenRequestSubjectTypeUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetConnectorTokenRequestSubjectTypeUserType), TypeInfoPropertyName = "GetConnectorTokenRequestSubjectTypeUserType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetConnectorTokenRequestSubjectTypeJwtBearer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetConnectorTokenRequestSubjectTypeJwtBearerType), TypeInfoPropertyName = "GetConnectorTokenRequestSubjectTypeJwtBearerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetConnectorTokenRequestSubjectTypeToken))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetConnectorTokenRequestSubjectTypeTokenType), TypeInfoPropertyName = "GetConnectorTokenRequestSubjectTypeTokenType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetConnectorTokenRequestSubjectTypeOther))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.GetConnectorTokenRequestAuthorizationDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetConnectorTokenRequestAuthorizationDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateConnectorAuthorizationRequestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeApp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeAppType), TypeInfoPropertyName = "CreateConnectorAuthorizationRequestRequestSubjectTypeAppType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeUserType), TypeInfoPropertyName = "CreateConnectorAuthorizationRequestRequestSubjectTypeUserType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeJwtBearer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeJwtBearerType), TypeInfoPropertyName = "CreateConnectorAuthorizationRequestRequestSubjectTypeJwtBearerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeToken))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeTokenType), TypeInfoPropertyName = "CreateConnectorAuthorizationRequestRequestSubjectTypeTokenType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeOther))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.CreateConnectorAuthorizationRequestRequestAuthorizationDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateConnectorAuthorizationRequestRequestAuthorizationDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListConnectorsSort), TypeInfoPropertyName = "ListConnectorsSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetConnectorTokenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetConnectorTokenResponseConnector))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateConnectorAuthorizationRequestResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateConnectorAuthorizationRequestResponseConnector))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.ConnectConnectorCreatedByVariant1, global::Vercel.ConnectConnectorCreatedByVariant2>?), TypeInfoPropertyName = "NullableOneOfConnectConnectorCreatedByVariant1ConnectConnectorCreatedByVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreatedByVariant1Type?), TypeInfoPropertyName = "NullableConnectConnectorCreatedByVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.ConnectConnectorCreatedByVariant2Environment?>?), TypeInfoPropertyName = "NullableOneOfStringConnectConnectorCreatedByVariant2Environment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreatedByVariant2Environment?), TypeInfoPropertyName = "NullableConnectConnectorCreatedByVariant2Environment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreatedByVariant2Type?), TypeInfoPropertyName = "NullableConnectConnectorCreatedByVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreationMode?), TypeInfoPropertyName = "NullableConnectConnectorCreationMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorSupportsIcon?), TypeInfoPropertyName = "NullableConnectConnectorSupportsIcon2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorType?), TypeInfoPropertyName = "NullableConnectConnectorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.ConnectConnectorUpdatedByVariant1, global::Vercel.ConnectConnectorUpdatedByVariant2>?), TypeInfoPropertyName = "NullableOneOfConnectConnectorUpdatedByVariant1ConnectConnectorUpdatedByVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUpdatedByVariant1Type?), TypeInfoPropertyName = "NullableConnectConnectorUpdatedByVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.ConnectConnectorUpdatedByVariant2Environment?>?), TypeInfoPropertyName = "NullableOneOfStringConnectConnectorUpdatedByVariant2Environment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUpdatedByVariant2Environment?), TypeInfoPropertyName = "NullableConnectConnectorUpdatedByVariant2Environment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUpdatedByVariant2Type?), TypeInfoPropertyName = "NullableConnectConnectorUpdatedByVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.ConnectConnectorCreateResultCreatedByVariant1, global::Vercel.ConnectConnectorCreateResultCreatedByVariant2>?), TypeInfoPropertyName = "NullableOneOfConnectConnectorCreateResultCreatedByVariant1ConnectConnectorCreateResultCreatedByVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateResultCreatedByVariant1Type?), TypeInfoPropertyName = "NullableConnectConnectorCreateResultCreatedByVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.CreatedByEnvironment?>?), TypeInfoPropertyName = "NullableOneOfStringCreatedByEnvironment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreatedByEnvironment?), TypeInfoPropertyName = "NullableCreatedByEnvironment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateResultCreatedByVariant2Type?), TypeInfoPropertyName = "NullableConnectConnectorCreateResultCreatedByVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateResultCreationMode?), TypeInfoPropertyName = "NullableConnectConnectorCreateResultCreationMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateResultSupportsIcon?), TypeInfoPropertyName = "NullableConnectConnectorCreateResultSupportsIcon2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateResultType?), TypeInfoPropertyName = "NullableConnectConnectorCreateResultType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.ConnectConnectorCreateResultUpdatedByVariant1, global::Vercel.ConnectConnectorCreateResultUpdatedByVariant2>?), TypeInfoPropertyName = "NullableOneOfConnectConnectorCreateResultUpdatedByVariant1ConnectConnectorCreateResultUpdatedByVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateResultUpdatedByVariant1Type?), TypeInfoPropertyName = "NullableConnectConnectorCreateResultUpdatedByVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.UpdatedByEnvironment?>?), TypeInfoPropertyName = "NullableOneOfStringUpdatedByEnvironment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdatedByEnvironment?), TypeInfoPropertyName = "NullableUpdatedByEnvironment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateResultUpdatedByVariant2Type?), TypeInfoPropertyName = "NullableConnectConnectorCreateResultUpdatedByVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateData?), TypeInfoPropertyName = "NullableConnectConnectorCreateData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateDataTypeApiKeySubjectType?), TypeInfoPropertyName = "NullableConnectConnectorCreateDataTypeApiKeySubjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateDataTypeGithubOwnerType?), TypeInfoPropertyName = "NullableConnectConnectorCreateDataTypeGithubOwnerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorCreateDataTypeSlackShortcutType?), TypeInfoPropertyName = "NullableConnectConnectorCreateDataTypeSlackShortcutType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AnyOf<global::Vercel.ConnectCreateConnectorRequestEnvironment?, string>?), TypeInfoPropertyName = "NullableAnyOfConnectCreateConnectorRequestEnvironmentString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectCreateConnectorRequestEnvironment?), TypeInfoPropertyName = "NullableConnectCreateConnectorRequestEnvironment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectReconsentScope?), TypeInfoPropertyName = "NullableConnectReconsentScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectServiceSyncStatus?), TypeInfoPropertyName = "NullableConnectServiceSyncStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUpdateData?), TypeInfoPropertyName = "NullableConnectConnectorUpdateData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AnyOf<int?, string>?), TypeInfoPropertyName = "NullableAnyOfInt32String2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUpdateDataTypeGithubOwnerType?), TypeInfoPropertyName = "NullableConnectConnectorUpdateDataTypeGithubOwnerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectConnectorUpdateDataTypeSlackShortcutType?), TypeInfoPropertyName = "NullableConnectConnectorUpdateDataTypeSlackShortcutType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectTriggerDestinationInput?), TypeInfoPropertyName = "NullableConnectTriggerDestinationInput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.ConnectProjectConnectionEnabledEnvironment?>?), TypeInfoPropertyName = "NullableOneOfStringConnectProjectConnectionEnabledEnvironment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectProjectConnectionEnabledEnvironment?), TypeInfoPropertyName = "NullableConnectProjectConnectionEnabledEnvironment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AnyOf<global::Vercel.ConnectUpsertProjectConnectionRequestEnvironment?, string>?), TypeInfoPropertyName = "NullableAnyOfConnectUpsertProjectConnectionRequestEnvironmentString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ConnectUpsertProjectConnectionRequestEnvironment?), TypeInfoPropertyName = "NullableConnectUpsertProjectConnectionRequestEnvironment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKSharedd059cb0ee80bd86dJwksKeyUse?), TypeInfoPropertyName = "NullableAutoSDKSharedd059cb0ee80bd86dJwksKeyUse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetConnectorTokenRequestSubjectTypeAppType?), TypeInfoPropertyName = "NullableGetConnectorTokenRequestSubjectTypeAppType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetConnectorTokenRequestSubjectTypeUserType?), TypeInfoPropertyName = "NullableGetConnectorTokenRequestSubjectTypeUserType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetConnectorTokenRequestSubjectTypeJwtBearerType?), TypeInfoPropertyName = "NullableGetConnectorTokenRequestSubjectTypeJwtBearerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetConnectorTokenRequestSubjectTypeTokenType?), TypeInfoPropertyName = "NullableGetConnectorTokenRequestSubjectTypeTokenType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeAppType?), TypeInfoPropertyName = "NullableCreateConnectorAuthorizationRequestRequestSubjectTypeAppType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeUserType?), TypeInfoPropertyName = "NullableCreateConnectorAuthorizationRequestRequestSubjectTypeUserType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeJwtBearerType?), TypeInfoPropertyName = "NullableCreateConnectorAuthorizationRequestRequestSubjectTypeJwtBearerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeTokenType?), TypeInfoPropertyName = "NullableCreateConnectorAuthorizationRequestRequestSubjectTypeTokenType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListConnectorsSort?), TypeInfoPropertyName = "NullableListConnectorsSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.ConnectTriggerDestination>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.ConnectConnector>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.ConnectConnectorCreateDataTypeApiKeyValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.ConnectConnectorCreateDataTypeSlackSlashCommand>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.ConnectConnectorCreateDataTypeSlackShortcut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.AnyOf<global::Vercel.ConnectCreateConnectorRequestEnvironment?, string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.ConnectServiceSyncError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.ConnectConnectorUpdateDataTypeApiKeyToAddItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.ConnectConnectorUpdateDataTypeApiKeyToUpdateItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.ConnectConnectorUpdateDataTypeSlackSlashCommand>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.ConnectConnectorUpdateDataTypeSlackShortcut>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.ConnectTriggerDestinationInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.OneOf<string, global::Vercel.ConnectProjectConnectionEnabledEnvironment?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.ConnectProjectConnectionProjectCustomEnvironment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.ConnectProjectConnection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.AnyOf<global::Vercel.ConnectUpsertProjectConnectionRequestEnvironment?, string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.AutoSDKSharedd059cb0ee80bd86dJwksKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.GetConnectorTokenRequestAuthorizationDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.CreateConnectorAuthorizationRequestRequestAuthorizationDetail>))]
    internal sealed partial class ConnectSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConnectSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


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
            options.Converters.Add(new global::Vercel.JsonConverters.ConnectConnectorCreateDataJsonConverter());
            options.Converters.Add(new global::Vercel.JsonConverters.ConnectConnectorUpdateDataJsonConverter());
            options.Converters.Add(new global::Vercel.JsonConverters.ConnectTriggerDestinationInputJsonConverter());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.ConnectConnectorCreatedByVariant1, global::Vercel.ConnectConnectorCreatedByVariant2>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.ConnectConnectorCreatedByVariant2Environment?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.ConnectConnectorUpdatedByVariant1, global::Vercel.ConnectConnectorUpdatedByVariant2>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.ConnectConnectorUpdatedByVariant2Environment?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.ConnectConnectorCreateResultCreatedByVariant1, global::Vercel.ConnectConnectorCreateResultCreatedByVariant2>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.CreatedByEnvironment?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.ConnectConnectorCreateResultUpdatedByVariant1, global::Vercel.ConnectConnectorCreateResultUpdatedByVariant2>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.UpdatedByEnvironment?>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.ConnectCreateConnectorRequestEnvironment?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.ConnectCreateConnectorRequestTriggerDestinationDefaultDeployment, global::Vercel.ConnectCreateConnectorRequestTriggerDestinationBranch, global::Vercel.ConnectCreateConnectorRequestTriggerDestinationCustomEnvironment>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<int?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.ConnectProjectConnectionEnabledEnvironment?>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.ConnectUpsertProjectConnectionRequestEnvironment?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, object, global::System.Collections.Generic.IList<object>, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, object, global::System.Collections.Generic.IList<object>, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.GetConnectorTokenRequestSubjectTypeApp, global::Vercel.GetConnectorTokenRequestSubjectTypeUser, global::Vercel.GetConnectorTokenRequestSubjectTypeJwtBearer, global::Vercel.GetConnectorTokenRequestSubjectTypeToken, global::Vercel.GetConnectorTokenRequestSubjectTypeOther>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeApp, global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeUser, global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeJwtBearer, global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeToken, global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeOther>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<string, double?, bool?, object, global::System.Collections.Generic.IList<object>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<string, double?, bool?, object, global::System.Collections.Generic.IList<object>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, int?>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<double>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, object, global::System.Collections.Generic.IList<object>, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<double>, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<double>, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<double>, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.UnixTimestampJsonConverter());
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

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorCreatedByVariant2Environment)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorCreatedByVariant2Environment?)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorCreatedByVariant2Type)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorCreatedByVariant2Type?)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorCreationMode)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorCreationMode?)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorSupportsIcon)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorSupportsIcon?)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorType)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorType?)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorUpdatedByVariant1Type)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorUpdatedByVariant1Type?)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorUpdatedByVariant2Environment)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorUpdatedByVariant2Environment?)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorUpdatedByVariant2Type)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorUpdatedByVariant2Type?)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultCreatedByVariant1Type)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultCreatedByVariant1Type?)

                    || typeToConvert == typeof(global::Vercel.CreatedByEnvironment)

                    || typeToConvert == typeof(global::Vercel.CreatedByEnvironment?)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultCreatedByVariant2Type)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultCreatedByVariant2Type?)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultCreationMode)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultCreationMode?)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultSupportsIcon)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultSupportsIcon?)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultType)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultType?)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultUpdatedByVariant1Type)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultUpdatedByVariant1Type?)

                    || typeToConvert == typeof(global::Vercel.UpdatedByEnvironment)

                    || typeToConvert == typeof(global::Vercel.UpdatedByEnvironment?)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultUpdatedByVariant2Type)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultUpdatedByVariant2Type?)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorCreateDataTypeApiKeySubjectType)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorCreateDataTypeApiKeySubjectType?)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorCreateDataTypeGithubOwnerType)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorCreateDataTypeGithubOwnerType?)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorCreateDataTypeSlackShortcutType)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorCreateDataTypeSlackShortcutType?)

                    || typeToConvert == typeof(global::Vercel.ConnectCreateConnectorRequestEnvironment)

                    || typeToConvert == typeof(global::Vercel.ConnectCreateConnectorRequestEnvironment?)

                    || typeToConvert == typeof(global::Vercel.ConnectReconsentScope)

                    || typeToConvert == typeof(global::Vercel.ConnectReconsentScope?)

                    || typeToConvert == typeof(global::Vercel.ConnectServiceSyncStatus)

                    || typeToConvert == typeof(global::Vercel.ConnectServiceSyncStatus?)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorUpdateDataTypeGithubOwnerType)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorUpdateDataTypeGithubOwnerType?)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorUpdateDataTypeSlackShortcutType)

                    || typeToConvert == typeof(global::Vercel.ConnectConnectorUpdateDataTypeSlackShortcutType?)

                    || typeToConvert == typeof(global::Vercel.ConnectProjectConnectionEnabledEnvironment)

                    || typeToConvert == typeof(global::Vercel.ConnectProjectConnectionEnabledEnvironment?)

                    || typeToConvert == typeof(global::Vercel.ConnectUpsertProjectConnectionRequestEnvironment)

                    || typeToConvert == typeof(global::Vercel.ConnectUpsertProjectConnectionRequestEnvironment?)

                    || typeToConvert == typeof(global::Vercel.AutoSDKSharedd059cb0ee80bd86dJwksKeyUse)

                    || typeToConvert == typeof(global::Vercel.AutoSDKSharedd059cb0ee80bd86dJwksKeyUse?)

                    || typeToConvert == typeof(global::Vercel.GetConnectorTokenRequestSubjectTypeAppType)

                    || typeToConvert == typeof(global::Vercel.GetConnectorTokenRequestSubjectTypeAppType?)

                    || typeToConvert == typeof(global::Vercel.GetConnectorTokenRequestSubjectTypeUserType)

                    || typeToConvert == typeof(global::Vercel.GetConnectorTokenRequestSubjectTypeUserType?)

                    || typeToConvert == typeof(global::Vercel.GetConnectorTokenRequestSubjectTypeJwtBearerType)

                    || typeToConvert == typeof(global::Vercel.GetConnectorTokenRequestSubjectTypeJwtBearerType?)

                    || typeToConvert == typeof(global::Vercel.GetConnectorTokenRequestSubjectTypeTokenType)

                    || typeToConvert == typeof(global::Vercel.GetConnectorTokenRequestSubjectTypeTokenType?)

                    || typeToConvert == typeof(global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeAppType)

                    || typeToConvert == typeof(global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeAppType?)

                    || typeToConvert == typeof(global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeUserType)

                    || typeToConvert == typeof(global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeUserType?)

                    || typeToConvert == typeof(global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeJwtBearerType)

                    || typeToConvert == typeof(global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeJwtBearerType?)

                    || typeToConvert == typeof(global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeTokenType)

                    || typeToConvert == typeof(global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeTokenType?)

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

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorCreatedByVariant2Environment))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorCreatedByVariant2EnvironmentJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorCreatedByVariant2Environment?))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorCreatedByVariant2EnvironmentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorCreatedByVariant2Type))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorCreatedByVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorCreatedByVariant2Type?))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorCreatedByVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorCreationMode))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorCreationModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorCreationMode?))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorCreationModeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorUpdatedByVariant2Environment))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorUpdatedByVariant2EnvironmentJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorUpdatedByVariant2Environment?))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorUpdatedByVariant2EnvironmentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorUpdatedByVariant2Type))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorUpdatedByVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorUpdatedByVariant2Type?))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorUpdatedByVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultCreatedByVariant1Type))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorCreateResultCreatedByVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultCreatedByVariant1Type?))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorCreateResultCreatedByVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreatedByEnvironment))
                {
                    return new global::Vercel.JsonConverters.CreatedByEnvironmentJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreatedByEnvironment?))
                {
                    return new global::Vercel.JsonConverters.CreatedByEnvironmentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultCreatedByVariant2Type))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorCreateResultCreatedByVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultCreatedByVariant2Type?))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorCreateResultCreatedByVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultCreationMode))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorCreateResultCreationModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultCreationMode?))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorCreateResultCreationModeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Vercel.UpdatedByEnvironment))
                {
                    return new global::Vercel.JsonConverters.UpdatedByEnvironmentJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpdatedByEnvironment?))
                {
                    return new global::Vercel.JsonConverters.UpdatedByEnvironmentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultUpdatedByVariant2Type))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorCreateResultUpdatedByVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorCreateResultUpdatedByVariant2Type?))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorCreateResultUpdatedByVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorCreateDataTypeApiKeySubjectType))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorCreateDataTypeApiKeySubjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorCreateDataTypeApiKeySubjectType?))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorCreateDataTypeApiKeySubjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorCreateDataTypeGithubOwnerType))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorCreateDataTypeGithubOwnerTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorCreateDataTypeGithubOwnerType?))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorCreateDataTypeGithubOwnerTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorCreateDataTypeSlackShortcutType))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorCreateDataTypeSlackShortcutTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorCreateDataTypeSlackShortcutType?))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorCreateDataTypeSlackShortcutTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectCreateConnectorRequestEnvironment))
                {
                    return new global::Vercel.JsonConverters.ConnectCreateConnectorRequestEnvironmentJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectCreateConnectorRequestEnvironment?))
                {
                    return new global::Vercel.JsonConverters.ConnectCreateConnectorRequestEnvironmentNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorUpdateDataTypeGithubOwnerType))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorUpdateDataTypeGithubOwnerTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorUpdateDataTypeGithubOwnerType?))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorUpdateDataTypeGithubOwnerTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorUpdateDataTypeSlackShortcutType))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorUpdateDataTypeSlackShortcutTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ConnectConnectorUpdateDataTypeSlackShortcutType?))
                {
                    return new global::Vercel.JsonConverters.ConnectConnectorUpdateDataTypeSlackShortcutTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Vercel.AutoSDKSharedd059cb0ee80bd86dJwksKeyUse))
                {
                    return new global::Vercel.JsonConverters.AutoSDKSharedd059cb0ee80bd86dJwksKeyUseJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AutoSDKSharedd059cb0ee80bd86dJwksKeyUse?))
                {
                    return new global::Vercel.JsonConverters.AutoSDKSharedd059cb0ee80bd86dJwksKeyUseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetConnectorTokenRequestSubjectTypeAppType))
                {
                    return new global::Vercel.JsonConverters.GetConnectorTokenRequestSubjectTypeAppTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetConnectorTokenRequestSubjectTypeAppType?))
                {
                    return new global::Vercel.JsonConverters.GetConnectorTokenRequestSubjectTypeAppTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetConnectorTokenRequestSubjectTypeUserType))
                {
                    return new global::Vercel.JsonConverters.GetConnectorTokenRequestSubjectTypeUserTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetConnectorTokenRequestSubjectTypeUserType?))
                {
                    return new global::Vercel.JsonConverters.GetConnectorTokenRequestSubjectTypeUserTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetConnectorTokenRequestSubjectTypeJwtBearerType))
                {
                    return new global::Vercel.JsonConverters.GetConnectorTokenRequestSubjectTypeJwtBearerTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetConnectorTokenRequestSubjectTypeJwtBearerType?))
                {
                    return new global::Vercel.JsonConverters.GetConnectorTokenRequestSubjectTypeJwtBearerTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetConnectorTokenRequestSubjectTypeTokenType))
                {
                    return new global::Vercel.JsonConverters.GetConnectorTokenRequestSubjectTypeTokenTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetConnectorTokenRequestSubjectTypeTokenType?))
                {
                    return new global::Vercel.JsonConverters.GetConnectorTokenRequestSubjectTypeTokenTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeAppType))
                {
                    return new global::Vercel.JsonConverters.CreateConnectorAuthorizationRequestRequestSubjectTypeAppTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeAppType?))
                {
                    return new global::Vercel.JsonConverters.CreateConnectorAuthorizationRequestRequestSubjectTypeAppTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeUserType))
                {
                    return new global::Vercel.JsonConverters.CreateConnectorAuthorizationRequestRequestSubjectTypeUserTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeUserType?))
                {
                    return new global::Vercel.JsonConverters.CreateConnectorAuthorizationRequestRequestSubjectTypeUserTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeJwtBearerType))
                {
                    return new global::Vercel.JsonConverters.CreateConnectorAuthorizationRequestRequestSubjectTypeJwtBearerTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeJwtBearerType?))
                {
                    return new global::Vercel.JsonConverters.CreateConnectorAuthorizationRequestRequestSubjectTypeJwtBearerTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeTokenType))
                {
                    return new global::Vercel.JsonConverters.CreateConnectorAuthorizationRequestRequestSubjectTypeTokenTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateConnectorAuthorizationRequestRequestSubjectTypeTokenType?))
                {
                    return new global::Vercel.JsonConverters.CreateConnectorAuthorizationRequestRequestSubjectTypeTokenTypeNullableJsonConverter();
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
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

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
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}