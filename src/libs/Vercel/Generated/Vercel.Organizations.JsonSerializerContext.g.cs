
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.Organization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OrganizationTeamListItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OrganizationTeamListItemBillingPlan), TypeInfoPropertyName = "OrganizationTeamListItemBillingPlan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OrganizationTeamListItemDsyncMode), TypeInfoPropertyName = "OrganizationTeamListItemDsyncMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OrganizationTeamListItemSsoMode), TypeInfoPropertyName = "OrganizationTeamListItemSsoMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OrganizationTeam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OrganizationTeamBillingPlan), TypeInfoPropertyName = "OrganizationTeamBillingPlan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OrganizationTeamDsyncMode), TypeInfoPropertyName = "OrganizationTeamDsyncMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OrganizationTeamSsoMode), TypeInfoPropertyName = "OrganizationTeamSsoMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateOrganizationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateOrganizationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddOrganizationTeamRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListOrganizationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.Organization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListOrganizationTeamsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.OrganizationTeamListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.RemoveOrganizationTeamResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string?>), TypeInfoPropertyName = "DictionaryStringString_System_Collections_Generic_Dictionary_string_string_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OrganizationTeamListItemBillingPlan?), TypeInfoPropertyName = "NullableOrganizationTeamListItemBillingPlan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OrganizationTeamListItemDsyncMode?), TypeInfoPropertyName = "NullableOrganizationTeamListItemDsyncMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OrganizationTeamListItemSsoMode?), TypeInfoPropertyName = "NullableOrganizationTeamListItemSsoMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OrganizationTeamBillingPlan?), TypeInfoPropertyName = "NullableOrganizationTeamBillingPlan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OrganizationTeamDsyncMode?), TypeInfoPropertyName = "NullableOrganizationTeamDsyncMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OrganizationTeamSsoMode?), TypeInfoPropertyName = "NullableOrganizationTeamSsoMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.Organization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.OrganizationTeamListItem>))]
    internal sealed partial class OrganizationsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OrganizationsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static OrganizationsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private OrganizationsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Vercel.OrganizationTeamListItemBillingPlan)

                    || typeToConvert == typeof(global::Vercel.OrganizationTeamListItemBillingPlan?)

                    || typeToConvert == typeof(global::Vercel.OrganizationTeamListItemDsyncMode)

                    || typeToConvert == typeof(global::Vercel.OrganizationTeamListItemDsyncMode?)

                    || typeToConvert == typeof(global::Vercel.OrganizationTeamListItemSsoMode)

                    || typeToConvert == typeof(global::Vercel.OrganizationTeamListItemSsoMode?)

                    || typeToConvert == typeof(global::Vercel.OrganizationTeamBillingPlan)

                    || typeToConvert == typeof(global::Vercel.OrganizationTeamBillingPlan?)

                    || typeToConvert == typeof(global::Vercel.OrganizationTeamDsyncMode)

                    || typeToConvert == typeof(global::Vercel.OrganizationTeamDsyncMode?)

                    || typeToConvert == typeof(global::Vercel.OrganizationTeamSsoMode)

                    || typeToConvert == typeof(global::Vercel.OrganizationTeamSsoMode?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Vercel.OrganizationTeamListItemBillingPlan))
                {
                    return new global::Vercel.JsonConverters.OrganizationTeamListItemBillingPlanJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.OrganizationTeamListItemBillingPlan?))
                {
                    return new global::Vercel.JsonConverters.OrganizationTeamListItemBillingPlanNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.OrganizationTeamListItemDsyncMode))
                {
                    return new global::Vercel.JsonConverters.OrganizationTeamListItemDsyncModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.OrganizationTeamListItemDsyncMode?))
                {
                    return new global::Vercel.JsonConverters.OrganizationTeamListItemDsyncModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.OrganizationTeamListItemSsoMode))
                {
                    return new global::Vercel.JsonConverters.OrganizationTeamListItemSsoModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.OrganizationTeamListItemSsoMode?))
                {
                    return new global::Vercel.JsonConverters.OrganizationTeamListItemSsoModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.OrganizationTeamBillingPlan))
                {
                    return new global::Vercel.JsonConverters.OrganizationTeamBillingPlanJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.OrganizationTeamBillingPlan?))
                {
                    return new global::Vercel.JsonConverters.OrganizationTeamBillingPlanNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.OrganizationTeamDsyncMode))
                {
                    return new global::Vercel.JsonConverters.OrganizationTeamDsyncModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.OrganizationTeamDsyncMode?))
                {
                    return new global::Vercel.JsonConverters.OrganizationTeamDsyncModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.OrganizationTeamSsoMode))
                {
                    return new global::Vercel.JsonConverters.OrganizationTeamSsoModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.OrganizationTeamSsoMode?))
                {
                    return new global::Vercel.JsonConverters.OrganizationTeamSsoModeNullableJsonConverter();
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
                    0 => new OrganizationsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => global::Vercel.PartitionCoreSourceGenerationContext.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}