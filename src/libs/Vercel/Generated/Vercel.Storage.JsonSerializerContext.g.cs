
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::System.Collections.Generic.IList<global::Vercel.GetStorageStoresByIdResponseStoreProjectFilterGitProvider>, global::Vercel.GetStorageStoresByIdResponseStoreProjectFilterGitProviders?>), TypeInfoPropertyName = "GetStorageStoresByIdResponseStoreProjectFilterGitProviders_0a34ff62f0ff0f26")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::System.Collections.Generic.IList<global::Vercel.CreateStorageStoresBlobResponseStoreProjectFilterGitProvider>, global::Vercel.CreateStorageStoresBlobResponseStoreProjectFilterGitProviders?>), TypeInfoPropertyName = "CreateStorageStoresBlobResponseStoreProjectFilterGitProviders_82a156b6a4d09885")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::System.Collections.Generic.IList<global::Vercel.GetStorageStoresByIdResponseStoreProjectFilterGitProvider>, global::Vercel.GetStorageStoresByIdResponseStoreProjectFilterGitProviders?>?), TypeInfoPropertyName = "GetStorageStoresByIdResponseStoreProjectFilterGitProviders_85bb75bc47869be1")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::System.Collections.Generic.IList<global::Vercel.CreateStorageStoresBlobResponseStoreProjectFilterGitProvider>, global::Vercel.CreateStorageStoresBlobResponseStoreProjectFilterGitProviders?>?), TypeInfoPropertyName = "CreateStorageStoresBlobResponseStoreProjectFilterGitProviders_09bc542c96466396")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::System.Collections.Generic.List<global::Vercel.GetStorageStoresByIdResponseStoreProjectFilterGitProvider>, global::Vercel.GetStorageStoresByIdResponseStoreProjectFilterGitProviders?>), TypeInfoPropertyName = "GetStorageStoresByIdResponseStoreProjectFilterGitProviders_36eb3ecf9ad87902")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::System.Collections.Generic.List<global::Vercel.CreateStorageStoresBlobResponseStoreProjectFilterGitProvider>, global::Vercel.CreateStorageStoresBlobResponseStoreProjectFilterGitProviders?>), TypeInfoPropertyName = "CreateStorageStoresBlobResponseStoreProjectFilterGitProviders_aa7865470a6d78c7")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateStorageStoresBlobRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateStorageStoresBlobRequestRegion), TypeInfoPropertyName = "CreateStorageStoresBlobRequestRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateStorageStoresBlobRequestAccess), TypeInfoPropertyName = "CreateStorageStoresBlobRequestAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetStorageStoresByIdResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetStorageStoresByIdResponseStore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetStorageStoresByIdResponseStoreProjectFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetStorageStoresByIdResponseStoreProjectFilterGit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.GetStorageStoresByIdResponseStoreProjectFilterGitProvider>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetStorageStoresByIdResponseStoreProjectFilterGitProvider), TypeInfoPropertyName = "GetStorageStoresByIdResponseStoreProjectFilterGitProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetStorageStoresByIdResponseStoreProjectFilterGitProviders), TypeInfoPropertyName = "GetStorageStoresByIdResponseStoreProjectFilterGitProviders2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.GetStorageStoresByIdResponseStoreProjectsMetadataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetStorageStoresByIdResponseStoreProjectsMetadataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetStorageStoresByIdResponseStoreProjectsMetadataItemDeployments))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.GetStorageStoresByIdResponseStoreProjectsMetadataItemDeploymentsAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetStorageStoresByIdResponseStoreProjectsMetadataItemDeploymentsAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetStorageStoresByIdResponseStoreProjectsMetadataItemFramework), TypeInfoPropertyName = "GetStorageStoresByIdResponseStoreProjectsMetadataItemFramework2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetStorageStoresByIdResponseStoreStatus), TypeInfoPropertyName = "GetStorageStoresByIdResponseStoreStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateStorageStoresBlobResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateStorageStoresBlobResponseStore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateStorageStoresBlobResponseStoreProjectFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateStorageStoresBlobResponseStoreProjectFilterGit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.CreateStorageStoresBlobResponseStoreProjectFilterGitProvider>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateStorageStoresBlobResponseStoreProjectFilterGitProvider), TypeInfoPropertyName = "CreateStorageStoresBlobResponseStoreProjectFilterGitProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateStorageStoresBlobResponseStoreProjectFilterGitProviders), TypeInfoPropertyName = "CreateStorageStoresBlobResponseStoreProjectFilterGitProviders2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.CreateStorageStoresBlobResponseStoreProjectsMetadataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateStorageStoresBlobResponseStoreProjectsMetadataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateStorageStoresBlobResponseStoreProjectsMetadataItemDeployments))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.CreateStorageStoresBlobResponseStoreProjectsMetadataItemDeploymentsAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateStorageStoresBlobResponseStoreProjectsMetadataItemDeploymentsAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateStorageStoresBlobResponseStoreProjectsMetadataItemFramework), TypeInfoPropertyName = "CreateStorageStoresBlobResponseStoreProjectsMetadataItemFramework2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateStorageStoresBlobResponseStoreStatus), TypeInfoPropertyName = "CreateStorageStoresBlobResponseStoreStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateStorageStoresBlobResponseStoreAccess), TypeInfoPropertyName = "CreateStorageStoresBlobResponseStoreAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateStorageStoresBlobResponseStoreKind), TypeInfoPropertyName = "CreateStorageStoresBlobResponseStoreKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateStorageStoresBlobResponseStoreRegion), TypeInfoPropertyName = "CreateStorageStoresBlobResponseStoreRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.DeleteStorageStoresBlobByIdResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateStorageStoresBlobRequestRegion?), TypeInfoPropertyName = "NullableCreateStorageStoresBlobRequestRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateStorageStoresBlobRequestAccess?), TypeInfoPropertyName = "NullableCreateStorageStoresBlobRequestAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetStorageStoresByIdResponseStoreProjectFilterGitProvider?), TypeInfoPropertyName = "NullableGetStorageStoresByIdResponseStoreProjectFilterGitProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetStorageStoresByIdResponseStoreProjectFilterGitProviders?), TypeInfoPropertyName = "NullableGetStorageStoresByIdResponseStoreProjectFilterGitProviders2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetStorageStoresByIdResponseStoreProjectsMetadataItemFramework?), TypeInfoPropertyName = "NullableGetStorageStoresByIdResponseStoreProjectsMetadataItemFramework2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetStorageStoresByIdResponseStoreStatus?), TypeInfoPropertyName = "NullableGetStorageStoresByIdResponseStoreStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateStorageStoresBlobResponseStoreProjectFilterGitProvider?), TypeInfoPropertyName = "NullableCreateStorageStoresBlobResponseStoreProjectFilterGitProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateStorageStoresBlobResponseStoreProjectFilterGitProviders?), TypeInfoPropertyName = "NullableCreateStorageStoresBlobResponseStoreProjectFilterGitProviders2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateStorageStoresBlobResponseStoreProjectsMetadataItemFramework?), TypeInfoPropertyName = "NullableCreateStorageStoresBlobResponseStoreProjectsMetadataItemFramework2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateStorageStoresBlobResponseStoreStatus?), TypeInfoPropertyName = "NullableCreateStorageStoresBlobResponseStoreStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateStorageStoresBlobResponseStoreAccess?), TypeInfoPropertyName = "NullableCreateStorageStoresBlobResponseStoreAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateStorageStoresBlobResponseStoreKind?), TypeInfoPropertyName = "NullableCreateStorageStoresBlobResponseStoreKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateStorageStoresBlobResponseStoreRegion?), TypeInfoPropertyName = "NullableCreateStorageStoresBlobResponseStoreRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.GetStorageStoresByIdResponseStoreProjectFilterGitProvider>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.GetStorageStoresByIdResponseStoreProjectsMetadataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.GetStorageStoresByIdResponseStoreProjectsMetadataItemDeploymentsAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.CreateStorageStoresBlobResponseStoreProjectFilterGitProvider>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.CreateStorageStoresBlobResponseStoreProjectsMetadataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.CreateStorageStoresBlobResponseStoreProjectsMetadataItemDeploymentsAction>))]
    internal sealed partial class StorageSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StorageSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static StorageSourceGenerationContext Default { get; } = new(DefaultOptions);

        private StorageSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<int?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, object, global::System.Collections.Generic.IList<object>, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<string, double?, bool?, object, global::System.Collections.Generic.IList<object>, string>());
            options.Converters.Add(new global::Vercel.JsonConverters.AnyOfJsonConverter<string, double?, bool?, object, global::System.Collections.Generic.IList<object>, string>());
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
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
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
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
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
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
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
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
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
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
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
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, object, global::System.Collections.Generic.IList<object>, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, object, global::System.Collections.Generic.IList<object>, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<double>, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<double>, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
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
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
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
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::Vercel.GetStorageStoresByIdResponseStoreProjectFilterGitProvider>, global::Vercel.GetStorageStoresByIdResponseStoreProjectFilterGitProviders?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::Vercel.CreateStorageStoresBlobResponseStoreProjectFilterGitProvider>, global::Vercel.CreateStorageStoresBlobResponseStoreProjectFilterGitProviders?>());
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
                    typeToConvert == typeof(global::Vercel.CreateStorageStoresBlobRequestRegion)

                    || typeToConvert == typeof(global::Vercel.CreateStorageStoresBlobRequestRegion?)

                    || typeToConvert == typeof(global::Vercel.CreateStorageStoresBlobRequestAccess)

                    || typeToConvert == typeof(global::Vercel.CreateStorageStoresBlobRequestAccess?)

                    || typeToConvert == typeof(global::Vercel.GetStorageStoresByIdResponseStoreProjectFilterGitProvider)

                    || typeToConvert == typeof(global::Vercel.GetStorageStoresByIdResponseStoreProjectFilterGitProvider?)

                    || typeToConvert == typeof(global::Vercel.GetStorageStoresByIdResponseStoreProjectFilterGitProviders)

                    || typeToConvert == typeof(global::Vercel.GetStorageStoresByIdResponseStoreProjectFilterGitProviders?)

                    || typeToConvert == typeof(global::Vercel.GetStorageStoresByIdResponseStoreProjectsMetadataItemFramework)

                    || typeToConvert == typeof(global::Vercel.GetStorageStoresByIdResponseStoreProjectsMetadataItemFramework?)

                    || typeToConvert == typeof(global::Vercel.GetStorageStoresByIdResponseStoreStatus)

                    || typeToConvert == typeof(global::Vercel.GetStorageStoresByIdResponseStoreStatus?)

                    || typeToConvert == typeof(global::Vercel.CreateStorageStoresBlobResponseStoreProjectFilterGitProvider)

                    || typeToConvert == typeof(global::Vercel.CreateStorageStoresBlobResponseStoreProjectFilterGitProvider?)

                    || typeToConvert == typeof(global::Vercel.CreateStorageStoresBlobResponseStoreProjectFilterGitProviders)

                    || typeToConvert == typeof(global::Vercel.CreateStorageStoresBlobResponseStoreProjectFilterGitProviders?)

                    || typeToConvert == typeof(global::Vercel.CreateStorageStoresBlobResponseStoreProjectsMetadataItemFramework)

                    || typeToConvert == typeof(global::Vercel.CreateStorageStoresBlobResponseStoreProjectsMetadataItemFramework?)

                    || typeToConvert == typeof(global::Vercel.CreateStorageStoresBlobResponseStoreStatus)

                    || typeToConvert == typeof(global::Vercel.CreateStorageStoresBlobResponseStoreStatus?)

                    || typeToConvert == typeof(global::Vercel.CreateStorageStoresBlobResponseStoreAccess)

                    || typeToConvert == typeof(global::Vercel.CreateStorageStoresBlobResponseStoreAccess?)

                    || typeToConvert == typeof(global::Vercel.CreateStorageStoresBlobResponseStoreKind)

                    || typeToConvert == typeof(global::Vercel.CreateStorageStoresBlobResponseStoreKind?)

                    || typeToConvert == typeof(global::Vercel.CreateStorageStoresBlobResponseStoreRegion)

                    || typeToConvert == typeof(global::Vercel.CreateStorageStoresBlobResponseStoreRegion?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Vercel.CreateStorageStoresBlobRequestRegion))
                {
                    return new global::Vercel.JsonConverters.CreateStorageStoresBlobRequestRegionJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateStorageStoresBlobRequestRegion?))
                {
                    return new global::Vercel.JsonConverters.CreateStorageStoresBlobRequestRegionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateStorageStoresBlobRequestAccess))
                {
                    return new global::Vercel.JsonConverters.CreateStorageStoresBlobRequestAccessJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateStorageStoresBlobRequestAccess?))
                {
                    return new global::Vercel.JsonConverters.CreateStorageStoresBlobRequestAccessNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetStorageStoresByIdResponseStoreProjectFilterGitProvider))
                {
                    return new global::Vercel.JsonConverters.GetStorageStoresByIdResponseStoreProjectFilterGitProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetStorageStoresByIdResponseStoreProjectFilterGitProvider?))
                {
                    return new global::Vercel.JsonConverters.GetStorageStoresByIdResponseStoreProjectFilterGitProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetStorageStoresByIdResponseStoreProjectFilterGitProviders))
                {
                    return new global::Vercel.JsonConverters.GetStorageStoresByIdResponseStoreProjectFilterGitProvidersJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetStorageStoresByIdResponseStoreProjectFilterGitProviders?))
                {
                    return new global::Vercel.JsonConverters.GetStorageStoresByIdResponseStoreProjectFilterGitProvidersNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetStorageStoresByIdResponseStoreProjectsMetadataItemFramework))
                {
                    return new global::Vercel.JsonConverters.GetStorageStoresByIdResponseStoreProjectsMetadataItemFrameworkJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetStorageStoresByIdResponseStoreProjectsMetadataItemFramework?))
                {
                    return new global::Vercel.JsonConverters.GetStorageStoresByIdResponseStoreProjectsMetadataItemFrameworkNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetStorageStoresByIdResponseStoreStatus))
                {
                    return new global::Vercel.JsonConverters.GetStorageStoresByIdResponseStoreStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetStorageStoresByIdResponseStoreStatus?))
                {
                    return new global::Vercel.JsonConverters.GetStorageStoresByIdResponseStoreStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateStorageStoresBlobResponseStoreProjectFilterGitProvider))
                {
                    return new global::Vercel.JsonConverters.CreateStorageStoresBlobResponseStoreProjectFilterGitProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateStorageStoresBlobResponseStoreProjectFilterGitProvider?))
                {
                    return new global::Vercel.JsonConverters.CreateStorageStoresBlobResponseStoreProjectFilterGitProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateStorageStoresBlobResponseStoreProjectFilterGitProviders))
                {
                    return new global::Vercel.JsonConverters.CreateStorageStoresBlobResponseStoreProjectFilterGitProvidersJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateStorageStoresBlobResponseStoreProjectFilterGitProviders?))
                {
                    return new global::Vercel.JsonConverters.CreateStorageStoresBlobResponseStoreProjectFilterGitProvidersNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateStorageStoresBlobResponseStoreProjectsMetadataItemFramework))
                {
                    return new global::Vercel.JsonConverters.CreateStorageStoresBlobResponseStoreProjectsMetadataItemFrameworkJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateStorageStoresBlobResponseStoreProjectsMetadataItemFramework?))
                {
                    return new global::Vercel.JsonConverters.CreateStorageStoresBlobResponseStoreProjectsMetadataItemFrameworkNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateStorageStoresBlobResponseStoreStatus))
                {
                    return new global::Vercel.JsonConverters.CreateStorageStoresBlobResponseStoreStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateStorageStoresBlobResponseStoreStatus?))
                {
                    return new global::Vercel.JsonConverters.CreateStorageStoresBlobResponseStoreStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateStorageStoresBlobResponseStoreAccess))
                {
                    return new global::Vercel.JsonConverters.CreateStorageStoresBlobResponseStoreAccessJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateStorageStoresBlobResponseStoreAccess?))
                {
                    return new global::Vercel.JsonConverters.CreateStorageStoresBlobResponseStoreAccessNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateStorageStoresBlobResponseStoreKind))
                {
                    return new global::Vercel.JsonConverters.CreateStorageStoresBlobResponseStoreKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateStorageStoresBlobResponseStoreKind?))
                {
                    return new global::Vercel.JsonConverters.CreateStorageStoresBlobResponseStoreKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateStorageStoresBlobResponseStoreRegion))
                {
                    return new global::Vercel.JsonConverters.CreateStorageStoresBlobResponseStoreRegionJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateStorageStoresBlobResponseStoreRegion?))
                {
                    return new global::Vercel.JsonConverters.CreateStorageStoresBlobResponseStoreRegionNullableJsonConverter();
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
                    0 => new StorageSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}