
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GlobalConfigItemValue), TypeInfoPropertyName = "GlobalConfigItemValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Vercel.GlobalConfigItemValue?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.GlobalConfigItemValue?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateInstallationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateInstallationRequestStatus), TypeInfoPropertyName = "UpdateInstallationRequestStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateInstallationRequestBillingPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateInstallationRequestBillingPlanType), TypeInfoPropertyName = "UpdateInstallationRequestBillingPlanType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.UpdateInstallationRequestBillingPlanDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateInstallationRequestBillingPlanDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.UpdateInstallationRequestBillingPlanHighlightedDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateInstallationRequestBillingPlanHighlightedDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.UpdateInstallationRequestNotification, string>), TypeInfoPropertyName = "OneOfUpdateInstallationRequestNotificationString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateInstallationRequestNotification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateInstallationRequestNotificationLevel), TypeInfoPropertyName = "UpdateInstallationRequestNotificationLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.RotateInstallationCredentialRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.RevokeInstallationCredentialRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateEventRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.CreateEventRequestEventVariant1, global::Vercel.CreateEventRequestEventVariant2>), TypeInfoPropertyName = "OneOfCreateEventRequestEventVariant1CreateEventRequestEventVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateEventRequestEventVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateEventRequestEventVariant1Type), TypeInfoPropertyName = "CreateEventRequestEventVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateEventRequestEventVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateEventRequestEventVariant2Type), TypeInfoPropertyName = "CreateEventRequestEventVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ImportResourceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ImportResourceRequestOwnership), TypeInfoPropertyName = "ImportResourceRequestOwnership2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ImportResourceRequestStatus), TypeInfoPropertyName = "ImportResourceRequestStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ImportResourceRequestBillingPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ImportResourceRequestBillingPlanType), TypeInfoPropertyName = "ImportResourceRequestBillingPlanType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.ImportResourceRequestBillingPlanDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ImportResourceRequestBillingPlanDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.ImportResourceRequestBillingPlanHighlightedDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ImportResourceRequestBillingPlanHighlightedDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ImportResourceRequestNotification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ImportResourceRequestNotificationLevel), TypeInfoPropertyName = "ImportResourceRequestNotificationLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.ImportResourceRequestSecret>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ImportResourceRequestSecret))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ImportResourceRequestSecretEnvironmentOverrides))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateResourceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateResourceRequestOwnership), TypeInfoPropertyName = "UpdateResourceRequestOwnership2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateResourceRequestStatus), TypeInfoPropertyName = "UpdateResourceRequestStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateResourceRequestBillingPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateResourceRequestBillingPlanType), TypeInfoPropertyName = "UpdateResourceRequestBillingPlanType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.UpdateResourceRequestBillingPlanDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateResourceRequestBillingPlanDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.UpdateResourceRequestBillingPlanHighlightedDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateResourceRequestBillingPlanHighlightedDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.UpdateResourceRequestNotification, string>), TypeInfoPropertyName = "OneOfUpdateResourceRequestNotificationString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateResourceRequestNotification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateResourceRequestNotificationLevel), TypeInfoPropertyName = "UpdateResourceRequestNotificationLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::System.Collections.Generic.IList<global::Vercel.UpdateResourceRequestSecret>, global::Vercel.UpdateResourceRequestSecrets>), TypeInfoPropertyName = "OneOfIListUpdateResourceRequestSecretUpdateResourceRequestSecrets2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.UpdateResourceRequestSecret>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateResourceRequestSecret))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateResourceRequestSecretEnvironmentOverrides))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateResourceRequestSecrets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.UpdateResourceRequestSecretsSecret>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateResourceRequestSecretsSecret))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateResourceRequestSecretsSecretEnvironmentOverrides))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.SubmitBillingDataRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.SubmitBillingDataRequestPeriod))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::System.Collections.Generic.IList<global::Vercel.SubmitBillingDataRequestBillingItem>, global::Vercel.SubmitBillingDataRequestBilling>), TypeInfoPropertyName = "OneOfIListSubmitBillingDataRequestBillingItemSubmitBillingDataRequestBilling2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.SubmitBillingDataRequestBillingItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.SubmitBillingDataRequestBillingItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.SubmitBillingDataRequestBilling))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.SubmitBillingDataRequestBillingItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.SubmitBillingDataRequestBillingItem2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.SubmitBillingDataRequestBillingDiscount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.SubmitBillingDataRequestBillingDiscount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.SubmitBillingDataRequestUsageItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.SubmitBillingDataRequestUsageItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.SubmitBillingDataRequestUsageItemType), TypeInfoPropertyName = "SubmitBillingDataRequestUsageItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.SubmitInvoiceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.SubmitInvoiceRequestPeriod))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.SubmitInvoiceRequestItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.SubmitInvoiceRequestItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.SubmitInvoiceRequestDiscount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.SubmitInvoiceRequestDiscount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.SubmitInvoiceRequestTest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.SubmitInvoiceRequestTestResult), TypeInfoPropertyName = "SubmitInvoiceRequestTestResult2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateInvoiceRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateInvoiceRequestAction), TypeInfoPropertyName = "UpdateInvoiceRequestAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.SubmitPrepaymentBalancesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.SubmitPrepaymentBalancesRequestBalance>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.SubmitPrepaymentBalancesRequestBalance))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateResourceSecretsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.UpdateResourceSecretsRequestSecret>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateResourceSecretsRequestSecret))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateResourceSecretsRequestSecretEnvironmentOverrides))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateResourceSecretsByIdRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.UpdateResourceSecretsByIdRequestSecret>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateResourceSecretsByIdRequestSecret))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateResourceSecretsByIdRequestSecretEnvironmentOverrides))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.ExchangeSsoTokenRequestVariant1, global::Vercel.ExchangeSsoTokenRequestVariant2>), TypeInfoPropertyName = "OneOfExchangeSsoTokenRequestVariant1ExchangeSsoTokenRequestVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ExchangeSsoTokenRequestVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ExchangeSsoTokenRequestVariant1GrantType), TypeInfoPropertyName = "ExchangeSsoTokenRequestVariant1GrantType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ExchangeSsoTokenRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ExchangeSsoTokenRequestVariant2GrantType), TypeInfoPropertyName = "ExchangeSsoTokenRequestVariant2GrantType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.CreateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsRequestItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsRequestItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsRequestItemCategory), TypeInfoPropertyName = "CreateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsRequestItemCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsByItemIdRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsByItemIdRequestCategory), TypeInfoPropertyName = "UpdateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsByItemIdRequestCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ReplaceInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationGlobalConfigRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetAccountInfoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetAccountInfoResponseContact))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetMemberResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetMemberResponseRole), TypeInfoPropertyName = "GetMemberResponseRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.RotateInstallationCredentialResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.RotateInstallationCredentialResponseTokenType), TypeInfoPropertyName = "RotateInstallationCredentialResponseTokenType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.RevokeInstallationCredentialResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetIntegrationResourcesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.GetIntegrationResourcesResponseResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetIntegrationResourcesResponseResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, double?, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<double>, bool?>), TypeInfoPropertyName = "OneOfStringDoubleIListStringIListDoubleBoolean2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetIntegrationResourcesResponseResourceNotification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetIntegrationResourcesResponseResourceNotificationLevel), TypeInfoPropertyName = "GetIntegrationResourcesResponseResourceNotificationLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetIntegrationResourcesResponseResourceProtocolSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetIntegrationResourcesResponseResourceProtocolSettingsAuthentication))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.GetIntegrationResourcesResponseResourceProtocolSettingsAuthenticationAppUrl>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetIntegrationResourcesResponseResourceProtocolSettingsAuthenticationAppUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetIntegrationResourcesResponseResourceProtocolSettingsAuthenticationAppUrlTarget), TypeInfoPropertyName = "GetIntegrationResourcesResponseResourceProtocolSettingsAuthenticationAppUrlTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetIntegrationResourcesResponseResourceProtocolSettingsExperimentation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetIntegrationResourcesResponseResourceStatus), TypeInfoPropertyName = "GetIntegrationResourcesResponseResourceStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetIntegrationResourceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetIntegrationResourceResponseNotification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetIntegrationResourceResponseNotificationLevel), TypeInfoPropertyName = "GetIntegrationResourceResponseNotificationLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetIntegrationResourceResponseProtocolSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetIntegrationResourceResponseProtocolSettingsAuthentication))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.GetIntegrationResourceResponseProtocolSettingsAuthenticationAppUrl>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetIntegrationResourceResponseProtocolSettingsAuthenticationAppUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetIntegrationResourceResponseProtocolSettingsAuthenticationAppUrlTarget), TypeInfoPropertyName = "GetIntegrationResourceResponseProtocolSettingsAuthenticationAppUrlTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetIntegrationResourceResponseProtocolSettingsExperimentation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetIntegrationResourceResponseStatus), TypeInfoPropertyName = "GetIntegrationResourceResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ImportResourceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateResourceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.SubmitInvoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetInvoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.GetInvoiceResponseDiscount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetInvoiceResponseDiscount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.GetInvoiceResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetInvoiceResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetInvoiceResponsePeriod))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetInvoiceResponseState), TypeInfoPropertyName = "GetInvoiceResponseState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.ExchangeSsoTokenResponseVariant1, global::Vercel.ExchangeSsoTokenResponseVariant2>), TypeInfoPropertyName = "OneOfExchangeSsoTokenResponseVariant1ExchangeSsoTokenResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ExchangeSsoTokenResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ExchangeSsoTokenResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.HeadInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationGlobalConfigResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.HeadInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationGlobalConfigResponsePurpose), TypeInfoPropertyName = "HeadInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationGlobalConfigResponsePurpose2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationGlobalConfigResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationGlobalConfigResponsePurpose), TypeInfoPropertyName = "GetInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationGlobalConfigResponsePurpose2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ReplaceInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationGlobalConfigResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ReplaceInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationGlobalConfigResponsePurpose), TypeInfoPropertyName = "ReplaceInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationGlobalConfigResponsePurpose2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GlobalConfigItemValue?), TypeInfoPropertyName = "NullableGlobalConfigItemValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateInstallationRequestStatus?), TypeInfoPropertyName = "NullableUpdateInstallationRequestStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateInstallationRequestBillingPlanType?), TypeInfoPropertyName = "NullableUpdateInstallationRequestBillingPlanType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.UpdateInstallationRequestNotification, string>?), TypeInfoPropertyName = "NullableOneOfUpdateInstallationRequestNotificationString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateInstallationRequestNotificationLevel?), TypeInfoPropertyName = "NullableUpdateInstallationRequestNotificationLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.CreateEventRequestEventVariant1, global::Vercel.CreateEventRequestEventVariant2>?), TypeInfoPropertyName = "NullableOneOfCreateEventRequestEventVariant1CreateEventRequestEventVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateEventRequestEventVariant1Type?), TypeInfoPropertyName = "NullableCreateEventRequestEventVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateEventRequestEventVariant2Type?), TypeInfoPropertyName = "NullableCreateEventRequestEventVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ImportResourceRequestOwnership?), TypeInfoPropertyName = "NullableImportResourceRequestOwnership2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ImportResourceRequestStatus?), TypeInfoPropertyName = "NullableImportResourceRequestStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ImportResourceRequestBillingPlanType?), TypeInfoPropertyName = "NullableImportResourceRequestBillingPlanType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ImportResourceRequestNotificationLevel?), TypeInfoPropertyName = "NullableImportResourceRequestNotificationLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateResourceRequestOwnership?), TypeInfoPropertyName = "NullableUpdateResourceRequestOwnership2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateResourceRequestStatus?), TypeInfoPropertyName = "NullableUpdateResourceRequestStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateResourceRequestBillingPlanType?), TypeInfoPropertyName = "NullableUpdateResourceRequestBillingPlanType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.UpdateResourceRequestNotification, string>?), TypeInfoPropertyName = "NullableOneOfUpdateResourceRequestNotificationString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateResourceRequestNotificationLevel?), TypeInfoPropertyName = "NullableUpdateResourceRequestNotificationLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::System.Collections.Generic.IList<global::Vercel.UpdateResourceRequestSecret>, global::Vercel.UpdateResourceRequestSecrets>?), TypeInfoPropertyName = "NullableOneOfIListUpdateResourceRequestSecretUpdateResourceRequestSecrets2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::System.Collections.Generic.IList<global::Vercel.SubmitBillingDataRequestBillingItem>, global::Vercel.SubmitBillingDataRequestBilling>?), TypeInfoPropertyName = "NullableOneOfIListSubmitBillingDataRequestBillingItemSubmitBillingDataRequestBilling2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.SubmitBillingDataRequestUsageItemType?), TypeInfoPropertyName = "NullableSubmitBillingDataRequestUsageItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.SubmitInvoiceRequestTestResult?), TypeInfoPropertyName = "NullableSubmitInvoiceRequestTestResult2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateInvoiceRequestAction?), TypeInfoPropertyName = "NullableUpdateInvoiceRequestAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.ExchangeSsoTokenRequestVariant1, global::Vercel.ExchangeSsoTokenRequestVariant2>?), TypeInfoPropertyName = "NullableOneOfExchangeSsoTokenRequestVariant1ExchangeSsoTokenRequestVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ExchangeSsoTokenRequestVariant1GrantType?), TypeInfoPropertyName = "NullableExchangeSsoTokenRequestVariant1GrantType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ExchangeSsoTokenRequestVariant2GrantType?), TypeInfoPropertyName = "NullableExchangeSsoTokenRequestVariant2GrantType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsRequestItemCategory?), TypeInfoPropertyName = "NullableCreateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsRequestItemCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsByItemIdRequestCategory?), TypeInfoPropertyName = "NullableUpdateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsByItemIdRequestCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetMemberResponseRole?), TypeInfoPropertyName = "NullableGetMemberResponseRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.RotateInstallationCredentialResponseTokenType?), TypeInfoPropertyName = "NullableRotateInstallationCredentialResponseTokenType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, double?, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<double>, bool?>?), TypeInfoPropertyName = "NullableOneOfStringDoubleIListStringIListDoubleBoolean2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetIntegrationResourcesResponseResourceNotificationLevel?), TypeInfoPropertyName = "NullableGetIntegrationResourcesResponseResourceNotificationLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetIntegrationResourcesResponseResourceProtocolSettingsAuthenticationAppUrlTarget?), TypeInfoPropertyName = "NullableGetIntegrationResourcesResponseResourceProtocolSettingsAuthenticationAppUrlTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetIntegrationResourcesResponseResourceStatus?), TypeInfoPropertyName = "NullableGetIntegrationResourcesResponseResourceStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetIntegrationResourceResponseNotificationLevel?), TypeInfoPropertyName = "NullableGetIntegrationResourceResponseNotificationLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetIntegrationResourceResponseProtocolSettingsAuthenticationAppUrlTarget?), TypeInfoPropertyName = "NullableGetIntegrationResourceResponseProtocolSettingsAuthenticationAppUrlTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetIntegrationResourceResponseStatus?), TypeInfoPropertyName = "NullableGetIntegrationResourceResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetInvoiceResponseState?), TypeInfoPropertyName = "NullableGetInvoiceResponseState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.ExchangeSsoTokenResponseVariant1, global::Vercel.ExchangeSsoTokenResponseVariant2>?), TypeInfoPropertyName = "NullableOneOfExchangeSsoTokenResponseVariant1ExchangeSsoTokenResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.HeadInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationGlobalConfigResponsePurpose?), TypeInfoPropertyName = "NullableHeadInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationGlobalConfigResponsePurpose2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationGlobalConfigResponsePurpose?), TypeInfoPropertyName = "NullableGetInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationGlobalConfigResponsePurpose2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ReplaceInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationGlobalConfigResponsePurpose?), TypeInfoPropertyName = "NullableReplaceInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationGlobalConfigResponsePurpose2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.GlobalConfigItemValue?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.UpdateInstallationRequestBillingPlanDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.UpdateInstallationRequestBillingPlanHighlightedDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.ImportResourceRequestBillingPlanDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.ImportResourceRequestBillingPlanHighlightedDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.ImportResourceRequestSecret>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.UpdateResourceRequestBillingPlanDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.UpdateResourceRequestBillingPlanHighlightedDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::System.Collections.Generic.List<global::Vercel.UpdateResourceRequestSecret>, global::Vercel.UpdateResourceRequestSecrets>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.UpdateResourceRequestSecret>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.UpdateResourceRequestSecretsSecret>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::System.Collections.Generic.List<global::Vercel.SubmitBillingDataRequestBillingItem>, global::Vercel.SubmitBillingDataRequestBilling>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.SubmitBillingDataRequestBillingItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.SubmitBillingDataRequestBillingItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.SubmitBillingDataRequestBillingDiscount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.SubmitBillingDataRequestUsageItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.SubmitInvoiceRequestItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.SubmitInvoiceRequestDiscount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.SubmitPrepaymentBalancesRequestBalance>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.UpdateResourceSecretsRequestSecret>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.UpdateResourceSecretsByIdRequestSecret>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.CreateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsRequestItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.GetIntegrationResourcesResponseResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, double?, global::System.Collections.Generic.List<string>, global::System.Collections.Generic.List<double>, bool?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.GetIntegrationResourcesResponseResourceProtocolSettingsAuthenticationAppUrl>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.GetIntegrationResourceResponseProtocolSettingsAuthenticationAppUrl>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.GetInvoiceResponseDiscount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.GetInvoiceResponseItem>))]
    internal sealed partial class MarketplaceSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MarketplaceSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static MarketplaceSourceGenerationContext Default { get; } = new(DefaultOptions);

        private MarketplaceSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Vercel.JsonConverters.GlobalConfigItemValueJsonConverter());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<int?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, object, global::System.Collections.Generic.IList<object>, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
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
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<string, double?, bool?, object, global::System.Collections.Generic.IList<object>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<string, double?, bool?, object, global::System.Collections.Generic.IList<object>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.UpdateInstallationRequestNotification, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.CreateEventRequestEventVariant1, global::Vercel.CreateEventRequestEventVariant2>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.UpdateResourceRequestNotification, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::Vercel.UpdateResourceRequestSecret>, global::Vercel.UpdateResourceRequestSecrets>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::Vercel.SubmitBillingDataRequestBillingItem>, global::Vercel.SubmitBillingDataRequestBilling>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.ExchangeSsoTokenRequestVariant1, global::Vercel.ExchangeSsoTokenRequestVariant2>());
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
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
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
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<double>, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.ExchangeSsoTokenResponseVariant1, global::Vercel.ExchangeSsoTokenResponseVariant2>());
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
                    typeToConvert == typeof(global::Vercel.UpdateInstallationRequestStatus)

                    || typeToConvert == typeof(global::Vercel.UpdateInstallationRequestStatus?)

                    || typeToConvert == typeof(global::Vercel.UpdateInstallationRequestBillingPlanType)

                    || typeToConvert == typeof(global::Vercel.UpdateInstallationRequestBillingPlanType?)

                    || typeToConvert == typeof(global::Vercel.UpdateInstallationRequestNotificationLevel)

                    || typeToConvert == typeof(global::Vercel.UpdateInstallationRequestNotificationLevel?)

                    || typeToConvert == typeof(global::Vercel.CreateEventRequestEventVariant1Type)

                    || typeToConvert == typeof(global::Vercel.CreateEventRequestEventVariant1Type?)

                    || typeToConvert == typeof(global::Vercel.CreateEventRequestEventVariant2Type)

                    || typeToConvert == typeof(global::Vercel.CreateEventRequestEventVariant2Type?)

                    || typeToConvert == typeof(global::Vercel.ImportResourceRequestOwnership)

                    || typeToConvert == typeof(global::Vercel.ImportResourceRequestOwnership?)

                    || typeToConvert == typeof(global::Vercel.ImportResourceRequestStatus)

                    || typeToConvert == typeof(global::Vercel.ImportResourceRequestStatus?)

                    || typeToConvert == typeof(global::Vercel.ImportResourceRequestBillingPlanType)

                    || typeToConvert == typeof(global::Vercel.ImportResourceRequestBillingPlanType?)

                    || typeToConvert == typeof(global::Vercel.ImportResourceRequestNotificationLevel)

                    || typeToConvert == typeof(global::Vercel.ImportResourceRequestNotificationLevel?)

                    || typeToConvert == typeof(global::Vercel.UpdateResourceRequestOwnership)

                    || typeToConvert == typeof(global::Vercel.UpdateResourceRequestOwnership?)

                    || typeToConvert == typeof(global::Vercel.UpdateResourceRequestStatus)

                    || typeToConvert == typeof(global::Vercel.UpdateResourceRequestStatus?)

                    || typeToConvert == typeof(global::Vercel.UpdateResourceRequestBillingPlanType)

                    || typeToConvert == typeof(global::Vercel.UpdateResourceRequestBillingPlanType?)

                    || typeToConvert == typeof(global::Vercel.UpdateResourceRequestNotificationLevel)

                    || typeToConvert == typeof(global::Vercel.UpdateResourceRequestNotificationLevel?)

                    || typeToConvert == typeof(global::Vercel.SubmitBillingDataRequestUsageItemType)

                    || typeToConvert == typeof(global::Vercel.SubmitBillingDataRequestUsageItemType?)

                    || typeToConvert == typeof(global::Vercel.SubmitInvoiceRequestTestResult)

                    || typeToConvert == typeof(global::Vercel.SubmitInvoiceRequestTestResult?)

                    || typeToConvert == typeof(global::Vercel.UpdateInvoiceRequestAction)

                    || typeToConvert == typeof(global::Vercel.UpdateInvoiceRequestAction?)

                    || typeToConvert == typeof(global::Vercel.ExchangeSsoTokenRequestVariant1GrantType)

                    || typeToConvert == typeof(global::Vercel.ExchangeSsoTokenRequestVariant1GrantType?)

                    || typeToConvert == typeof(global::Vercel.ExchangeSsoTokenRequestVariant2GrantType)

                    || typeToConvert == typeof(global::Vercel.ExchangeSsoTokenRequestVariant2GrantType?)

                    || typeToConvert == typeof(global::Vercel.CreateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsRequestItemCategory)

                    || typeToConvert == typeof(global::Vercel.CreateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsRequestItemCategory?)

                    || typeToConvert == typeof(global::Vercel.UpdateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsByItemIdRequestCategory)

                    || typeToConvert == typeof(global::Vercel.UpdateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsByItemIdRequestCategory?)

                    || typeToConvert == typeof(global::Vercel.GetMemberResponseRole)

                    || typeToConvert == typeof(global::Vercel.GetMemberResponseRole?)

                    || typeToConvert == typeof(global::Vercel.RotateInstallationCredentialResponseTokenType)

                    || typeToConvert == typeof(global::Vercel.RotateInstallationCredentialResponseTokenType?)

                    || typeToConvert == typeof(global::Vercel.GetIntegrationResourcesResponseResourceNotificationLevel)

                    || typeToConvert == typeof(global::Vercel.GetIntegrationResourcesResponseResourceNotificationLevel?)

                    || typeToConvert == typeof(global::Vercel.GetIntegrationResourcesResponseResourceProtocolSettingsAuthenticationAppUrlTarget)

                    || typeToConvert == typeof(global::Vercel.GetIntegrationResourcesResponseResourceProtocolSettingsAuthenticationAppUrlTarget?)

                    || typeToConvert == typeof(global::Vercel.GetIntegrationResourcesResponseResourceStatus)

                    || typeToConvert == typeof(global::Vercel.GetIntegrationResourcesResponseResourceStatus?)

                    || typeToConvert == typeof(global::Vercel.GetIntegrationResourceResponseNotificationLevel)

                    || typeToConvert == typeof(global::Vercel.GetIntegrationResourceResponseNotificationLevel?)

                    || typeToConvert == typeof(global::Vercel.GetIntegrationResourceResponseProtocolSettingsAuthenticationAppUrlTarget)

                    || typeToConvert == typeof(global::Vercel.GetIntegrationResourceResponseProtocolSettingsAuthenticationAppUrlTarget?)

                    || typeToConvert == typeof(global::Vercel.GetIntegrationResourceResponseStatus)

                    || typeToConvert == typeof(global::Vercel.GetIntegrationResourceResponseStatus?)

                    || typeToConvert == typeof(global::Vercel.GetInvoiceResponseState)

                    || typeToConvert == typeof(global::Vercel.GetInvoiceResponseState?)

                    || typeToConvert == typeof(global::Vercel.HeadInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationGlobalConfigResponsePurpose)

                    || typeToConvert == typeof(global::Vercel.HeadInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationGlobalConfigResponsePurpose?)

                    || typeToConvert == typeof(global::Vercel.GetInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationGlobalConfigResponsePurpose)

                    || typeToConvert == typeof(global::Vercel.GetInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationGlobalConfigResponsePurpose?)

                    || typeToConvert == typeof(global::Vercel.ReplaceInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationGlobalConfigResponsePurpose)

                    || typeToConvert == typeof(global::Vercel.ReplaceInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationGlobalConfigResponsePurpose?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Vercel.UpdateInstallationRequestStatus))
                {
                    return new global::Vercel.JsonConverters.UpdateInstallationRequestStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpdateInstallationRequestStatus?))
                {
                    return new global::Vercel.JsonConverters.UpdateInstallationRequestStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpdateInstallationRequestBillingPlanType))
                {
                    return new global::Vercel.JsonConverters.UpdateInstallationRequestBillingPlanTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpdateInstallationRequestBillingPlanType?))
                {
                    return new global::Vercel.JsonConverters.UpdateInstallationRequestBillingPlanTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpdateInstallationRequestNotificationLevel))
                {
                    return new global::Vercel.JsonConverters.UpdateInstallationRequestNotificationLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpdateInstallationRequestNotificationLevel?))
                {
                    return new global::Vercel.JsonConverters.UpdateInstallationRequestNotificationLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateEventRequestEventVariant1Type))
                {
                    return new global::Vercel.JsonConverters.CreateEventRequestEventVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateEventRequestEventVariant1Type?))
                {
                    return new global::Vercel.JsonConverters.CreateEventRequestEventVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateEventRequestEventVariant2Type))
                {
                    return new global::Vercel.JsonConverters.CreateEventRequestEventVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateEventRequestEventVariant2Type?))
                {
                    return new global::Vercel.JsonConverters.CreateEventRequestEventVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ImportResourceRequestOwnership))
                {
                    return new global::Vercel.JsonConverters.ImportResourceRequestOwnershipJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ImportResourceRequestOwnership?))
                {
                    return new global::Vercel.JsonConverters.ImportResourceRequestOwnershipNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ImportResourceRequestStatus))
                {
                    return new global::Vercel.JsonConverters.ImportResourceRequestStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ImportResourceRequestStatus?))
                {
                    return new global::Vercel.JsonConverters.ImportResourceRequestStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ImportResourceRequestBillingPlanType))
                {
                    return new global::Vercel.JsonConverters.ImportResourceRequestBillingPlanTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ImportResourceRequestBillingPlanType?))
                {
                    return new global::Vercel.JsonConverters.ImportResourceRequestBillingPlanTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ImportResourceRequestNotificationLevel))
                {
                    return new global::Vercel.JsonConverters.ImportResourceRequestNotificationLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ImportResourceRequestNotificationLevel?))
                {
                    return new global::Vercel.JsonConverters.ImportResourceRequestNotificationLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpdateResourceRequestOwnership))
                {
                    return new global::Vercel.JsonConverters.UpdateResourceRequestOwnershipJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpdateResourceRequestOwnership?))
                {
                    return new global::Vercel.JsonConverters.UpdateResourceRequestOwnershipNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpdateResourceRequestStatus))
                {
                    return new global::Vercel.JsonConverters.UpdateResourceRequestStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpdateResourceRequestStatus?))
                {
                    return new global::Vercel.JsonConverters.UpdateResourceRequestStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpdateResourceRequestBillingPlanType))
                {
                    return new global::Vercel.JsonConverters.UpdateResourceRequestBillingPlanTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpdateResourceRequestBillingPlanType?))
                {
                    return new global::Vercel.JsonConverters.UpdateResourceRequestBillingPlanTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpdateResourceRequestNotificationLevel))
                {
                    return new global::Vercel.JsonConverters.UpdateResourceRequestNotificationLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpdateResourceRequestNotificationLevel?))
                {
                    return new global::Vercel.JsonConverters.UpdateResourceRequestNotificationLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.SubmitBillingDataRequestUsageItemType))
                {
                    return new global::Vercel.JsonConverters.SubmitBillingDataRequestUsageItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.SubmitBillingDataRequestUsageItemType?))
                {
                    return new global::Vercel.JsonConverters.SubmitBillingDataRequestUsageItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.SubmitInvoiceRequestTestResult))
                {
                    return new global::Vercel.JsonConverters.SubmitInvoiceRequestTestResultJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.SubmitInvoiceRequestTestResult?))
                {
                    return new global::Vercel.JsonConverters.SubmitInvoiceRequestTestResultNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpdateInvoiceRequestAction))
                {
                    return new global::Vercel.JsonConverters.UpdateInvoiceRequestActionJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpdateInvoiceRequestAction?))
                {
                    return new global::Vercel.JsonConverters.UpdateInvoiceRequestActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ExchangeSsoTokenRequestVariant1GrantType))
                {
                    return new global::Vercel.JsonConverters.ExchangeSsoTokenRequestVariant1GrantTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ExchangeSsoTokenRequestVariant1GrantType?))
                {
                    return new global::Vercel.JsonConverters.ExchangeSsoTokenRequestVariant1GrantTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ExchangeSsoTokenRequestVariant2GrantType))
                {
                    return new global::Vercel.JsonConverters.ExchangeSsoTokenRequestVariant2GrantTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ExchangeSsoTokenRequestVariant2GrantType?))
                {
                    return new global::Vercel.JsonConverters.ExchangeSsoTokenRequestVariant2GrantTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsRequestItemCategory))
                {
                    return new global::Vercel.JsonConverters.CreateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsRequestItemCategoryJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsRequestItemCategory?))
                {
                    return new global::Vercel.JsonConverters.CreateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsRequestItemCategoryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpdateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsByItemIdRequestCategory))
                {
                    return new global::Vercel.JsonConverters.UpdateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsByItemIdRequestCategoryJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpdateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsByItemIdRequestCategory?))
                {
                    return new global::Vercel.JsonConverters.UpdateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsByItemIdRequestCategoryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetMemberResponseRole))
                {
                    return new global::Vercel.JsonConverters.GetMemberResponseRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetMemberResponseRole?))
                {
                    return new global::Vercel.JsonConverters.GetMemberResponseRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.RotateInstallationCredentialResponseTokenType))
                {
                    return new global::Vercel.JsonConverters.RotateInstallationCredentialResponseTokenTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.RotateInstallationCredentialResponseTokenType?))
                {
                    return new global::Vercel.JsonConverters.RotateInstallationCredentialResponseTokenTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetIntegrationResourcesResponseResourceNotificationLevel))
                {
                    return new global::Vercel.JsonConverters.GetIntegrationResourcesResponseResourceNotificationLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetIntegrationResourcesResponseResourceNotificationLevel?))
                {
                    return new global::Vercel.JsonConverters.GetIntegrationResourcesResponseResourceNotificationLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetIntegrationResourcesResponseResourceProtocolSettingsAuthenticationAppUrlTarget))
                {
                    return new global::Vercel.JsonConverters.GetIntegrationResourcesResponseResourceProtocolSettingsAuthenticationAppUrlTargetJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetIntegrationResourcesResponseResourceProtocolSettingsAuthenticationAppUrlTarget?))
                {
                    return new global::Vercel.JsonConverters.GetIntegrationResourcesResponseResourceProtocolSettingsAuthenticationAppUrlTargetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetIntegrationResourcesResponseResourceStatus))
                {
                    return new global::Vercel.JsonConverters.GetIntegrationResourcesResponseResourceStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetIntegrationResourcesResponseResourceStatus?))
                {
                    return new global::Vercel.JsonConverters.GetIntegrationResourcesResponseResourceStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetIntegrationResourceResponseNotificationLevel))
                {
                    return new global::Vercel.JsonConverters.GetIntegrationResourceResponseNotificationLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetIntegrationResourceResponseNotificationLevel?))
                {
                    return new global::Vercel.JsonConverters.GetIntegrationResourceResponseNotificationLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetIntegrationResourceResponseProtocolSettingsAuthenticationAppUrlTarget))
                {
                    return new global::Vercel.JsonConverters.GetIntegrationResourceResponseProtocolSettingsAuthenticationAppUrlTargetJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetIntegrationResourceResponseProtocolSettingsAuthenticationAppUrlTarget?))
                {
                    return new global::Vercel.JsonConverters.GetIntegrationResourceResponseProtocolSettingsAuthenticationAppUrlTargetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetIntegrationResourceResponseStatus))
                {
                    return new global::Vercel.JsonConverters.GetIntegrationResourceResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetIntegrationResourceResponseStatus?))
                {
                    return new global::Vercel.JsonConverters.GetIntegrationResourceResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetInvoiceResponseState))
                {
                    return new global::Vercel.JsonConverters.GetInvoiceResponseStateJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetInvoiceResponseState?))
                {
                    return new global::Vercel.JsonConverters.GetInvoiceResponseStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.HeadInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationGlobalConfigResponsePurpose))
                {
                    return new global::Vercel.JsonConverters.HeadInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationGlobalConfigResponsePurposeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.HeadInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationGlobalConfigResponsePurpose?))
                {
                    return new global::Vercel.JsonConverters.HeadInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationGlobalConfigResponsePurposeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationGlobalConfigResponsePurpose))
                {
                    return new global::Vercel.JsonConverters.GetInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationGlobalConfigResponsePurposeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationGlobalConfigResponsePurpose?))
                {
                    return new global::Vercel.JsonConverters.GetInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationGlobalConfigResponsePurposeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ReplaceInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationGlobalConfigResponsePurpose))
                {
                    return new global::Vercel.JsonConverters.ReplaceInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationGlobalConfigResponsePurposeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ReplaceInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationGlobalConfigResponsePurpose?))
                {
                    return new global::Vercel.JsonConverters.ReplaceInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationGlobalConfigResponsePurposeNullableJsonConverter();
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
                    0 => new MarketplaceSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}