
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, double?>), TypeInfoPropertyName = "OneOfStringDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKShared38e9af03824d67bc))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKShared38e9af03824d67bcPublicKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKShared38e9af03824d67bcStatus), TypeInfoPropertyName = "AutoSDKShared38e9af03824d67bcStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKShared6a7dd045a7a1bf61))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKShared6a7dd045a7a1bf61Algorithm), TypeInfoPropertyName = "AutoSDKShared6a7dd045a7a1bf61Algorithm2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKShared6a7dd045a7a1bf61Origin), TypeInfoPropertyName = "AutoSDKShared6a7dd045a7a1bf61Origin2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.AutoSDKShared6a7dd045a7a1bf61PolicieVariant1, global::Vercel.AutoSDKShared6a7dd045a7a1bf61PolicieVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.AutoSDKShared6a7dd045a7a1bf61PolicieVariant1, global::Vercel.AutoSDKShared6a7dd045a7a1bf61PolicieVariant2>), TypeInfoPropertyName = "OneOfAutoSDKShared6a7dd045a7a1bf61PolicieVariant1AutoSDKShared6a7dd045a7a1bf61PolicieVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKShared6a7dd045a7a1bf61PolicieVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKShared6a7dd045a7a1bf61PolicieVariant1Kind), TypeInfoPropertyName = "AutoSDKShared6a7dd045a7a1bf61PolicieVariant1Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKShared6a7dd045a7a1bf61PolicieVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKShared6a7dd045a7a1bf61PolicieVariant2Kind), TypeInfoPropertyName = "AutoSDKShared6a7dd045a7a1bf61PolicieVariant2Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared38e9af03824d67bc>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.SignKmsMessageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.SignKmsTokenRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateKmsIssuerRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateKmsIssuerRequestAlgorithm), TypeInfoPropertyName = "CreateKmsIssuerRequestAlgorithm2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.CreateKmsIssuerRequestPolicyVariant1, global::Vercel.CreateKmsIssuerRequestPolicyVariant2>), TypeInfoPropertyName = "OneOfCreateKmsIssuerRequestPolicyVariant1CreateKmsIssuerRequestPolicyVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateKmsIssuerRequestPolicyVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateKmsIssuerRequestPolicyVariant1Kind), TypeInfoPropertyName = "CreateKmsIssuerRequestPolicyVariant1Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateKmsIssuerRequestPolicyVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateKmsIssuerRequestPolicyVariant2Kind), TypeInfoPropertyName = "CreateKmsIssuerRequestPolicyVariant2Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateKmsSigningKeyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateKmsSigningKeyRequestActivation), TypeInfoPropertyName = "CreateKmsSigningKeyRequestActivation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ActivateKmsSigningKeyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateKmsIssuerRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateKmsIssuerPolicyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateKmsIssuerPolicyRequestKind), TypeInfoPropertyName = "CreateKmsIssuerPolicyRequestKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateKmsIssuerPolicyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateKmsIssuerPolicyKind), TypeInfoPropertyName = "UpdateKmsIssuerPolicyKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.DeleteKmsIssuerPolicyKind), TypeInfoPropertyName = "DeleteKmsIssuerPolicyKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.SignKmsMessageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.SignKmsTokenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListKmsIssuersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared6a7dd045a7a1bf61>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListKmsIssuersResponsePagination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.CreateKmsIssuerPolicyResponseVariant1, global::Vercel.CreateKmsIssuerPolicyResponseVariant2>), TypeInfoPropertyName = "OneOfCreateKmsIssuerPolicyResponseVariant1CreateKmsIssuerPolicyResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateKmsIssuerPolicyResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateKmsIssuerPolicyResponseVariant1Kind), TypeInfoPropertyName = "CreateKmsIssuerPolicyResponseVariant1Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateKmsIssuerPolicyResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateKmsIssuerPolicyResponseVariant2Kind), TypeInfoPropertyName = "CreateKmsIssuerPolicyResponseVariant2Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.UpdateKmsIssuerPolicyResponseVariant1, global::Vercel.UpdateKmsIssuerPolicyResponseVariant2>), TypeInfoPropertyName = "OneOfUpdateKmsIssuerPolicyResponseVariant1UpdateKmsIssuerPolicyResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateKmsIssuerPolicyResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateKmsIssuerPolicyResponseVariant1Kind), TypeInfoPropertyName = "UpdateKmsIssuerPolicyResponseVariant1Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateKmsIssuerPolicyResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateKmsIssuerPolicyResponseVariant2Kind), TypeInfoPropertyName = "UpdateKmsIssuerPolicyResponseVariant2Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, double?>?), TypeInfoPropertyName = "NullableOneOfStringDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKShared38e9af03824d67bcStatus?), TypeInfoPropertyName = "NullableAutoSDKShared38e9af03824d67bcStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKShared6a7dd045a7a1bf61Algorithm?), TypeInfoPropertyName = "NullableAutoSDKShared6a7dd045a7a1bf61Algorithm2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKShared6a7dd045a7a1bf61Origin?), TypeInfoPropertyName = "NullableAutoSDKShared6a7dd045a7a1bf61Origin2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.AutoSDKShared6a7dd045a7a1bf61PolicieVariant1, global::Vercel.AutoSDKShared6a7dd045a7a1bf61PolicieVariant2>?), TypeInfoPropertyName = "NullableOneOfAutoSDKShared6a7dd045a7a1bf61PolicieVariant1AutoSDKShared6a7dd045a7a1bf61PolicieVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKShared6a7dd045a7a1bf61PolicieVariant1Kind?), TypeInfoPropertyName = "NullableAutoSDKShared6a7dd045a7a1bf61PolicieVariant1Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKShared6a7dd045a7a1bf61PolicieVariant2Kind?), TypeInfoPropertyName = "NullableAutoSDKShared6a7dd045a7a1bf61PolicieVariant2Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateKmsIssuerRequestAlgorithm?), TypeInfoPropertyName = "NullableCreateKmsIssuerRequestAlgorithm2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.CreateKmsIssuerRequestPolicyVariant1, global::Vercel.CreateKmsIssuerRequestPolicyVariant2>?), TypeInfoPropertyName = "NullableOneOfCreateKmsIssuerRequestPolicyVariant1CreateKmsIssuerRequestPolicyVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateKmsIssuerRequestPolicyVariant1Kind?), TypeInfoPropertyName = "NullableCreateKmsIssuerRequestPolicyVariant1Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateKmsIssuerRequestPolicyVariant2Kind?), TypeInfoPropertyName = "NullableCreateKmsIssuerRequestPolicyVariant2Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateKmsSigningKeyRequestActivation?), TypeInfoPropertyName = "NullableCreateKmsSigningKeyRequestActivation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateKmsIssuerPolicyRequestKind?), TypeInfoPropertyName = "NullableCreateKmsIssuerPolicyRequestKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateKmsIssuerPolicyKind?), TypeInfoPropertyName = "NullableUpdateKmsIssuerPolicyKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.DeleteKmsIssuerPolicyKind?), TypeInfoPropertyName = "NullableDeleteKmsIssuerPolicyKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.CreateKmsIssuerPolicyResponseVariant1, global::Vercel.CreateKmsIssuerPolicyResponseVariant2>?), TypeInfoPropertyName = "NullableOneOfCreateKmsIssuerPolicyResponseVariant1CreateKmsIssuerPolicyResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateKmsIssuerPolicyResponseVariant1Kind?), TypeInfoPropertyName = "NullableCreateKmsIssuerPolicyResponseVariant1Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateKmsIssuerPolicyResponseVariant2Kind?), TypeInfoPropertyName = "NullableCreateKmsIssuerPolicyResponseVariant2Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.UpdateKmsIssuerPolicyResponseVariant1, global::Vercel.UpdateKmsIssuerPolicyResponseVariant2>?), TypeInfoPropertyName = "NullableOneOfUpdateKmsIssuerPolicyResponseVariant1UpdateKmsIssuerPolicyResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateKmsIssuerPolicyResponseVariant1Kind?), TypeInfoPropertyName = "NullableUpdateKmsIssuerPolicyResponseVariant1Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateKmsIssuerPolicyResponseVariant2Kind?), TypeInfoPropertyName = "NullableUpdateKmsIssuerPolicyResponseVariant2Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.OneOf<global::Vercel.AutoSDKShared6a7dd045a7a1bf61PolicieVariant1, global::Vercel.AutoSDKShared6a7dd045a7a1bf61PolicieVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.AutoSDKShared38e9af03824d67bc>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.AutoSDKShared6a7dd045a7a1bf61>))]
    internal sealed partial class KmsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class KmsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static KmsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private KmsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AutoSDKShared6a7dd045a7a1bf61PolicieVariant1, global::Vercel.AutoSDKShared6a7dd045a7a1bf61PolicieVariant2>());
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
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.CreateKmsIssuerRequestPolicyVariant1, global::Vercel.CreateKmsIssuerRequestPolicyVariant2>());
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
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, object, global::System.Collections.Generic.IList<object>, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<double>, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<double>, bool?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.CreateKmsIssuerPolicyResponseVariant1, global::Vercel.CreateKmsIssuerPolicyResponseVariant2>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.UpdateKmsIssuerPolicyResponseVariant1, global::Vercel.UpdateKmsIssuerPolicyResponseVariant2>());
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
                    typeToConvert == typeof(global::Vercel.AutoSDKShared38e9af03824d67bcStatus)

                    || typeToConvert == typeof(global::Vercel.AutoSDKShared38e9af03824d67bcStatus?)

                    || typeToConvert == typeof(global::Vercel.AutoSDKShared6a7dd045a7a1bf61Algorithm)

                    || typeToConvert == typeof(global::Vercel.AutoSDKShared6a7dd045a7a1bf61Algorithm?)

                    || typeToConvert == typeof(global::Vercel.AutoSDKShared6a7dd045a7a1bf61Origin)

                    || typeToConvert == typeof(global::Vercel.AutoSDKShared6a7dd045a7a1bf61Origin?)

                    || typeToConvert == typeof(global::Vercel.AutoSDKShared6a7dd045a7a1bf61PolicieVariant1Kind)

                    || typeToConvert == typeof(global::Vercel.AutoSDKShared6a7dd045a7a1bf61PolicieVariant1Kind?)

                    || typeToConvert == typeof(global::Vercel.AutoSDKShared6a7dd045a7a1bf61PolicieVariant2Kind)

                    || typeToConvert == typeof(global::Vercel.AutoSDKShared6a7dd045a7a1bf61PolicieVariant2Kind?)

                    || typeToConvert == typeof(global::Vercel.CreateKmsIssuerRequestAlgorithm)

                    || typeToConvert == typeof(global::Vercel.CreateKmsIssuerRequestAlgorithm?)

                    || typeToConvert == typeof(global::Vercel.CreateKmsIssuerRequestPolicyVariant1Kind)

                    || typeToConvert == typeof(global::Vercel.CreateKmsIssuerRequestPolicyVariant1Kind?)

                    || typeToConvert == typeof(global::Vercel.CreateKmsIssuerRequestPolicyVariant2Kind)

                    || typeToConvert == typeof(global::Vercel.CreateKmsIssuerRequestPolicyVariant2Kind?)

                    || typeToConvert == typeof(global::Vercel.CreateKmsSigningKeyRequestActivation)

                    || typeToConvert == typeof(global::Vercel.CreateKmsSigningKeyRequestActivation?)

                    || typeToConvert == typeof(global::Vercel.CreateKmsIssuerPolicyRequestKind)

                    || typeToConvert == typeof(global::Vercel.CreateKmsIssuerPolicyRequestKind?)

                    || typeToConvert == typeof(global::Vercel.UpdateKmsIssuerPolicyKind)

                    || typeToConvert == typeof(global::Vercel.UpdateKmsIssuerPolicyKind?)

                    || typeToConvert == typeof(global::Vercel.DeleteKmsIssuerPolicyKind)

                    || typeToConvert == typeof(global::Vercel.DeleteKmsIssuerPolicyKind?)

                    || typeToConvert == typeof(global::Vercel.CreateKmsIssuerPolicyResponseVariant1Kind)

                    || typeToConvert == typeof(global::Vercel.CreateKmsIssuerPolicyResponseVariant1Kind?)

                    || typeToConvert == typeof(global::Vercel.CreateKmsIssuerPolicyResponseVariant2Kind)

                    || typeToConvert == typeof(global::Vercel.CreateKmsIssuerPolicyResponseVariant2Kind?)

                    || typeToConvert == typeof(global::Vercel.UpdateKmsIssuerPolicyResponseVariant1Kind)

                    || typeToConvert == typeof(global::Vercel.UpdateKmsIssuerPolicyResponseVariant1Kind?)

                    || typeToConvert == typeof(global::Vercel.UpdateKmsIssuerPolicyResponseVariant2Kind)

                    || typeToConvert == typeof(global::Vercel.UpdateKmsIssuerPolicyResponseVariant2Kind?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Vercel.AutoSDKShared38e9af03824d67bcStatus))
                {
                    return new global::Vercel.JsonConverters.AutoSDKShared38e9af03824d67bcStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AutoSDKShared38e9af03824d67bcStatus?))
                {
                    return new global::Vercel.JsonConverters.AutoSDKShared38e9af03824d67bcStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AutoSDKShared6a7dd045a7a1bf61Algorithm))
                {
                    return new global::Vercel.JsonConverters.AutoSDKShared6a7dd045a7a1bf61AlgorithmJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AutoSDKShared6a7dd045a7a1bf61Algorithm?))
                {
                    return new global::Vercel.JsonConverters.AutoSDKShared6a7dd045a7a1bf61AlgorithmNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AutoSDKShared6a7dd045a7a1bf61Origin))
                {
                    return new global::Vercel.JsonConverters.AutoSDKShared6a7dd045a7a1bf61OriginJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AutoSDKShared6a7dd045a7a1bf61Origin?))
                {
                    return new global::Vercel.JsonConverters.AutoSDKShared6a7dd045a7a1bf61OriginNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AutoSDKShared6a7dd045a7a1bf61PolicieVariant1Kind))
                {
                    return new global::Vercel.JsonConverters.AutoSDKShared6a7dd045a7a1bf61PolicieVariant1KindJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AutoSDKShared6a7dd045a7a1bf61PolicieVariant1Kind?))
                {
                    return new global::Vercel.JsonConverters.AutoSDKShared6a7dd045a7a1bf61PolicieVariant1KindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AutoSDKShared6a7dd045a7a1bf61PolicieVariant2Kind))
                {
                    return new global::Vercel.JsonConverters.AutoSDKShared6a7dd045a7a1bf61PolicieVariant2KindJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AutoSDKShared6a7dd045a7a1bf61PolicieVariant2Kind?))
                {
                    return new global::Vercel.JsonConverters.AutoSDKShared6a7dd045a7a1bf61PolicieVariant2KindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateKmsIssuerRequestAlgorithm))
                {
                    return new global::Vercel.JsonConverters.CreateKmsIssuerRequestAlgorithmJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateKmsIssuerRequestAlgorithm?))
                {
                    return new global::Vercel.JsonConverters.CreateKmsIssuerRequestAlgorithmNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateKmsIssuerRequestPolicyVariant1Kind))
                {
                    return new global::Vercel.JsonConverters.CreateKmsIssuerRequestPolicyVariant1KindJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateKmsIssuerRequestPolicyVariant1Kind?))
                {
                    return new global::Vercel.JsonConverters.CreateKmsIssuerRequestPolicyVariant1KindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateKmsIssuerRequestPolicyVariant2Kind))
                {
                    return new global::Vercel.JsonConverters.CreateKmsIssuerRequestPolicyVariant2KindJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateKmsIssuerRequestPolicyVariant2Kind?))
                {
                    return new global::Vercel.JsonConverters.CreateKmsIssuerRequestPolicyVariant2KindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateKmsSigningKeyRequestActivation))
                {
                    return new global::Vercel.JsonConverters.CreateKmsSigningKeyRequestActivationJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateKmsSigningKeyRequestActivation?))
                {
                    return new global::Vercel.JsonConverters.CreateKmsSigningKeyRequestActivationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateKmsIssuerPolicyRequestKind))
                {
                    return new global::Vercel.JsonConverters.CreateKmsIssuerPolicyRequestKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateKmsIssuerPolicyRequestKind?))
                {
                    return new global::Vercel.JsonConverters.CreateKmsIssuerPolicyRequestKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpdateKmsIssuerPolicyKind))
                {
                    return new global::Vercel.JsonConverters.UpdateKmsIssuerPolicyKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpdateKmsIssuerPolicyKind?))
                {
                    return new global::Vercel.JsonConverters.UpdateKmsIssuerPolicyKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.DeleteKmsIssuerPolicyKind))
                {
                    return new global::Vercel.JsonConverters.DeleteKmsIssuerPolicyKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.DeleteKmsIssuerPolicyKind?))
                {
                    return new global::Vercel.JsonConverters.DeleteKmsIssuerPolicyKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateKmsIssuerPolicyResponseVariant1Kind))
                {
                    return new global::Vercel.JsonConverters.CreateKmsIssuerPolicyResponseVariant1KindJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateKmsIssuerPolicyResponseVariant1Kind?))
                {
                    return new global::Vercel.JsonConverters.CreateKmsIssuerPolicyResponseVariant1KindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateKmsIssuerPolicyResponseVariant2Kind))
                {
                    return new global::Vercel.JsonConverters.CreateKmsIssuerPolicyResponseVariant2KindJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.CreateKmsIssuerPolicyResponseVariant2Kind?))
                {
                    return new global::Vercel.JsonConverters.CreateKmsIssuerPolicyResponseVariant2KindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpdateKmsIssuerPolicyResponseVariant1Kind))
                {
                    return new global::Vercel.JsonConverters.UpdateKmsIssuerPolicyResponseVariant1KindJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpdateKmsIssuerPolicyResponseVariant1Kind?))
                {
                    return new global::Vercel.JsonConverters.UpdateKmsIssuerPolicyResponseVariant1KindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpdateKmsIssuerPolicyResponseVariant2Kind))
                {
                    return new global::Vercel.JsonConverters.UpdateKmsIssuerPolicyResponseVariant2KindJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UpdateKmsIssuerPolicyResponseVariant2Kind?))
                {
                    return new global::Vercel.JsonConverters.UpdateKmsIssuerPolicyResponseVariant2KindNullableJsonConverter();
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
                    0 => new KmsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}