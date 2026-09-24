
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.Pagination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AuthToken))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.AuthTokenScopeVariant1, global::Vercel.AuthTokenScopeVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.AuthTokenScopeVariant1, global::Vercel.AuthTokenScopeVariant2>), TypeInfoPropertyName = "OneOfAuthTokenScopeVariant1AuthTokenScopeVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AuthTokenScopeVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AuthTokenScopeVariant1Origin), TypeInfoPropertyName = "AuthTokenScopeVariant1Origin2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AuthTokenScopeVariant1Sudo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AuthTokenScopeVariant1SudoOrigin), TypeInfoPropertyName = "AuthTokenScopeVariant1SudoOrigin2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AuthTokenScopeVariant1Type), TypeInfoPropertyName = "AuthTokenScopeVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AuthTokenScopeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AuthTokenScopeVariant2Origin), TypeInfoPropertyName = "AuthTokenScopeVariant2Origin2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AuthTokenScopeVariant2Type), TypeInfoPropertyName = "AuthTokenScopeVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.ExchangeSsoTokenRequestVariant1, global::Vercel.ExchangeSsoTokenRequestVariant2>), TypeInfoPropertyName = "OneOfExchangeSsoTokenRequestVariant1ExchangeSsoTokenRequestVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ExchangeSsoTokenRequestVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ExchangeSsoTokenRequestVariant1GrantType), TypeInfoPropertyName = "ExchangeSsoTokenRequestVariant1GrantType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ExchangeSsoTokenRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ExchangeSsoTokenRequestVariant2GrantType), TypeInfoPropertyName = "ExchangeSsoTokenRequestVariant2GrantType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateAuthTokenRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.ExchangeSsoTokenResponseVariant1, global::Vercel.ExchangeSsoTokenResponseVariant2>), TypeInfoPropertyName = "OneOfExchangeSsoTokenResponseVariant1ExchangeSsoTokenResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ExchangeSsoTokenResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ExchangeSsoTokenResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.ListAuthTokensResponseVariant1, global::Vercel.ListAuthTokensResponseVariant2>), TypeInfoPropertyName = "OneOfListAuthTokensResponseVariant1ListAuthTokensResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListAuthTokensResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListAuthTokensResponseVariant1Pagination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.AuthToken>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListAuthTokensResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CreateAuthTokenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetAuthTokenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.DeleteAuthTokenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.AuthTokenScopeVariant1, global::Vercel.AuthTokenScopeVariant2>?), TypeInfoPropertyName = "NullableOneOfAuthTokenScopeVariant1AuthTokenScopeVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AuthTokenScopeVariant1Origin?), TypeInfoPropertyName = "NullableAuthTokenScopeVariant1Origin2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AuthTokenScopeVariant1SudoOrigin?), TypeInfoPropertyName = "NullableAuthTokenScopeVariant1SudoOrigin2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AuthTokenScopeVariant1Type?), TypeInfoPropertyName = "NullableAuthTokenScopeVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AuthTokenScopeVariant2Origin?), TypeInfoPropertyName = "NullableAuthTokenScopeVariant2Origin2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AuthTokenScopeVariant2Type?), TypeInfoPropertyName = "NullableAuthTokenScopeVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.ExchangeSsoTokenRequestVariant1, global::Vercel.ExchangeSsoTokenRequestVariant2>?), TypeInfoPropertyName = "NullableOneOfExchangeSsoTokenRequestVariant1ExchangeSsoTokenRequestVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ExchangeSsoTokenRequestVariant1GrantType?), TypeInfoPropertyName = "NullableExchangeSsoTokenRequestVariant1GrantType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ExchangeSsoTokenRequestVariant2GrantType?), TypeInfoPropertyName = "NullableExchangeSsoTokenRequestVariant2GrantType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.ExchangeSsoTokenResponseVariant1, global::Vercel.ExchangeSsoTokenResponseVariant2>?), TypeInfoPropertyName = "NullableOneOfExchangeSsoTokenResponseVariant1ExchangeSsoTokenResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.ListAuthTokensResponseVariant1, global::Vercel.ListAuthTokensResponseVariant2>?), TypeInfoPropertyName = "NullableOneOfListAuthTokensResponseVariant1ListAuthTokensResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.OneOf<global::Vercel.AuthTokenScopeVariant1, global::Vercel.AuthTokenScopeVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.AuthToken>))]
    internal sealed partial class AuthenticationSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AuthenticationSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AuthenticationSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AuthenticationSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AuthTokenScopeVariant1, global::Vercel.AuthTokenScopeVariant2>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<string, double?, global::System.Collections.Generic.IList<string>>());
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
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.ExchangeSsoTokenRequestVariant1, global::Vercel.ExchangeSsoTokenRequestVariant2>());
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
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.ExchangeSsoTokenResponseVariant1, global::Vercel.ExchangeSsoTokenResponseVariant2>());
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
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.ListAuthTokensResponseVariant1, global::Vercel.ListAuthTokensResponseVariant2>());
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
                    typeToConvert == typeof(global::Vercel.AuthTokenScopeVariant1Origin)

                    || typeToConvert == typeof(global::Vercel.AuthTokenScopeVariant1Origin?)

                    || typeToConvert == typeof(global::Vercel.AuthTokenScopeVariant1SudoOrigin)

                    || typeToConvert == typeof(global::Vercel.AuthTokenScopeVariant1SudoOrigin?)

                    || typeToConvert == typeof(global::Vercel.AuthTokenScopeVariant1Type)

                    || typeToConvert == typeof(global::Vercel.AuthTokenScopeVariant1Type?)

                    || typeToConvert == typeof(global::Vercel.AuthTokenScopeVariant2Origin)

                    || typeToConvert == typeof(global::Vercel.AuthTokenScopeVariant2Origin?)

                    || typeToConvert == typeof(global::Vercel.AuthTokenScopeVariant2Type)

                    || typeToConvert == typeof(global::Vercel.AuthTokenScopeVariant2Type?)

                    || typeToConvert == typeof(global::Vercel.ExchangeSsoTokenRequestVariant1GrantType)

                    || typeToConvert == typeof(global::Vercel.ExchangeSsoTokenRequestVariant1GrantType?)

                    || typeToConvert == typeof(global::Vercel.ExchangeSsoTokenRequestVariant2GrantType)

                    || typeToConvert == typeof(global::Vercel.ExchangeSsoTokenRequestVariant2GrantType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Vercel.AuthTokenScopeVariant1Origin))
                {
                    return new global::Vercel.JsonConverters.AuthTokenScopeVariant1OriginJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AuthTokenScopeVariant1Origin?))
                {
                    return new global::Vercel.JsonConverters.AuthTokenScopeVariant1OriginNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AuthTokenScopeVariant1SudoOrigin))
                {
                    return new global::Vercel.JsonConverters.AuthTokenScopeVariant1SudoOriginJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AuthTokenScopeVariant1SudoOrigin?))
                {
                    return new global::Vercel.JsonConverters.AuthTokenScopeVariant1SudoOriginNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AuthTokenScopeVariant1Type))
                {
                    return new global::Vercel.JsonConverters.AuthTokenScopeVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AuthTokenScopeVariant1Type?))
                {
                    return new global::Vercel.JsonConverters.AuthTokenScopeVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AuthTokenScopeVariant2Origin))
                {
                    return new global::Vercel.JsonConverters.AuthTokenScopeVariant2OriginJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AuthTokenScopeVariant2Origin?))
                {
                    return new global::Vercel.JsonConverters.AuthTokenScopeVariant2OriginNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AuthTokenScopeVariant2Type))
                {
                    return new global::Vercel.JsonConverters.AuthTokenScopeVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AuthTokenScopeVariant2Type?))
                {
                    return new global::Vercel.JsonConverters.AuthTokenScopeVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ExchangeSsoTokenRequestVariant1GrantType))
                {
                    return new global::Vercel.JsonConverters.ExchangeSsoTokenRequestVariant1GrantTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ExchangeSsoTokenRequestVariant1GrantType?))
                {
                    return new global::Vercel.JsonConverters.ExchangeSsoTokenRequestVariant1GrantTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ExchangeSsoTokenRequestVariant2GrantType))
                {
                    return new global::Vercel.JsonConverters.ExchangeSsoTokenRequestVariant2GrantTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ExchangeSsoTokenRequestVariant2GrantType?))
                {
                    return new global::Vercel.JsonConverters.ExchangeSsoTokenRequestVariant2GrantTypeNullableJsonConverter();
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
                    0 => new AuthenticationSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}