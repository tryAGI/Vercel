
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.VcrRepository))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.VcrRepositoryList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.VcrRepository>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.VcrImageListItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.VcrImageListItemKind), TypeInfoPropertyName = "VcrImageListItemKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.VcrImageListItemStatus), TypeInfoPropertyName = "VcrImageListItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.VcrImageList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.VcrImageListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.VcrRepositoryPermission))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.VcrTag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.VcrTagKind), TypeInfoPropertyName = "VcrTagKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.VcrTagStatus), TypeInfoPropertyName = "VcrTagStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.VcrImageLayer), TypeInfoPropertyName = "VcrImageLayer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.VcrImageLayerVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.VcrImageLayerVariant1Operation), TypeInfoPropertyName = "VcrImageLayerVariant1Operation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.VcrImageLayerVariant1Type), TypeInfoPropertyName = "VcrImageLayerVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.VcrImageLayerVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.VcrImageLayerVariant2Operation), TypeInfoPropertyName = "VcrImageLayerVariant2Operation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.VcrImageLayerVariant2Type), TypeInfoPropertyName = "VcrImageLayerVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.VcrImageLayerVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.VcrImageLayerVariant3Operation), TypeInfoPropertyName = "VcrImageLayerVariant3Operation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.VcrImageLayerVariant3Type), TypeInfoPropertyName = "VcrImageLayerVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.VcrImageLayerVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.VcrImageLayerVariant4Operation), TypeInfoPropertyName = "VcrImageLayerVariant4Operation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.VcrImageLayerVariant4Type), TypeInfoPropertyName = "VcrImageLayerVariant4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.VcrImageDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.VcrImageDetailKind), TypeInfoPropertyName = "VcrImageDetailKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.VcrImageLayer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.VcrImageDetailStatus), TypeInfoPropertyName = "VcrImageDetailStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.VcrRepositoryPermissionList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.VcrRepositoryPermission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateRepositoryRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRepositoryPermissionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.RemoveRepositoryPermissionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListRepositoryTagsSortBy), TypeInfoPropertyName = "ListRepositoryTagsSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListRepositoryTagsSortOrder), TypeInfoPropertyName = "ListRepositoryTagsSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateRepositoryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRepositoryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AddRepositoryPermissionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListRepositoryTagsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.ListRepositoryTagsResponseTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListRepositoryTagsResponseTag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListRepositoryTagsResponseTagKind), TypeInfoPropertyName = "ListRepositoryTagsResponseTagKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListRepositoryTagsResponseTagStatus), TypeInfoPropertyName = "ListRepositoryTagsResponseTagStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRepositoryTagResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRepositoryImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetByTeamSlugByProjectSlugByRepositoryNameTagsListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.VcrImageListItemKind?), TypeInfoPropertyName = "NullableVcrImageListItemKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.VcrImageListItemStatus?), TypeInfoPropertyName = "NullableVcrImageListItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.VcrTagKind?), TypeInfoPropertyName = "NullableVcrTagKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.VcrTagStatus?), TypeInfoPropertyName = "NullableVcrTagStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.VcrImageLayer?), TypeInfoPropertyName = "NullableVcrImageLayer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.VcrImageLayerVariant1Operation?), TypeInfoPropertyName = "NullableVcrImageLayerVariant1Operation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.VcrImageLayerVariant1Type?), TypeInfoPropertyName = "NullableVcrImageLayerVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.VcrImageLayerVariant2Operation?), TypeInfoPropertyName = "NullableVcrImageLayerVariant2Operation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.VcrImageLayerVariant2Type?), TypeInfoPropertyName = "NullableVcrImageLayerVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.VcrImageLayerVariant3Operation?), TypeInfoPropertyName = "NullableVcrImageLayerVariant3Operation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.VcrImageLayerVariant3Type?), TypeInfoPropertyName = "NullableVcrImageLayerVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.VcrImageLayerVariant4Operation?), TypeInfoPropertyName = "NullableVcrImageLayerVariant4Operation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.VcrImageLayerVariant4Type?), TypeInfoPropertyName = "NullableVcrImageLayerVariant4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.VcrImageDetailKind?), TypeInfoPropertyName = "NullableVcrImageDetailKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.VcrImageDetailStatus?), TypeInfoPropertyName = "NullableVcrImageDetailStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListRepositoryTagsSortBy?), TypeInfoPropertyName = "NullableListRepositoryTagsSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListRepositoryTagsSortOrder?), TypeInfoPropertyName = "NullableListRepositoryTagsSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListRepositoryTagsResponseTagKind?), TypeInfoPropertyName = "NullableListRepositoryTagsResponseTagKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListRepositoryTagsResponseTagStatus?), TypeInfoPropertyName = "NullableListRepositoryTagsResponseTagStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.VcrRepository>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.VcrImageListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.VcrImageLayer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.VcrRepositoryPermission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.ListRepositoryTagsResponseTag>))]
    internal sealed partial class VcrSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VcrSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static VcrSourceGenerationContext Default { get; } = new(DefaultOptions);

        private VcrSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Vercel.JsonConverters.VcrImageLayerJsonConverter());
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
                    typeToConvert == typeof(global::Vercel.VcrImageListItemKind)

                    || typeToConvert == typeof(global::Vercel.VcrImageListItemKind?)

                    || typeToConvert == typeof(global::Vercel.VcrImageListItemStatus)

                    || typeToConvert == typeof(global::Vercel.VcrImageListItemStatus?)

                    || typeToConvert == typeof(global::Vercel.VcrTagKind)

                    || typeToConvert == typeof(global::Vercel.VcrTagKind?)

                    || typeToConvert == typeof(global::Vercel.VcrTagStatus)

                    || typeToConvert == typeof(global::Vercel.VcrTagStatus?)

                    || typeToConvert == typeof(global::Vercel.VcrImageLayerVariant1Operation)

                    || typeToConvert == typeof(global::Vercel.VcrImageLayerVariant1Operation?)

                    || typeToConvert == typeof(global::Vercel.VcrImageLayerVariant1Type)

                    || typeToConvert == typeof(global::Vercel.VcrImageLayerVariant1Type?)

                    || typeToConvert == typeof(global::Vercel.VcrImageLayerVariant2Operation)

                    || typeToConvert == typeof(global::Vercel.VcrImageLayerVariant2Operation?)

                    || typeToConvert == typeof(global::Vercel.VcrImageLayerVariant2Type)

                    || typeToConvert == typeof(global::Vercel.VcrImageLayerVariant2Type?)

                    || typeToConvert == typeof(global::Vercel.VcrImageLayerVariant3Operation)

                    || typeToConvert == typeof(global::Vercel.VcrImageLayerVariant3Operation?)

                    || typeToConvert == typeof(global::Vercel.VcrImageLayerVariant3Type)

                    || typeToConvert == typeof(global::Vercel.VcrImageLayerVariant3Type?)

                    || typeToConvert == typeof(global::Vercel.VcrImageLayerVariant4Operation)

                    || typeToConvert == typeof(global::Vercel.VcrImageLayerVariant4Operation?)

                    || typeToConvert == typeof(global::Vercel.VcrImageLayerVariant4Type)

                    || typeToConvert == typeof(global::Vercel.VcrImageLayerVariant4Type?)

                    || typeToConvert == typeof(global::Vercel.VcrImageDetailKind)

                    || typeToConvert == typeof(global::Vercel.VcrImageDetailKind?)

                    || typeToConvert == typeof(global::Vercel.VcrImageDetailStatus)

                    || typeToConvert == typeof(global::Vercel.VcrImageDetailStatus?)

                    || typeToConvert == typeof(global::Vercel.ListRepositoryTagsSortBy)

                    || typeToConvert == typeof(global::Vercel.ListRepositoryTagsSortBy?)

                    || typeToConvert == typeof(global::Vercel.ListRepositoryTagsSortOrder)

                    || typeToConvert == typeof(global::Vercel.ListRepositoryTagsSortOrder?)

                    || typeToConvert == typeof(global::Vercel.ListRepositoryTagsResponseTagKind)

                    || typeToConvert == typeof(global::Vercel.ListRepositoryTagsResponseTagKind?)

                    || typeToConvert == typeof(global::Vercel.ListRepositoryTagsResponseTagStatus)

                    || typeToConvert == typeof(global::Vercel.ListRepositoryTagsResponseTagStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Vercel.VcrImageListItemKind))
                {
                    return new global::Vercel.JsonConverters.VcrImageListItemKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.VcrImageListItemKind?))
                {
                    return new global::Vercel.JsonConverters.VcrImageListItemKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.VcrImageListItemStatus))
                {
                    return new global::Vercel.JsonConverters.VcrImageListItemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.VcrImageListItemStatus?))
                {
                    return new global::Vercel.JsonConverters.VcrImageListItemStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.VcrTagKind))
                {
                    return new global::Vercel.JsonConverters.VcrTagKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.VcrTagKind?))
                {
                    return new global::Vercel.JsonConverters.VcrTagKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.VcrTagStatus))
                {
                    return new global::Vercel.JsonConverters.VcrTagStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.VcrTagStatus?))
                {
                    return new global::Vercel.JsonConverters.VcrTagStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.VcrImageLayerVariant1Operation))
                {
                    return new global::Vercel.JsonConverters.VcrImageLayerVariant1OperationJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.VcrImageLayerVariant1Operation?))
                {
                    return new global::Vercel.JsonConverters.VcrImageLayerVariant1OperationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.VcrImageLayerVariant1Type))
                {
                    return new global::Vercel.JsonConverters.VcrImageLayerVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.VcrImageLayerVariant1Type?))
                {
                    return new global::Vercel.JsonConverters.VcrImageLayerVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.VcrImageLayerVariant2Operation))
                {
                    return new global::Vercel.JsonConverters.VcrImageLayerVariant2OperationJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.VcrImageLayerVariant2Operation?))
                {
                    return new global::Vercel.JsonConverters.VcrImageLayerVariant2OperationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.VcrImageLayerVariant2Type))
                {
                    return new global::Vercel.JsonConverters.VcrImageLayerVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.VcrImageLayerVariant2Type?))
                {
                    return new global::Vercel.JsonConverters.VcrImageLayerVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.VcrImageLayerVariant3Operation))
                {
                    return new global::Vercel.JsonConverters.VcrImageLayerVariant3OperationJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.VcrImageLayerVariant3Operation?))
                {
                    return new global::Vercel.JsonConverters.VcrImageLayerVariant3OperationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.VcrImageLayerVariant3Type))
                {
                    return new global::Vercel.JsonConverters.VcrImageLayerVariant3TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.VcrImageLayerVariant3Type?))
                {
                    return new global::Vercel.JsonConverters.VcrImageLayerVariant3TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.VcrImageLayerVariant4Operation))
                {
                    return new global::Vercel.JsonConverters.VcrImageLayerVariant4OperationJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.VcrImageLayerVariant4Operation?))
                {
                    return new global::Vercel.JsonConverters.VcrImageLayerVariant4OperationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.VcrImageLayerVariant4Type))
                {
                    return new global::Vercel.JsonConverters.VcrImageLayerVariant4TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.VcrImageLayerVariant4Type?))
                {
                    return new global::Vercel.JsonConverters.VcrImageLayerVariant4TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.VcrImageDetailKind))
                {
                    return new global::Vercel.JsonConverters.VcrImageDetailKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.VcrImageDetailKind?))
                {
                    return new global::Vercel.JsonConverters.VcrImageDetailKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.VcrImageDetailStatus))
                {
                    return new global::Vercel.JsonConverters.VcrImageDetailStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.VcrImageDetailStatus?))
                {
                    return new global::Vercel.JsonConverters.VcrImageDetailStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ListRepositoryTagsSortBy))
                {
                    return new global::Vercel.JsonConverters.ListRepositoryTagsSortByJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ListRepositoryTagsSortBy?))
                {
                    return new global::Vercel.JsonConverters.ListRepositoryTagsSortByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ListRepositoryTagsSortOrder))
                {
                    return new global::Vercel.JsonConverters.ListRepositoryTagsSortOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ListRepositoryTagsSortOrder?))
                {
                    return new global::Vercel.JsonConverters.ListRepositoryTagsSortOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ListRepositoryTagsResponseTagKind))
                {
                    return new global::Vercel.JsonConverters.ListRepositoryTagsResponseTagKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ListRepositoryTagsResponseTagKind?))
                {
                    return new global::Vercel.JsonConverters.ListRepositoryTagsResponseTagKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ListRepositoryTagsResponseTagStatus))
                {
                    return new global::Vercel.JsonConverters.ListRepositoryTagsResponseTagStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ListRepositoryTagsResponseTagStatus?))
                {
                    return new global::Vercel.JsonConverters.ListRepositoryTagsResponseTagStatusNullableJsonConverter();
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
                    0 => new VcrSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}