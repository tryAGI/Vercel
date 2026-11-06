
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AiGatewayProviderOptionBag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AiGatewayVirtualModelConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Vercel.AiGatewayProviderOptionBag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AiGatewayVirtualModelConfigList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.AiGatewayVirtualModelConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AiGatewayRouterList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AiGatewayRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AiGatewayRuleAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AiGatewayRuleMatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AiGatewayRuleType), TypeInfoPropertyName = "AiGatewayRuleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AiGatewayRuleListItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AiGatewayRuleListItemAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AiGatewayRuleListItemMatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AiGatewayRuleListItemType), TypeInfoPropertyName = "AiGatewayRuleListItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AiGatewayRuleList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.AiGatewayRuleListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AiGatewayBudget))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AiGatewayBudgetRefreshPeriod), TypeInfoPropertyName = "AiGatewayBudgetRefreshPeriod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AiGatewayBudgetScopeType), TypeInfoPropertyName = "AiGatewayBudgetScopeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AiGatewayBudgetSource), TypeInfoPropertyName = "AiGatewayBudgetSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AiGatewayBudgetList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.AiGatewayBudget>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AiGatewayBudgetListDefaultCoveredCounts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AiGatewayBudgetDefault))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AiGatewayBudgetDefaultRefreshPeriod), TypeInfoPropertyName = "AiGatewayBudgetDefaultRefreshPeriod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AiGatewayBudgetDefaultScopeType), TypeInfoPropertyName = "AiGatewayBudgetDefaultScopeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AiGatewayBudgetDefaultList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.AiGatewayBudgetDefault>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateAiGatewayByokCredentialRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.CreateAiGatewayByokCredentialRequestMapping>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateAiGatewayByokCredentialRequestMapping))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateAiGatewayByokCredentialRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpsertAiGatewayBudgetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpsertAiGatewayBudgetRequestScopeType), TypeInfoPropertyName = "UpsertAiGatewayBudgetRequestScopeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpsertAiGatewayBudgetRequestRefreshPeriod), TypeInfoPropertyName = "UpsertAiGatewayBudgetRequestRefreshPeriod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpsertAiGatewayBudgetDefaultRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpsertAiGatewayBudgetDefaultRequestScopeType), TypeInfoPropertyName = "UpsertAiGatewayBudgetDefaultRequestScopeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpsertAiGatewayBudgetDefaultRequestRefreshPeriod), TypeInfoPropertyName = "UpsertAiGatewayBudgetDefaultRequestRefreshPeriod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateApiKeyQuotaRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateApiKeyQuotaRequestRefreshPeriod), TypeInfoPropertyName = "UpdateApiKeyQuotaRequestRefreshPeriod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListAiGatewayByokCredentialsIncludeDeleted), TypeInfoPropertyName = "ListAiGatewayByokCredentialsIncludeDeleted2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListAiGatewayByokCredentialsDecrypt), TypeInfoPropertyName = "ListAiGatewayByokCredentialsDecrypt2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListAiGatewayByokCredentialsIncludeModelMappings), TypeInfoPropertyName = "ListAiGatewayByokCredentialsIncludeModelMappings2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListAiGatewayVirtualModelConfigsIncludeArchived), TypeInfoPropertyName = "ListAiGatewayVirtualModelConfigsIncludeArchived2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListAiGatewayRulesIncludeDisabled), TypeInfoPropertyName = "ListAiGatewayRulesIncludeDisabled2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListAiGatewayBudgetsScopeType), TypeInfoPropertyName = "ListAiGatewayBudgetsScopeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListAiGatewayBudgetsIncludeDefaultCovered), TypeInfoPropertyName = "ListAiGatewayBudgetsIncludeDefaultCovered2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ArchiveAiGatewayBudgetScopeType), TypeInfoPropertyName = "ArchiveAiGatewayBudgetScopeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ArchiveAiGatewayBudgetDefaultScopeType), TypeInfoPropertyName = "ArchiveAiGatewayBudgetDefaultScopeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateAiGatewayByokCredentialResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListAiGatewayByokCredentialsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.ListAiGatewayByokCredentialsResponseCredential>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListAiGatewayByokCredentialsResponseCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.ListAiGatewayByokCredentialsResponseCredentialModelMapping>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListAiGatewayByokCredentialsResponseCredentialModelMapping))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetAiGatewayByokCredentialResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateAiGatewayByokCredentialResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.AiGatewayVirtualModelConfig, global::Vercel.AiGatewayVirtualModelConfigList>), TypeInfoPropertyName = "OneOfAiGatewayVirtualModelConfigAiGatewayVirtualModelConfigList2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateApiKeyQuotaResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateApiKeyQuotaResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateApiKeyQuotaResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateApiKeyQuotaResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateApiKeyQuotaResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateApiKeyQuotaResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateApiKeyQuotaResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateApiKeyQuotaResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateApiKeyQuotaResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string?>), TypeInfoPropertyName = "DictionaryStringString_System_Collections_Generic_Dictionary_string_string_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AiGatewayRuleType?), TypeInfoPropertyName = "NullableAiGatewayRuleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AiGatewayRuleListItemType?), TypeInfoPropertyName = "NullableAiGatewayRuleListItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AiGatewayBudgetRefreshPeriod?), TypeInfoPropertyName = "NullableAiGatewayBudgetRefreshPeriod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AiGatewayBudgetScopeType?), TypeInfoPropertyName = "NullableAiGatewayBudgetScopeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AiGatewayBudgetSource?), TypeInfoPropertyName = "NullableAiGatewayBudgetSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AiGatewayBudgetDefaultRefreshPeriod?), TypeInfoPropertyName = "NullableAiGatewayBudgetDefaultRefreshPeriod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AiGatewayBudgetDefaultScopeType?), TypeInfoPropertyName = "NullableAiGatewayBudgetDefaultScopeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpsertAiGatewayBudgetRequestScopeType?), TypeInfoPropertyName = "NullableUpsertAiGatewayBudgetRequestScopeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpsertAiGatewayBudgetRequestRefreshPeriod?), TypeInfoPropertyName = "NullableUpsertAiGatewayBudgetRequestRefreshPeriod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpsertAiGatewayBudgetDefaultRequestScopeType?), TypeInfoPropertyName = "NullableUpsertAiGatewayBudgetDefaultRequestScopeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpsertAiGatewayBudgetDefaultRequestRefreshPeriod?), TypeInfoPropertyName = "NullableUpsertAiGatewayBudgetDefaultRequestRefreshPeriod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateApiKeyQuotaRequestRefreshPeriod?), TypeInfoPropertyName = "NullableUpdateApiKeyQuotaRequestRefreshPeriod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListAiGatewayByokCredentialsIncludeDeleted?), TypeInfoPropertyName = "NullableListAiGatewayByokCredentialsIncludeDeleted2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListAiGatewayByokCredentialsDecrypt?), TypeInfoPropertyName = "NullableListAiGatewayByokCredentialsDecrypt2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListAiGatewayByokCredentialsIncludeModelMappings?), TypeInfoPropertyName = "NullableListAiGatewayByokCredentialsIncludeModelMappings2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListAiGatewayVirtualModelConfigsIncludeArchived?), TypeInfoPropertyName = "NullableListAiGatewayVirtualModelConfigsIncludeArchived2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListAiGatewayRulesIncludeDisabled?), TypeInfoPropertyName = "NullableListAiGatewayRulesIncludeDisabled2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListAiGatewayBudgetsScopeType?), TypeInfoPropertyName = "NullableListAiGatewayBudgetsScopeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListAiGatewayBudgetsIncludeDefaultCovered?), TypeInfoPropertyName = "NullableListAiGatewayBudgetsIncludeDefaultCovered2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ArchiveAiGatewayBudgetScopeType?), TypeInfoPropertyName = "NullableArchiveAiGatewayBudgetScopeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ArchiveAiGatewayBudgetDefaultScopeType?), TypeInfoPropertyName = "NullableArchiveAiGatewayBudgetDefaultScopeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.AiGatewayVirtualModelConfig, global::Vercel.AiGatewayVirtualModelConfigList>?), TypeInfoPropertyName = "NullableOneOfAiGatewayVirtualModelConfigAiGatewayVirtualModelConfigList2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.AiGatewayVirtualModelConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.AiGatewayRuleListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.AiGatewayBudget>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.AiGatewayBudgetDefault>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.CreateAiGatewayByokCredentialRequestMapping>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.ListAiGatewayByokCredentialsResponseCredential>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.ListAiGatewayByokCredentialsResponseCredentialModelMapping>))]
    internal sealed partial class AiGatewaySourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AiGatewaySourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AiGatewaySourceGenerationContext Default { get; } = new(DefaultOptions);

        private AiGatewaySourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AiGatewayVirtualModelConfig, global::Vercel.AiGatewayVirtualModelConfigList>());
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
                    typeToConvert == typeof(global::Vercel.AiGatewayRuleType)

                    || typeToConvert == typeof(global::Vercel.AiGatewayRuleType?)

                    || typeToConvert == typeof(global::Vercel.AiGatewayRuleListItemType)

                    || typeToConvert == typeof(global::Vercel.AiGatewayRuleListItemType?)

                    || typeToConvert == typeof(global::Vercel.AiGatewayBudgetRefreshPeriod)

                    || typeToConvert == typeof(global::Vercel.AiGatewayBudgetRefreshPeriod?)

                    || typeToConvert == typeof(global::Vercel.AiGatewayBudgetScopeType)

                    || typeToConvert == typeof(global::Vercel.AiGatewayBudgetScopeType?)

                    || typeToConvert == typeof(global::Vercel.AiGatewayBudgetSource)

                    || typeToConvert == typeof(global::Vercel.AiGatewayBudgetSource?)

                    || typeToConvert == typeof(global::Vercel.AiGatewayBudgetDefaultRefreshPeriod)

                    || typeToConvert == typeof(global::Vercel.AiGatewayBudgetDefaultRefreshPeriod?)

                    || typeToConvert == typeof(global::Vercel.AiGatewayBudgetDefaultScopeType)

                    || typeToConvert == typeof(global::Vercel.AiGatewayBudgetDefaultScopeType?)

                    || typeToConvert == typeof(global::Vercel.UpsertAiGatewayBudgetRequestScopeType)

                    || typeToConvert == typeof(global::Vercel.UpsertAiGatewayBudgetRequestScopeType?)

                    || typeToConvert == typeof(global::Vercel.UpsertAiGatewayBudgetRequestRefreshPeriod)

                    || typeToConvert == typeof(global::Vercel.UpsertAiGatewayBudgetRequestRefreshPeriod?)

                    || typeToConvert == typeof(global::Vercel.UpsertAiGatewayBudgetDefaultRequestScopeType)

                    || typeToConvert == typeof(global::Vercel.UpsertAiGatewayBudgetDefaultRequestScopeType?)

                    || typeToConvert == typeof(global::Vercel.UpsertAiGatewayBudgetDefaultRequestRefreshPeriod)

                    || typeToConvert == typeof(global::Vercel.UpsertAiGatewayBudgetDefaultRequestRefreshPeriod?)

                    || typeToConvert == typeof(global::Vercel.UpdateApiKeyQuotaRequestRefreshPeriod)

                    || typeToConvert == typeof(global::Vercel.UpdateApiKeyQuotaRequestRefreshPeriod?)

                    || typeToConvert == typeof(global::Vercel.ListAiGatewayByokCredentialsIncludeDeleted)

                    || typeToConvert == typeof(global::Vercel.ListAiGatewayByokCredentialsIncludeDeleted?)

                    || typeToConvert == typeof(global::Vercel.ListAiGatewayByokCredentialsDecrypt)

                    || typeToConvert == typeof(global::Vercel.ListAiGatewayByokCredentialsDecrypt?)

                    || typeToConvert == typeof(global::Vercel.ListAiGatewayByokCredentialsIncludeModelMappings)

                    || typeToConvert == typeof(global::Vercel.ListAiGatewayByokCredentialsIncludeModelMappings?)

                    || typeToConvert == typeof(global::Vercel.ListAiGatewayVirtualModelConfigsIncludeArchived)

                    || typeToConvert == typeof(global::Vercel.ListAiGatewayVirtualModelConfigsIncludeArchived?)

                    || typeToConvert == typeof(global::Vercel.ListAiGatewayRulesIncludeDisabled)

                    || typeToConvert == typeof(global::Vercel.ListAiGatewayRulesIncludeDisabled?)

                    || typeToConvert == typeof(global::Vercel.ListAiGatewayBudgetsScopeType)

                    || typeToConvert == typeof(global::Vercel.ListAiGatewayBudgetsScopeType?)

                    || typeToConvert == typeof(global::Vercel.ListAiGatewayBudgetsIncludeDefaultCovered)

                    || typeToConvert == typeof(global::Vercel.ListAiGatewayBudgetsIncludeDefaultCovered?)

                    || typeToConvert == typeof(global::Vercel.ArchiveAiGatewayBudgetScopeType)

                    || typeToConvert == typeof(global::Vercel.ArchiveAiGatewayBudgetScopeType?)

                    || typeToConvert == typeof(global::Vercel.ArchiveAiGatewayBudgetDefaultScopeType)

                    || typeToConvert == typeof(global::Vercel.ArchiveAiGatewayBudgetDefaultScopeType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Vercel.AiGatewayRuleType))
                {
                    return new global::Vercel.JsonConverters.AiGatewayRuleTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AiGatewayRuleType?))
                {
                    return new global::Vercel.JsonConverters.AiGatewayRuleTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AiGatewayRuleListItemType))
                {
                    return new global::Vercel.JsonConverters.AiGatewayRuleListItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AiGatewayRuleListItemType?))
                {
                    return new global::Vercel.JsonConverters.AiGatewayRuleListItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AiGatewayBudgetRefreshPeriod))
                {
                    return new global::Vercel.JsonConverters.AiGatewayBudgetRefreshPeriodJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AiGatewayBudgetRefreshPeriod?))
                {
                    return new global::Vercel.JsonConverters.AiGatewayBudgetRefreshPeriodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AiGatewayBudgetScopeType))
                {
                    return new global::Vercel.JsonConverters.AiGatewayBudgetScopeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AiGatewayBudgetScopeType?))
                {
                    return new global::Vercel.JsonConverters.AiGatewayBudgetScopeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AiGatewayBudgetSource))
                {
                    return new global::Vercel.JsonConverters.AiGatewayBudgetSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AiGatewayBudgetSource?))
                {
                    return new global::Vercel.JsonConverters.AiGatewayBudgetSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AiGatewayBudgetDefaultRefreshPeriod))
                {
                    return new global::Vercel.JsonConverters.AiGatewayBudgetDefaultRefreshPeriodJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AiGatewayBudgetDefaultRefreshPeriod?))
                {
                    return new global::Vercel.JsonConverters.AiGatewayBudgetDefaultRefreshPeriodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AiGatewayBudgetDefaultScopeType))
                {
                    return new global::Vercel.JsonConverters.AiGatewayBudgetDefaultScopeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AiGatewayBudgetDefaultScopeType?))
                {
                    return new global::Vercel.JsonConverters.AiGatewayBudgetDefaultScopeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpsertAiGatewayBudgetRequestScopeType))
                {
                    return new global::Vercel.JsonConverters.UpsertAiGatewayBudgetRequestScopeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpsertAiGatewayBudgetRequestScopeType?))
                {
                    return new global::Vercel.JsonConverters.UpsertAiGatewayBudgetRequestScopeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpsertAiGatewayBudgetRequestRefreshPeriod))
                {
                    return new global::Vercel.JsonConverters.UpsertAiGatewayBudgetRequestRefreshPeriodJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpsertAiGatewayBudgetRequestRefreshPeriod?))
                {
                    return new global::Vercel.JsonConverters.UpsertAiGatewayBudgetRequestRefreshPeriodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpsertAiGatewayBudgetDefaultRequestScopeType))
                {
                    return new global::Vercel.JsonConverters.UpsertAiGatewayBudgetDefaultRequestScopeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpsertAiGatewayBudgetDefaultRequestScopeType?))
                {
                    return new global::Vercel.JsonConverters.UpsertAiGatewayBudgetDefaultRequestScopeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpsertAiGatewayBudgetDefaultRequestRefreshPeriod))
                {
                    return new global::Vercel.JsonConverters.UpsertAiGatewayBudgetDefaultRequestRefreshPeriodJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpsertAiGatewayBudgetDefaultRequestRefreshPeriod?))
                {
                    return new global::Vercel.JsonConverters.UpsertAiGatewayBudgetDefaultRequestRefreshPeriodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpdateApiKeyQuotaRequestRefreshPeriod))
                {
                    return new global::Vercel.JsonConverters.UpdateApiKeyQuotaRequestRefreshPeriodJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpdateApiKeyQuotaRequestRefreshPeriod?))
                {
                    return new global::Vercel.JsonConverters.UpdateApiKeyQuotaRequestRefreshPeriodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ListAiGatewayByokCredentialsIncludeDeleted))
                {
                    return new global::Vercel.JsonConverters.ListAiGatewayByokCredentialsIncludeDeletedJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ListAiGatewayByokCredentialsIncludeDeleted?))
                {
                    return new global::Vercel.JsonConverters.ListAiGatewayByokCredentialsIncludeDeletedNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ListAiGatewayByokCredentialsDecrypt))
                {
                    return new global::Vercel.JsonConverters.ListAiGatewayByokCredentialsDecryptJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ListAiGatewayByokCredentialsDecrypt?))
                {
                    return new global::Vercel.JsonConverters.ListAiGatewayByokCredentialsDecryptNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ListAiGatewayByokCredentialsIncludeModelMappings))
                {
                    return new global::Vercel.JsonConverters.ListAiGatewayByokCredentialsIncludeModelMappingsJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ListAiGatewayByokCredentialsIncludeModelMappings?))
                {
                    return new global::Vercel.JsonConverters.ListAiGatewayByokCredentialsIncludeModelMappingsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ListAiGatewayVirtualModelConfigsIncludeArchived))
                {
                    return new global::Vercel.JsonConverters.ListAiGatewayVirtualModelConfigsIncludeArchivedJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ListAiGatewayVirtualModelConfigsIncludeArchived?))
                {
                    return new global::Vercel.JsonConverters.ListAiGatewayVirtualModelConfigsIncludeArchivedNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ListAiGatewayRulesIncludeDisabled))
                {
                    return new global::Vercel.JsonConverters.ListAiGatewayRulesIncludeDisabledJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ListAiGatewayRulesIncludeDisabled?))
                {
                    return new global::Vercel.JsonConverters.ListAiGatewayRulesIncludeDisabledNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ListAiGatewayBudgetsScopeType))
                {
                    return new global::Vercel.JsonConverters.ListAiGatewayBudgetsScopeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ListAiGatewayBudgetsScopeType?))
                {
                    return new global::Vercel.JsonConverters.ListAiGatewayBudgetsScopeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ListAiGatewayBudgetsIncludeDefaultCovered))
                {
                    return new global::Vercel.JsonConverters.ListAiGatewayBudgetsIncludeDefaultCoveredJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ListAiGatewayBudgetsIncludeDefaultCovered?))
                {
                    return new global::Vercel.JsonConverters.ListAiGatewayBudgetsIncludeDefaultCoveredNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ArchiveAiGatewayBudgetScopeType))
                {
                    return new global::Vercel.JsonConverters.ArchiveAiGatewayBudgetScopeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ArchiveAiGatewayBudgetScopeType?))
                {
                    return new global::Vercel.JsonConverters.ArchiveAiGatewayBudgetScopeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ArchiveAiGatewayBudgetDefaultScopeType))
                {
                    return new global::Vercel.JsonConverters.ArchiveAiGatewayBudgetDefaultScopeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ArchiveAiGatewayBudgetDefaultScopeType?))
                {
                    return new global::Vercel.JsonConverters.ArchiveAiGatewayBudgetDefaultScopeTypeNullableJsonConverter();
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
                    0 => new AiGatewaySourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => global::Vercel.PartitionCoreSourceGenerationContext.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}