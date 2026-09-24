
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GlobalConfigItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GlobalConfigToken))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateEdgeConfigRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateEdgeConfigRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.PatchEdgeConfigItemsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.PatchEdgeConfigItemsRequestItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.PatchEdgeConfigItemsRequestItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.PatchEdgeConfigItemsRequestItemOperation), TypeInfoPropertyName = "PatchEdgeConfigItemsRequestItemOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.PatchEdgeConfigItemsRequestItemEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.PatchEdgeConfigItemsRequestItemEnum2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.PatchEdgeConfigItemsRequestItemEnumOperation2), TypeInfoPropertyName = "PatchEdgeConfigItemsRequestItemEnumOperation22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.PatchEdgeConfigItemsRequestItemEnum3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.PatchEdgeConfigItemsRequestItemEnumOperation3), TypeInfoPropertyName = "PatchEdgeConfigItemsRequestItemEnumOperation32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.PatchEdgeConfigItemsRequestItemEnum4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.PatchEdgeConfigSchemaRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.DeleteEdgeConfigTokensRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateEdgeConfigTokenRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetEdgeConfigsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.GetEdgeConfigsResponsePurposeVariant1, global::Vercel.GetEdgeConfigsResponsePurposeVariant2>), TypeInfoPropertyName = "OneOfGetEdgeConfigsResponsePurposeVariant1GetEdgeConfigsResponsePurposeVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetEdgeConfigsResponsePurposeVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetEdgeConfigsResponsePurposeVariant1Type), TypeInfoPropertyName = "GetEdgeConfigsResponsePurposeVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetEdgeConfigsResponsePurposeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetEdgeConfigsResponsePurposeVariant2Type), TypeInfoPropertyName = "GetEdgeConfigsResponsePurposeVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetEdgeConfigsResponseTransfer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateEdgeConfigResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.CreateEdgeConfigResponsePurposeVariant1, global::Vercel.CreateEdgeConfigResponsePurposeVariant2>), TypeInfoPropertyName = "OneOfCreateEdgeConfigResponsePurposeVariant1CreateEdgeConfigResponsePurposeVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateEdgeConfigResponsePurposeVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateEdgeConfigResponsePurposeVariant1Type), TypeInfoPropertyName = "CreateEdgeConfigResponsePurposeVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateEdgeConfigResponsePurposeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateEdgeConfigResponsePurposeVariant2Type), TypeInfoPropertyName = "CreateEdgeConfigResponsePurposeVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateEdgeConfigResponseTransfer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetEdgeConfigResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.GetEdgeConfigResponsePurposeVariant1, global::Vercel.GetEdgeConfigResponsePurposeVariant2>), TypeInfoPropertyName = "OneOfGetEdgeConfigResponsePurposeVariant1GetEdgeConfigResponsePurposeVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetEdgeConfigResponsePurposeVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetEdgeConfigResponsePurposeVariant1Type), TypeInfoPropertyName = "GetEdgeConfigResponsePurposeVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetEdgeConfigResponsePurposeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetEdgeConfigResponsePurposeVariant2Type), TypeInfoPropertyName = "GetEdgeConfigResponsePurposeVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetEdgeConfigResponseTransfer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateEdgeConfigResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.UpdateEdgeConfigResponsePurposeVariant1, global::Vercel.UpdateEdgeConfigResponsePurposeVariant2>), TypeInfoPropertyName = "OneOfUpdateEdgeConfigResponsePurposeVariant1UpdateEdgeConfigResponsePurposeVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateEdgeConfigResponsePurposeVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateEdgeConfigResponsePurposeVariant1Type), TypeInfoPropertyName = "UpdateEdgeConfigResponsePurposeVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateEdgeConfigResponsePurposeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateEdgeConfigResponsePurposeVariant2Type), TypeInfoPropertyName = "UpdateEdgeConfigResponsePurposeVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateEdgeConfigResponseTransfer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.GlobalConfigItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.PatchEdgeConfigItemsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateEdgeConfigTokenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.GetEdgeConfigBackupResponseVariant1, global::Vercel.GetEdgeConfigBackupResponseVariant2>), TypeInfoPropertyName = "OneOfGetEdgeConfigBackupResponseVariant1GetEdgeConfigBackupResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetEdgeConfigBackupResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetEdgeConfigBackupResponseVariant1Backup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Vercel.GetEdgeConfigBackupResponseVariant1BackupItems2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetEdgeConfigBackupResponseVariant1BackupItems2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetEdgeConfigBackupResponseVariant1Metadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetEdgeConfigBackupResponseVariant1User))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetEdgeConfigBackupResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetEdgeConfigBackupResponseVariant2Backup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Vercel.GetEdgeConfigBackupResponseVariant2BackupItems2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetEdgeConfigBackupResponseVariant2BackupItems2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetEdgeConfigBackupResponseVariant2Metadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetEdgeConfigBackupResponseVariant2User))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.RestoreEdgeConfigBackupResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.RestoreEdgeConfigBackupResponseStatus), TypeInfoPropertyName = "RestoreEdgeConfigBackupResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetEdgeConfigBackupsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.GetEdgeConfigBackupsResponseBackup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetEdgeConfigBackupsResponseBackup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetEdgeConfigBackupsResponseBackupMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetEdgeConfigBackupsResponsePagination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GlobalConfigItemValue?), TypeInfoPropertyName = "NullableGlobalConfigItemValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.PatchEdgeConfigItemsRequestItemOperation?), TypeInfoPropertyName = "NullablePatchEdgeConfigItemsRequestItemOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.PatchEdgeConfigItemsRequestItemEnumOperation2?), TypeInfoPropertyName = "NullablePatchEdgeConfigItemsRequestItemEnumOperation22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.PatchEdgeConfigItemsRequestItemEnumOperation3?), TypeInfoPropertyName = "NullablePatchEdgeConfigItemsRequestItemEnumOperation32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.GetEdgeConfigsResponsePurposeVariant1, global::Vercel.GetEdgeConfigsResponsePurposeVariant2>?), TypeInfoPropertyName = "NullableOneOfGetEdgeConfigsResponsePurposeVariant1GetEdgeConfigsResponsePurposeVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetEdgeConfigsResponsePurposeVariant1Type?), TypeInfoPropertyName = "NullableGetEdgeConfigsResponsePurposeVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetEdgeConfigsResponsePurposeVariant2Type?), TypeInfoPropertyName = "NullableGetEdgeConfigsResponsePurposeVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.CreateEdgeConfigResponsePurposeVariant1, global::Vercel.CreateEdgeConfigResponsePurposeVariant2>?), TypeInfoPropertyName = "NullableOneOfCreateEdgeConfigResponsePurposeVariant1CreateEdgeConfigResponsePurposeVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateEdgeConfigResponsePurposeVariant1Type?), TypeInfoPropertyName = "NullableCreateEdgeConfigResponsePurposeVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateEdgeConfigResponsePurposeVariant2Type?), TypeInfoPropertyName = "NullableCreateEdgeConfigResponsePurposeVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.GetEdgeConfigResponsePurposeVariant1, global::Vercel.GetEdgeConfigResponsePurposeVariant2>?), TypeInfoPropertyName = "NullableOneOfGetEdgeConfigResponsePurposeVariant1GetEdgeConfigResponsePurposeVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetEdgeConfigResponsePurposeVariant1Type?), TypeInfoPropertyName = "NullableGetEdgeConfigResponsePurposeVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetEdgeConfigResponsePurposeVariant2Type?), TypeInfoPropertyName = "NullableGetEdgeConfigResponsePurposeVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.UpdateEdgeConfigResponsePurposeVariant1, global::Vercel.UpdateEdgeConfigResponsePurposeVariant2>?), TypeInfoPropertyName = "NullableOneOfUpdateEdgeConfigResponsePurposeVariant1UpdateEdgeConfigResponsePurposeVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateEdgeConfigResponsePurposeVariant1Type?), TypeInfoPropertyName = "NullableUpdateEdgeConfigResponsePurposeVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateEdgeConfigResponsePurposeVariant2Type?), TypeInfoPropertyName = "NullableUpdateEdgeConfigResponsePurposeVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.GetEdgeConfigBackupResponseVariant1, global::Vercel.GetEdgeConfigBackupResponseVariant2>?), TypeInfoPropertyName = "NullableOneOfGetEdgeConfigBackupResponseVariant1GetEdgeConfigBackupResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.RestoreEdgeConfigBackupResponseStatus?), TypeInfoPropertyName = "NullableRestoreEdgeConfigBackupResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.GlobalConfigItemValue?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.PatchEdgeConfigItemsRequestItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.GlobalConfigItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.GetEdgeConfigBackupsResponseBackup>))]
    internal sealed partial class GlobalConfigSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GlobalConfigSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static GlobalConfigSourceGenerationContext Default { get; } = new(DefaultOptions);

        private GlobalConfigSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.GetEdgeConfigsResponsePurposeVariant1, global::Vercel.GetEdgeConfigsResponsePurposeVariant2>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.CreateEdgeConfigResponsePurposeVariant1, global::Vercel.CreateEdgeConfigResponsePurposeVariant2>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.GetEdgeConfigResponsePurposeVariant1, global::Vercel.GetEdgeConfigResponsePurposeVariant2>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.UpdateEdgeConfigResponsePurposeVariant1, global::Vercel.UpdateEdgeConfigResponsePurposeVariant2>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.GetEdgeConfigBackupResponseVariant1, global::Vercel.GetEdgeConfigBackupResponseVariant2>());
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
                    typeToConvert == typeof(global::Vercel.PatchEdgeConfigItemsRequestItemOperation)

                    || typeToConvert == typeof(global::Vercel.PatchEdgeConfigItemsRequestItemOperation?)

                    || typeToConvert == typeof(global::Vercel.PatchEdgeConfigItemsRequestItemEnumOperation2)

                    || typeToConvert == typeof(global::Vercel.PatchEdgeConfigItemsRequestItemEnumOperation2?)

                    || typeToConvert == typeof(global::Vercel.PatchEdgeConfigItemsRequestItemEnumOperation3)

                    || typeToConvert == typeof(global::Vercel.PatchEdgeConfigItemsRequestItemEnumOperation3?)

                    || typeToConvert == typeof(global::Vercel.GetEdgeConfigsResponsePurposeVariant1Type)

                    || typeToConvert == typeof(global::Vercel.GetEdgeConfigsResponsePurposeVariant1Type?)

                    || typeToConvert == typeof(global::Vercel.GetEdgeConfigsResponsePurposeVariant2Type)

                    || typeToConvert == typeof(global::Vercel.GetEdgeConfigsResponsePurposeVariant2Type?)

                    || typeToConvert == typeof(global::Vercel.CreateEdgeConfigResponsePurposeVariant1Type)

                    || typeToConvert == typeof(global::Vercel.CreateEdgeConfigResponsePurposeVariant1Type?)

                    || typeToConvert == typeof(global::Vercel.CreateEdgeConfigResponsePurposeVariant2Type)

                    || typeToConvert == typeof(global::Vercel.CreateEdgeConfigResponsePurposeVariant2Type?)

                    || typeToConvert == typeof(global::Vercel.GetEdgeConfigResponsePurposeVariant1Type)

                    || typeToConvert == typeof(global::Vercel.GetEdgeConfigResponsePurposeVariant1Type?)

                    || typeToConvert == typeof(global::Vercel.GetEdgeConfigResponsePurposeVariant2Type)

                    || typeToConvert == typeof(global::Vercel.GetEdgeConfigResponsePurposeVariant2Type?)

                    || typeToConvert == typeof(global::Vercel.UpdateEdgeConfigResponsePurposeVariant1Type)

                    || typeToConvert == typeof(global::Vercel.UpdateEdgeConfigResponsePurposeVariant1Type?)

                    || typeToConvert == typeof(global::Vercel.UpdateEdgeConfigResponsePurposeVariant2Type)

                    || typeToConvert == typeof(global::Vercel.UpdateEdgeConfigResponsePurposeVariant2Type?)

                    || typeToConvert == typeof(global::Vercel.RestoreEdgeConfigBackupResponseStatus)

                    || typeToConvert == typeof(global::Vercel.RestoreEdgeConfigBackupResponseStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Vercel.PatchEdgeConfigItemsRequestItemOperation))
                {
                    return new global::Vercel.JsonConverters.PatchEdgeConfigItemsRequestItemOperationJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.PatchEdgeConfigItemsRequestItemOperation?))
                {
                    return new global::Vercel.JsonConverters.PatchEdgeConfigItemsRequestItemOperationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.PatchEdgeConfigItemsRequestItemEnumOperation2))
                {
                    return new global::Vercel.JsonConverters.PatchEdgeConfigItemsRequestItemEnumOperation2JsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.PatchEdgeConfigItemsRequestItemEnumOperation2?))
                {
                    return new global::Vercel.JsonConverters.PatchEdgeConfigItemsRequestItemEnumOperation2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.PatchEdgeConfigItemsRequestItemEnumOperation3))
                {
                    return new global::Vercel.JsonConverters.PatchEdgeConfigItemsRequestItemEnumOperation3JsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.PatchEdgeConfigItemsRequestItemEnumOperation3?))
                {
                    return new global::Vercel.JsonConverters.PatchEdgeConfigItemsRequestItemEnumOperation3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetEdgeConfigsResponsePurposeVariant1Type))
                {
                    return new global::Vercel.JsonConverters.GetEdgeConfigsResponsePurposeVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetEdgeConfigsResponsePurposeVariant1Type?))
                {
                    return new global::Vercel.JsonConverters.GetEdgeConfigsResponsePurposeVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetEdgeConfigsResponsePurposeVariant2Type))
                {
                    return new global::Vercel.JsonConverters.GetEdgeConfigsResponsePurposeVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetEdgeConfigsResponsePurposeVariant2Type?))
                {
                    return new global::Vercel.JsonConverters.GetEdgeConfigsResponsePurposeVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateEdgeConfigResponsePurposeVariant1Type))
                {
                    return new global::Vercel.JsonConverters.CreateEdgeConfigResponsePurposeVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateEdgeConfigResponsePurposeVariant1Type?))
                {
                    return new global::Vercel.JsonConverters.CreateEdgeConfigResponsePurposeVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateEdgeConfigResponsePurposeVariant2Type))
                {
                    return new global::Vercel.JsonConverters.CreateEdgeConfigResponsePurposeVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateEdgeConfigResponsePurposeVariant2Type?))
                {
                    return new global::Vercel.JsonConverters.CreateEdgeConfigResponsePurposeVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetEdgeConfigResponsePurposeVariant1Type))
                {
                    return new global::Vercel.JsonConverters.GetEdgeConfigResponsePurposeVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetEdgeConfigResponsePurposeVariant1Type?))
                {
                    return new global::Vercel.JsonConverters.GetEdgeConfigResponsePurposeVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetEdgeConfigResponsePurposeVariant2Type))
                {
                    return new global::Vercel.JsonConverters.GetEdgeConfigResponsePurposeVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetEdgeConfigResponsePurposeVariant2Type?))
                {
                    return new global::Vercel.JsonConverters.GetEdgeConfigResponsePurposeVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpdateEdgeConfigResponsePurposeVariant1Type))
                {
                    return new global::Vercel.JsonConverters.UpdateEdgeConfigResponsePurposeVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpdateEdgeConfigResponsePurposeVariant1Type?))
                {
                    return new global::Vercel.JsonConverters.UpdateEdgeConfigResponsePurposeVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpdateEdgeConfigResponsePurposeVariant2Type))
                {
                    return new global::Vercel.JsonConverters.UpdateEdgeConfigResponsePurposeVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpdateEdgeConfigResponsePurposeVariant2Type?))
                {
                    return new global::Vercel.JsonConverters.UpdateEdgeConfigResponsePurposeVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.RestoreEdgeConfigBackupResponseStatus))
                {
                    return new global::Vercel.JsonConverters.RestoreEdgeConfigBackupResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.RestoreEdgeConfigBackupResponseStatus?))
                {
                    return new global::Vercel.JsonConverters.RestoreEdgeConfigBackupResponseStatusNullableJsonConverter();
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
                    0 => new GlobalConfigSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}