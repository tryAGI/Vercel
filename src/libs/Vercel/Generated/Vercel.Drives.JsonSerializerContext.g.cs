
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrCreateDriveV1Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrCreateDriveV1RequestRegion), TypeInfoPropertyName = "GetOrCreateDriveV1RequestRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ForkDriveV1Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListDrivesV1SortBy), TypeInfoPropertyName = "ListDrivesV1SortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListDrivesV1SortOrder), TypeInfoPropertyName = "ListDrivesV1SortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListDrivesV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListDrivesV1ResponsePagination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetDriveV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrCreateDriveV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrCreateDriveV1Response2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.DeleteDriveV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ForkDriveV1Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string?>), TypeInfoPropertyName = "DictionaryStringString_System_Collections_Generic_Dictionary_string_string_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetOrCreateDriveV1RequestRegion?), TypeInfoPropertyName = "NullableGetOrCreateDriveV1RequestRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListDrivesV1SortBy?), TypeInfoPropertyName = "NullableListDrivesV1SortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListDrivesV1SortOrder?), TypeInfoPropertyName = "NullableListDrivesV1SortOrder2")]
    internal sealed partial class DrivesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DrivesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static DrivesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private DrivesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Vercel.GetOrCreateDriveV1RequestRegion)

                    || typeToConvert == typeof(global::Vercel.GetOrCreateDriveV1RequestRegion?)

                    || typeToConvert == typeof(global::Vercel.ListDrivesV1SortBy)

                    || typeToConvert == typeof(global::Vercel.ListDrivesV1SortBy?)

                    || typeToConvert == typeof(global::Vercel.ListDrivesV1SortOrder)

                    || typeToConvert == typeof(global::Vercel.ListDrivesV1SortOrder?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Vercel.GetOrCreateDriveV1RequestRegion))
                {
                    return new global::Vercel.JsonConverters.GetOrCreateDriveV1RequestRegionJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetOrCreateDriveV1RequestRegion?))
                {
                    return new global::Vercel.JsonConverters.GetOrCreateDriveV1RequestRegionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ListDrivesV1SortBy))
                {
                    return new global::Vercel.JsonConverters.ListDrivesV1SortByJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ListDrivesV1SortBy?))
                {
                    return new global::Vercel.JsonConverters.ListDrivesV1SortByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ListDrivesV1SortOrder))
                {
                    return new global::Vercel.JsonConverters.ListDrivesV1SortOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ListDrivesV1SortOrder?))
                {
                    return new global::Vercel.JsonConverters.ListDrivesV1SortOrderNullableJsonConverter();
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
                    0 => new DrivesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => global::Vercel.PartitionCoreSourceGenerationContext.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}