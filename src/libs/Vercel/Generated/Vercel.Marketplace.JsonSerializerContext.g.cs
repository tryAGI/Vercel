
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>), TypeInfoPropertyName = "DictionaryStringString_System_Collections_Generic_Dictionary_string_string")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateResourceRequest))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetIntegrationResourceResponse))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.HeadInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationGlobalConfigResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationGlobalConfigResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ReplaceInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationGlobalConfigResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string?>), TypeInfoPropertyName = "DictionaryStringString_System_Collections_Generic_Dictionary_string_string_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateInstallationRequestStatus?), TypeInfoPropertyName = "NullableUpdateInstallationRequestStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateInstallationRequestBillingPlanType?), TypeInfoPropertyName = "NullableUpdateInstallationRequestBillingPlanType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.UpdateInstallationRequestNotification, string>?), TypeInfoPropertyName = "NullableOneOfUpdateInstallationRequestNotificationString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateInstallationRequestNotificationLevel?), TypeInfoPropertyName = "NullableUpdateInstallationRequestNotificationLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.CreateEventRequestEventVariant1, global::Vercel.CreateEventRequestEventVariant2>?), TypeInfoPropertyName = "NullableOneOfCreateEventRequestEventVariant1CreateEventRequestEventVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateEventRequestEventVariant1Type?), TypeInfoPropertyName = "NullableCreateEventRequestEventVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateEventRequestEventVariant2Type?), TypeInfoPropertyName = "NullableCreateEventRequestEventVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::System.Collections.Generic.IList<global::Vercel.SubmitBillingDataRequestBillingItem>, global::Vercel.SubmitBillingDataRequestBilling>?), TypeInfoPropertyName = "NullableOneOfIListSubmitBillingDataRequestBillingItemSubmitBillingDataRequestBilling2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.SubmitBillingDataRequestUsageItemType?), TypeInfoPropertyName = "NullableSubmitBillingDataRequestUsageItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.SubmitInvoiceRequestTestResult?), TypeInfoPropertyName = "NullableSubmitInvoiceRequestTestResult2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateInvoiceRequestAction?), TypeInfoPropertyName = "NullableUpdateInvoiceRequestAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsRequestItemCategory?), TypeInfoPropertyName = "NullableCreateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsRequestItemCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsByItemIdRequestCategory?), TypeInfoPropertyName = "NullableUpdateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsByItemIdRequestCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetMemberResponseRole?), TypeInfoPropertyName = "NullableGetMemberResponseRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.RotateInstallationCredentialResponseTokenType?), TypeInfoPropertyName = "NullableRotateInstallationCredentialResponseTokenType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetInvoiceResponseState?), TypeInfoPropertyName = "NullableGetInvoiceResponseState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.UpdateInstallationRequestBillingPlanDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.UpdateInstallationRequestBillingPlanHighlightedDetail>))]
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

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


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
            global::Vercel.PartitionCoreSourceGenerationContext.AddConverters(options);
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.UpdateInstallationRequestNotification, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.CreateEventRequestEventVariant1, global::Vercel.CreateEventRequestEventVariant2>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::Vercel.SubmitBillingDataRequestBillingItem>, global::Vercel.SubmitBillingDataRequestBilling>());
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

                    || typeToConvert == typeof(global::Vercel.SubmitBillingDataRequestUsageItemType)

                    || typeToConvert == typeof(global::Vercel.SubmitBillingDataRequestUsageItemType?)

                    || typeToConvert == typeof(global::Vercel.SubmitInvoiceRequestTestResult)

                    || typeToConvert == typeof(global::Vercel.SubmitInvoiceRequestTestResult?)

                    || typeToConvert == typeof(global::Vercel.UpdateInvoiceRequestAction)

                    || typeToConvert == typeof(global::Vercel.UpdateInvoiceRequestAction?)

                    || typeToConvert == typeof(global::Vercel.CreateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsRequestItemCategory)

                    || typeToConvert == typeof(global::Vercel.CreateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsRequestItemCategory?)

                    || typeToConvert == typeof(global::Vercel.UpdateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsByItemIdRequestCategory)

                    || typeToConvert == typeof(global::Vercel.UpdateInstallationsByIntegrationConfigurationIdResourcesByResourceIdExperimentationItemsByItemIdRequestCategory?)

                    || typeToConvert == typeof(global::Vercel.GetMemberResponseRole)

                    || typeToConvert == typeof(global::Vercel.GetMemberResponseRole?)

                    || typeToConvert == typeof(global::Vercel.RotateInstallationCredentialResponseTokenType)

                    || typeToConvert == typeof(global::Vercel.RotateInstallationCredentialResponseTokenType?)

                    || typeToConvert == typeof(global::Vercel.GetInvoiceResponseState)

                    || typeToConvert == typeof(global::Vercel.GetInvoiceResponseState?);
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

                if (typeToConvert == typeof(global::Vercel.GetInvoiceResponseState))
                {
                    return new global::Vercel.JsonConverters.GetInvoiceResponseStateJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetInvoiceResponseState?))
                {
                    return new global::Vercel.JsonConverters.GetInvoiceResponseStateNullableJsonConverter();
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
                    0 => new MarketplaceSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => global::Vercel.PartitionCoreSourceGenerationContext.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}