
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.Pagination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateRecordRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateRecordRequestType), TypeInfoPropertyName = "CreateRecordRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateRecordRequestEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateRecordRequestEnumType), TypeInfoPropertyName = "CreateRecordRequestEnumType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateRecordRequestEnum2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateRecordRequestEnumType2), TypeInfoPropertyName = "CreateRecordRequestEnumType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateRecordRequestEnum3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateRecordRequestEnumType3), TypeInfoPropertyName = "CreateRecordRequestEnumType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateRecordRequestEnum4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateRecordRequestEnumType4), TypeInfoPropertyName = "CreateRecordRequestEnumType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateRecordRequestEnum5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateRecordRequestEnumType5), TypeInfoPropertyName = "CreateRecordRequestEnumType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateRecordRequestEnum6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateRecordRequestEnumType6), TypeInfoPropertyName = "CreateRecordRequestEnumType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateRecordRequestEnum7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateRecordRequestEnumType7), TypeInfoPropertyName = "CreateRecordRequestEnumType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateRecordRequestEnumSrv))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateRecordRequestEnum8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateRecordRequestEnumType8), TypeInfoPropertyName = "CreateRecordRequestEnumType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateRecordRequestEnum9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateRecordRequestEnumType9), TypeInfoPropertyName = "CreateRecordRequestEnumType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateRecordRequestEnum10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateRecordRequestEnumType10), TypeInfoPropertyName = "CreateRecordRequestEnumType102")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateRecordRequestEnumHttps))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateRecordRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateRecordRequestType), TypeInfoPropertyName = "UpdateRecordRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateRecordRequestSrv))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateRecordRequestHttps))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.GetRecordsResponseVariant2, global::Vercel.GetRecordsResponseVariant3>), TypeInfoPropertyName = "OneOfStringGetRecordsResponseVariant2GetRecordsResponseVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRecordsResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.GetRecordsResponseVariant2Record>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRecordsResponseVariant2Record))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRecordsResponseVariant2RecordType), TypeInfoPropertyName = "GetRecordsResponseVariant2RecordType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRecordsResponseVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.GetRecordsResponseVariant3Record>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRecordsResponseVariant3Record))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRecordsResponseVariant3RecordType), TypeInfoPropertyName = "GetRecordsResponseVariant3RecordType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.CreateRecordResponseVariant1, global::Vercel.CreateRecordResponseVariant2>), TypeInfoPropertyName = "OneOfCreateRecordResponseVariant1CreateRecordResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateRecordResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateRecordResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateRecordResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateRecordResponseRecordType), TypeInfoPropertyName = "UpdateRecordResponseRecordType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateRecordResponseType), TypeInfoPropertyName = "UpdateRecordResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateRecordRequestType?), TypeInfoPropertyName = "NullableCreateRecordRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateRecordRequestEnumType?), TypeInfoPropertyName = "NullableCreateRecordRequestEnumType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateRecordRequestEnumType2?), TypeInfoPropertyName = "NullableCreateRecordRequestEnumType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateRecordRequestEnumType3?), TypeInfoPropertyName = "NullableCreateRecordRequestEnumType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateRecordRequestEnumType4?), TypeInfoPropertyName = "NullableCreateRecordRequestEnumType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateRecordRequestEnumType5?), TypeInfoPropertyName = "NullableCreateRecordRequestEnumType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateRecordRequestEnumType6?), TypeInfoPropertyName = "NullableCreateRecordRequestEnumType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateRecordRequestEnumType7?), TypeInfoPropertyName = "NullableCreateRecordRequestEnumType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateRecordRequestEnumType8?), TypeInfoPropertyName = "NullableCreateRecordRequestEnumType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateRecordRequestEnumType9?), TypeInfoPropertyName = "NullableCreateRecordRequestEnumType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateRecordRequestEnumType10?), TypeInfoPropertyName = "NullableCreateRecordRequestEnumType102")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateRecordRequestType?), TypeInfoPropertyName = "NullableUpdateRecordRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, global::Vercel.GetRecordsResponseVariant2, global::Vercel.GetRecordsResponseVariant3>?), TypeInfoPropertyName = "NullableOneOfStringGetRecordsResponseVariant2GetRecordsResponseVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRecordsResponseVariant2RecordType?), TypeInfoPropertyName = "NullableGetRecordsResponseVariant2RecordType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRecordsResponseVariant3RecordType?), TypeInfoPropertyName = "NullableGetRecordsResponseVariant3RecordType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.CreateRecordResponseVariant1, global::Vercel.CreateRecordResponseVariant2>?), TypeInfoPropertyName = "NullableOneOfCreateRecordResponseVariant1CreateRecordResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateRecordResponseRecordType?), TypeInfoPropertyName = "NullableUpdateRecordResponseRecordType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateRecordResponseType?), TypeInfoPropertyName = "NullableUpdateRecordResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.GetRecordsResponseVariant2Record>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.GetRecordsResponseVariant3Record>))]
    internal sealed partial class DnsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DnsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static DnsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private DnsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, global::Vercel.GetRecordsResponseVariant2, global::Vercel.GetRecordsResponseVariant3>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.CreateRecordResponseVariant1, global::Vercel.CreateRecordResponseVariant2>());
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
                    typeToConvert == typeof(global::Vercel.CreateRecordRequestType)

                    || typeToConvert == typeof(global::Vercel.CreateRecordRequestType?)

                    || typeToConvert == typeof(global::Vercel.CreateRecordRequestEnumType)

                    || typeToConvert == typeof(global::Vercel.CreateRecordRequestEnumType?)

                    || typeToConvert == typeof(global::Vercel.CreateRecordRequestEnumType2)

                    || typeToConvert == typeof(global::Vercel.CreateRecordRequestEnumType2?)

                    || typeToConvert == typeof(global::Vercel.CreateRecordRequestEnumType3)

                    || typeToConvert == typeof(global::Vercel.CreateRecordRequestEnumType3?)

                    || typeToConvert == typeof(global::Vercel.CreateRecordRequestEnumType4)

                    || typeToConvert == typeof(global::Vercel.CreateRecordRequestEnumType4?)

                    || typeToConvert == typeof(global::Vercel.CreateRecordRequestEnumType5)

                    || typeToConvert == typeof(global::Vercel.CreateRecordRequestEnumType5?)

                    || typeToConvert == typeof(global::Vercel.CreateRecordRequestEnumType6)

                    || typeToConvert == typeof(global::Vercel.CreateRecordRequestEnumType6?)

                    || typeToConvert == typeof(global::Vercel.CreateRecordRequestEnumType7)

                    || typeToConvert == typeof(global::Vercel.CreateRecordRequestEnumType7?)

                    || typeToConvert == typeof(global::Vercel.CreateRecordRequestEnumType8)

                    || typeToConvert == typeof(global::Vercel.CreateRecordRequestEnumType8?)

                    || typeToConvert == typeof(global::Vercel.CreateRecordRequestEnumType9)

                    || typeToConvert == typeof(global::Vercel.CreateRecordRequestEnumType9?)

                    || typeToConvert == typeof(global::Vercel.CreateRecordRequestEnumType10)

                    || typeToConvert == typeof(global::Vercel.CreateRecordRequestEnumType10?)

                    || typeToConvert == typeof(global::Vercel.UpdateRecordRequestType)

                    || typeToConvert == typeof(global::Vercel.UpdateRecordRequestType?)

                    || typeToConvert == typeof(global::Vercel.GetRecordsResponseVariant2RecordType)

                    || typeToConvert == typeof(global::Vercel.GetRecordsResponseVariant2RecordType?)

                    || typeToConvert == typeof(global::Vercel.GetRecordsResponseVariant3RecordType)

                    || typeToConvert == typeof(global::Vercel.GetRecordsResponseVariant3RecordType?)

                    || typeToConvert == typeof(global::Vercel.UpdateRecordResponseRecordType)

                    || typeToConvert == typeof(global::Vercel.UpdateRecordResponseRecordType?)

                    || typeToConvert == typeof(global::Vercel.UpdateRecordResponseType)

                    || typeToConvert == typeof(global::Vercel.UpdateRecordResponseType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Vercel.CreateRecordRequestType))
                {
                    return new global::Vercel.JsonConverters.CreateRecordRequestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateRecordRequestType?))
                {
                    return new global::Vercel.JsonConverters.CreateRecordRequestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateRecordRequestEnumType))
                {
                    return new global::Vercel.JsonConverters.CreateRecordRequestEnumTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateRecordRequestEnumType?))
                {
                    return new global::Vercel.JsonConverters.CreateRecordRequestEnumTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateRecordRequestEnumType2))
                {
                    return new global::Vercel.JsonConverters.CreateRecordRequestEnumType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateRecordRequestEnumType2?))
                {
                    return new global::Vercel.JsonConverters.CreateRecordRequestEnumType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateRecordRequestEnumType3))
                {
                    return new global::Vercel.JsonConverters.CreateRecordRequestEnumType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateRecordRequestEnumType3?))
                {
                    return new global::Vercel.JsonConverters.CreateRecordRequestEnumType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateRecordRequestEnumType4))
                {
                    return new global::Vercel.JsonConverters.CreateRecordRequestEnumType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateRecordRequestEnumType4?))
                {
                    return new global::Vercel.JsonConverters.CreateRecordRequestEnumType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateRecordRequestEnumType5))
                {
                    return new global::Vercel.JsonConverters.CreateRecordRequestEnumType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateRecordRequestEnumType5?))
                {
                    return new global::Vercel.JsonConverters.CreateRecordRequestEnumType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateRecordRequestEnumType6))
                {
                    return new global::Vercel.JsonConverters.CreateRecordRequestEnumType6JsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateRecordRequestEnumType6?))
                {
                    return new global::Vercel.JsonConverters.CreateRecordRequestEnumType6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateRecordRequestEnumType7))
                {
                    return new global::Vercel.JsonConverters.CreateRecordRequestEnumType7JsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateRecordRequestEnumType7?))
                {
                    return new global::Vercel.JsonConverters.CreateRecordRequestEnumType7NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateRecordRequestEnumType8))
                {
                    return new global::Vercel.JsonConverters.CreateRecordRequestEnumType8JsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateRecordRequestEnumType8?))
                {
                    return new global::Vercel.JsonConverters.CreateRecordRequestEnumType8NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateRecordRequestEnumType9))
                {
                    return new global::Vercel.JsonConverters.CreateRecordRequestEnumType9JsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateRecordRequestEnumType9?))
                {
                    return new global::Vercel.JsonConverters.CreateRecordRequestEnumType9NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateRecordRequestEnumType10))
                {
                    return new global::Vercel.JsonConverters.CreateRecordRequestEnumType10JsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateRecordRequestEnumType10?))
                {
                    return new global::Vercel.JsonConverters.CreateRecordRequestEnumType10NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpdateRecordRequestType))
                {
                    return new global::Vercel.JsonConverters.UpdateRecordRequestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpdateRecordRequestType?))
                {
                    return new global::Vercel.JsonConverters.UpdateRecordRequestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRecordsResponseVariant2RecordType))
                {
                    return new global::Vercel.JsonConverters.GetRecordsResponseVariant2RecordTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRecordsResponseVariant2RecordType?))
                {
                    return new global::Vercel.JsonConverters.GetRecordsResponseVariant2RecordTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRecordsResponseVariant3RecordType))
                {
                    return new global::Vercel.JsonConverters.GetRecordsResponseVariant3RecordTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRecordsResponseVariant3RecordType?))
                {
                    return new global::Vercel.JsonConverters.GetRecordsResponseVariant3RecordTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpdateRecordResponseRecordType))
                {
                    return new global::Vercel.JsonConverters.UpdateRecordResponseRecordTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpdateRecordResponseRecordType?))
                {
                    return new global::Vercel.JsonConverters.UpdateRecordResponseRecordTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpdateRecordResponseType))
                {
                    return new global::Vercel.JsonConverters.UpdateRecordResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpdateRecordResponseType?))
                {
                    return new global::Vercel.JsonConverters.UpdateRecordResponseTypeNullableJsonConverter();
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
                    0 => new DnsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}