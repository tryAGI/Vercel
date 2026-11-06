
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKShareda5bc732e1681aab5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKSharedada259eacea6cff6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKShareda5bc732e1681aab5RouteType), TypeInfoPropertyName = "AutoSDKShareda5bc732e1681aab5RouteType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKShareda5bc732e1681aab5SrcSyntax), TypeInfoPropertyName = "AutoSDKShareda5bc732e1681aab5SrcSyntax2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKSharedb49e2a5785c6f473))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKSharedb49e2a5785c6f473RouteType), TypeInfoPropertyName = "AutoSDKSharedb49e2a5785c6f473RouteType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKSharedb49e2a5785c6f473SrcSyntax), TypeInfoPropertyName = "AutoSDKSharedb49e2a5785c6f473SrcSyntax2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedb49e2a5785c6f473>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.StageRoutesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.DeleteRoutesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRouteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GenerateRouteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GenerateRouteRequestCurrentRoute))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GenerateRouteRequestCurrentRoutePathCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.GenerateRouteRequestCurrentRouteCondition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GenerateRouteRequestCurrentRouteCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.GenerateRouteRequestCurrentRouteAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GenerateRouteRequestCurrentRouteAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.GenerateRouteRequestCurrentRouteActionHeader>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GenerateRouteRequestCurrentRouteActionHeader))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateRouteVersionsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateRouteVersionsRequestAction), TypeInfoPropertyName = "UpdateRouteVersionsRequestAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesFilter), TypeInfoPropertyName = "GetRoutesFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<bool?, global::Vercel.GetRoutesDiff2?>), TypeInfoPropertyName = "OneOfBooleanGetRoutesDiff22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesDiff2), TypeInfoPropertyName = "GetRoutesDiff22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<object, global::Vercel.GetRoutesResponseVariant2, global::Vercel.GetRoutesResponseVariant3, global::Vercel.GetRoutesResponseVariant4>), TypeInfoPropertyName = "OneOfObjectGetRoutesResponseVariant2GetRoutesResponseVariant3GetRoutesResponseVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant2Version))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant3Version))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant4Limit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesResponseVariant4Version))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.StageRoutesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.StageRoutesResponseVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRouteResponseVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.DeleteRoutesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.DeleteRoutesResponseVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRouteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRouteResponseVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GenerateRouteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GenerateRouteResponseRoute))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.GenerateRouteResponseRouteAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GenerateRouteResponseRouteAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.GenerateRouteResponseRouteActionHeader>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GenerateRouteResponseRouteActionHeader))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GenerateRouteResponseRouteActionHeaderOp), TypeInfoPropertyName = "GenerateRouteResponseRouteActionHeaderOp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GenerateRouteResponseRouteActionSubType), TypeInfoPropertyName = "GenerateRouteResponseRouteActionSubType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GenerateRouteResponseRouteActionType), TypeInfoPropertyName = "GenerateRouteResponseRouteActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.GenerateRouteResponseRouteCondition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GenerateRouteResponseRouteCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GenerateRouteResponseRouteConditionField), TypeInfoPropertyName = "GenerateRouteResponseRouteConditionField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GenerateRouteResponseRouteConditionOperator), TypeInfoPropertyName = "GenerateRouteResponseRouteConditionOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GenerateRouteResponseRoutePathCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GenerateRouteResponseRoutePathConditionSyntax), TypeInfoPropertyName = "GenerateRouteResponseRoutePathConditionSyntax2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRouteVersionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.GetRouteVersionsResponseVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRouteVersionsResponseVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateRouteVersionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateRouteVersionsResponseVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string?>), TypeInfoPropertyName = "DictionaryStringString_System_Collections_Generic_Dictionary_string_string_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKShareda5bc732e1681aab5RouteType?), TypeInfoPropertyName = "NullableAutoSDKShareda5bc732e1681aab5RouteType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKShareda5bc732e1681aab5SrcSyntax?), TypeInfoPropertyName = "NullableAutoSDKShareda5bc732e1681aab5SrcSyntax2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKSharedb49e2a5785c6f473RouteType?), TypeInfoPropertyName = "NullableAutoSDKSharedb49e2a5785c6f473RouteType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKSharedb49e2a5785c6f473SrcSyntax?), TypeInfoPropertyName = "NullableAutoSDKSharedb49e2a5785c6f473SrcSyntax2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateRouteVersionsRequestAction?), TypeInfoPropertyName = "NullableUpdateRouteVersionsRequestAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesFilter?), TypeInfoPropertyName = "NullableGetRoutesFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<bool?, global::Vercel.GetRoutesDiff2?>?), TypeInfoPropertyName = "NullableOneOfBooleanGetRoutesDiff22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRoutesDiff2?), TypeInfoPropertyName = "NullableGetRoutesDiff22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<object, global::Vercel.GetRoutesResponseVariant2, global::Vercel.GetRoutesResponseVariant3, global::Vercel.GetRoutesResponseVariant4>?), TypeInfoPropertyName = "NullableOneOfObjectGetRoutesResponseVariant2GetRoutesResponseVariant3GetRoutesResponseVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GenerateRouteResponseRouteActionHeaderOp?), TypeInfoPropertyName = "NullableGenerateRouteResponseRouteActionHeaderOp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GenerateRouteResponseRouteActionSubType?), TypeInfoPropertyName = "NullableGenerateRouteResponseRouteActionSubType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GenerateRouteResponseRouteActionType?), TypeInfoPropertyName = "NullableGenerateRouteResponseRouteActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GenerateRouteResponseRouteConditionField?), TypeInfoPropertyName = "NullableGenerateRouteResponseRouteConditionField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GenerateRouteResponseRouteConditionOperator?), TypeInfoPropertyName = "NullableGenerateRouteResponseRouteConditionOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GenerateRouteResponseRoutePathConditionSyntax?), TypeInfoPropertyName = "NullableGenerateRouteResponseRoutePathConditionSyntax2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.AutoSDKSharedb49e2a5785c6f473>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.GenerateRouteRequestCurrentRouteCondition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.GenerateRouteRequestCurrentRouteAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.GenerateRouteRequestCurrentRouteActionHeader>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.GenerateRouteResponseRouteAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.GenerateRouteResponseRouteActionHeader>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.GenerateRouteResponseRouteCondition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.GetRouteVersionsResponseVersion>))]
    internal sealed partial class ProjectRoutesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectRoutesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ProjectRoutesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ProjectRoutesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<bool?, global::Vercel.GetRoutesDiff2?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, global::Vercel.GetRoutesResponseVariant2, global::Vercel.GetRoutesResponseVariant3, global::Vercel.GetRoutesResponseVariant4>());
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
                    typeToConvert == typeof(global::Vercel.AutoSDKShareda5bc732e1681aab5RouteType)

                    || typeToConvert == typeof(global::Vercel.AutoSDKShareda5bc732e1681aab5RouteType?)

                    || typeToConvert == typeof(global::Vercel.AutoSDKShareda5bc732e1681aab5SrcSyntax)

                    || typeToConvert == typeof(global::Vercel.AutoSDKShareda5bc732e1681aab5SrcSyntax?)

                    || typeToConvert == typeof(global::Vercel.AutoSDKSharedb49e2a5785c6f473RouteType)

                    || typeToConvert == typeof(global::Vercel.AutoSDKSharedb49e2a5785c6f473RouteType?)

                    || typeToConvert == typeof(global::Vercel.AutoSDKSharedb49e2a5785c6f473SrcSyntax)

                    || typeToConvert == typeof(global::Vercel.AutoSDKSharedb49e2a5785c6f473SrcSyntax?)

                    || typeToConvert == typeof(global::Vercel.UpdateRouteVersionsRequestAction)

                    || typeToConvert == typeof(global::Vercel.UpdateRouteVersionsRequestAction?)

                    || typeToConvert == typeof(global::Vercel.GetRoutesFilter)

                    || typeToConvert == typeof(global::Vercel.GetRoutesFilter?)

                    || typeToConvert == typeof(global::Vercel.GetRoutesDiff2)

                    || typeToConvert == typeof(global::Vercel.GetRoutesDiff2?)

                    || typeToConvert == typeof(global::Vercel.GenerateRouteResponseRouteActionHeaderOp)

                    || typeToConvert == typeof(global::Vercel.GenerateRouteResponseRouteActionHeaderOp?)

                    || typeToConvert == typeof(global::Vercel.GenerateRouteResponseRouteActionSubType)

                    || typeToConvert == typeof(global::Vercel.GenerateRouteResponseRouteActionSubType?)

                    || typeToConvert == typeof(global::Vercel.GenerateRouteResponseRouteActionType)

                    || typeToConvert == typeof(global::Vercel.GenerateRouteResponseRouteActionType?)

                    || typeToConvert == typeof(global::Vercel.GenerateRouteResponseRouteConditionField)

                    || typeToConvert == typeof(global::Vercel.GenerateRouteResponseRouteConditionField?)

                    || typeToConvert == typeof(global::Vercel.GenerateRouteResponseRouteConditionOperator)

                    || typeToConvert == typeof(global::Vercel.GenerateRouteResponseRouteConditionOperator?)

                    || typeToConvert == typeof(global::Vercel.GenerateRouteResponseRoutePathConditionSyntax)

                    || typeToConvert == typeof(global::Vercel.GenerateRouteResponseRoutePathConditionSyntax?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Vercel.AutoSDKShareda5bc732e1681aab5RouteType))
                {
                    return new global::Vercel.JsonConverters.AutoSDKShareda5bc732e1681aab5RouteTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AutoSDKShareda5bc732e1681aab5RouteType?))
                {
                    return new global::Vercel.JsonConverters.AutoSDKShareda5bc732e1681aab5RouteTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AutoSDKShareda5bc732e1681aab5SrcSyntax))
                {
                    return new global::Vercel.JsonConverters.AutoSDKShareda5bc732e1681aab5SrcSyntaxJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AutoSDKShareda5bc732e1681aab5SrcSyntax?))
                {
                    return new global::Vercel.JsonConverters.AutoSDKShareda5bc732e1681aab5SrcSyntaxNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AutoSDKSharedb49e2a5785c6f473RouteType))
                {
                    return new global::Vercel.JsonConverters.AutoSDKSharedb49e2a5785c6f473RouteTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AutoSDKSharedb49e2a5785c6f473RouteType?))
                {
                    return new global::Vercel.JsonConverters.AutoSDKSharedb49e2a5785c6f473RouteTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AutoSDKSharedb49e2a5785c6f473SrcSyntax))
                {
                    return new global::Vercel.JsonConverters.AutoSDKSharedb49e2a5785c6f473SrcSyntaxJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AutoSDKSharedb49e2a5785c6f473SrcSyntax?))
                {
                    return new global::Vercel.JsonConverters.AutoSDKSharedb49e2a5785c6f473SrcSyntaxNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpdateRouteVersionsRequestAction))
                {
                    return new global::Vercel.JsonConverters.UpdateRouteVersionsRequestActionJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpdateRouteVersionsRequestAction?))
                {
                    return new global::Vercel.JsonConverters.UpdateRouteVersionsRequestActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesFilter))
                {
                    return new global::Vercel.JsonConverters.GetRoutesFilterJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesFilter?))
                {
                    return new global::Vercel.JsonConverters.GetRoutesFilterNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesDiff2))
                {
                    return new global::Vercel.JsonConverters.GetRoutesDiff2JsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRoutesDiff2?))
                {
                    return new global::Vercel.JsonConverters.GetRoutesDiff2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GenerateRouteResponseRouteActionHeaderOp))
                {
                    return new global::Vercel.JsonConverters.GenerateRouteResponseRouteActionHeaderOpJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GenerateRouteResponseRouteActionHeaderOp?))
                {
                    return new global::Vercel.JsonConverters.GenerateRouteResponseRouteActionHeaderOpNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GenerateRouteResponseRouteActionSubType))
                {
                    return new global::Vercel.JsonConverters.GenerateRouteResponseRouteActionSubTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GenerateRouteResponseRouteActionSubType?))
                {
                    return new global::Vercel.JsonConverters.GenerateRouteResponseRouteActionSubTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GenerateRouteResponseRouteActionType))
                {
                    return new global::Vercel.JsonConverters.GenerateRouteResponseRouteActionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GenerateRouteResponseRouteActionType?))
                {
                    return new global::Vercel.JsonConverters.GenerateRouteResponseRouteActionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GenerateRouteResponseRouteConditionField))
                {
                    return new global::Vercel.JsonConverters.GenerateRouteResponseRouteConditionFieldJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GenerateRouteResponseRouteConditionField?))
                {
                    return new global::Vercel.JsonConverters.GenerateRouteResponseRouteConditionFieldNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GenerateRouteResponseRouteConditionOperator))
                {
                    return new global::Vercel.JsonConverters.GenerateRouteResponseRouteConditionOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GenerateRouteResponseRouteConditionOperator?))
                {
                    return new global::Vercel.JsonConverters.GenerateRouteResponseRouteConditionOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GenerateRouteResponseRoutePathConditionSyntax))
                {
                    return new global::Vercel.JsonConverters.GenerateRouteResponseRoutePathConditionSyntaxJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GenerateRouteResponseRoutePathConditionSyntax?))
                {
                    return new global::Vercel.JsonConverters.GenerateRouteResponseRoutePathConditionSyntaxNullableJsonConverter();
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
                    0 => new ProjectRoutesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => global::Vercel.PartitionCoreSourceGenerationContext.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}