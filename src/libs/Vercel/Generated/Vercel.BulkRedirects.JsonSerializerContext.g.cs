
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.StageRedirectsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.StageRedirectsRequestRedirect>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.StageRedirectsRequestRedirect))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<double?, string>), TypeInfoPropertyName = "OneOfDoubleString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.DeleteRedirectsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRedirectRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRedirectRequestRedirect))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.RestoreRedirectsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateVersionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateVersionRequestAction), TypeInfoPropertyName = "UpdateVersionRequestAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<bool?, global::Vercel.GetRedirectsDiff2?>), TypeInfoPropertyName = "OneOfBooleanGetRedirectsDiff22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRedirectsDiff2), TypeInfoPropertyName = "GetRedirectsDiff22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRedirectsSortBy), TypeInfoPropertyName = "GetRedirectsSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRedirectsSortOrder), TypeInfoPropertyName = "GetRedirectsSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.StageRedirectsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.StageRedirectsResponseVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<object, global::Vercel.GetRedirectsResponseVariant2, global::Vercel.GetRedirectsResponseVariant3>), TypeInfoPropertyName = "OneOfObjectGetRedirectsResponseVariant2GetRedirectsResponseVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRedirectsResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRedirectsResponseVariant2Pagination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.GetRedirectsResponseVariant2Redirect>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRedirectsResponseVariant2Redirect))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRedirectsResponseVariant2Version))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRedirectsResponseVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRedirectsResponseVariant3Pagination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.GetRedirectsResponseVariant3Redirect>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRedirectsResponseVariant3Redirect))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRedirectsResponseVariant3Version))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.DeleteRedirectsResponseVariant1, global::Vercel.DeleteRedirectsResponseVariant2, global::Vercel.DeleteRedirectsResponseVariant3>), TypeInfoPropertyName = "OneOfDeleteRedirectsResponseVariant1DeleteRedirectsResponseVariant2DeleteRedirectsResponseVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.DeleteRedirectsResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.DeleteRedirectsResponseVariant1Version))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.DeleteRedirectsResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.DeleteRedirectsResponseVariant2Version))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.DeleteRedirectsResponseVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.DeleteRedirectsResponseVariant3Version))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRedirectResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.EditRedirectResponseVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.RestoreRedirectsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.RestoreRedirectsResponseVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetVersionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.GetVersionsResponseVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetVersionsResponseVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateVersionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateVersionResponseVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<double?, string>?), TypeInfoPropertyName = "NullableOneOfDoubleString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateVersionRequestAction?), TypeInfoPropertyName = "NullableUpdateVersionRequestAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<bool?, global::Vercel.GetRedirectsDiff2?>?), TypeInfoPropertyName = "NullableOneOfBooleanGetRedirectsDiff22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRedirectsDiff2?), TypeInfoPropertyName = "NullableGetRedirectsDiff22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRedirectsSortBy?), TypeInfoPropertyName = "NullableGetRedirectsSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRedirectsSortOrder?), TypeInfoPropertyName = "NullableGetRedirectsSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<object, global::Vercel.GetRedirectsResponseVariant2, global::Vercel.GetRedirectsResponseVariant3>?), TypeInfoPropertyName = "NullableOneOfObjectGetRedirectsResponseVariant2GetRedirectsResponseVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.DeleteRedirectsResponseVariant1, global::Vercel.DeleteRedirectsResponseVariant2, global::Vercel.DeleteRedirectsResponseVariant3>?), TypeInfoPropertyName = "NullableOneOfDeleteRedirectsResponseVariant1DeleteRedirectsResponseVariant2DeleteRedirectsResponseVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.StageRedirectsRequestRedirect>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.GetRedirectsResponseVariant2Redirect>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.GetRedirectsResponseVariant3Redirect>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.GetVersionsResponseVersion>))]
    internal sealed partial class BulkRedirectsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BulkRedirectsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static BulkRedirectsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private BulkRedirectsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
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
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
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
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<bool?, global::Vercel.GetRedirectsDiff2?>());
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
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<object, global::Vercel.GetRedirectsResponseVariant2, global::Vercel.GetRedirectsResponseVariant3>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.DeleteRedirectsResponseVariant1, global::Vercel.DeleteRedirectsResponseVariant2, global::Vercel.DeleteRedirectsResponseVariant3>());
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
                    typeToConvert == typeof(global::Vercel.UpdateVersionRequestAction)

                    || typeToConvert == typeof(global::Vercel.UpdateVersionRequestAction?)

                    || typeToConvert == typeof(global::Vercel.GetRedirectsDiff2)

                    || typeToConvert == typeof(global::Vercel.GetRedirectsDiff2?)

                    || typeToConvert == typeof(global::Vercel.GetRedirectsSortBy)

                    || typeToConvert == typeof(global::Vercel.GetRedirectsSortBy?)

                    || typeToConvert == typeof(global::Vercel.GetRedirectsSortOrder)

                    || typeToConvert == typeof(global::Vercel.GetRedirectsSortOrder?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Vercel.UpdateVersionRequestAction))
                {
                    return new global::Vercel.JsonConverters.UpdateVersionRequestActionJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpdateVersionRequestAction?))
                {
                    return new global::Vercel.JsonConverters.UpdateVersionRequestActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRedirectsDiff2))
                {
                    return new global::Vercel.JsonConverters.GetRedirectsDiff2JsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRedirectsDiff2?))
                {
                    return new global::Vercel.JsonConverters.GetRedirectsDiff2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRedirectsSortBy))
                {
                    return new global::Vercel.JsonConverters.GetRedirectsSortByJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRedirectsSortBy?))
                {
                    return new global::Vercel.JsonConverters.GetRedirectsSortByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRedirectsSortOrder))
                {
                    return new global::Vercel.JsonConverters.GetRedirectsSortOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRedirectsSortOrder?))
                {
                    return new global::Vercel.JsonConverters.GetRedirectsSortOrderNullableJsonConverter();
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
                    0 => new BulkRedirectsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}