
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.GetRollingReleaseBillingStatusResponseVariant1, global::Vercel.GetRollingReleaseBillingStatusResponseVariant2, global::Vercel.GetRollingReleaseBillingStatusResponseVariant3, global::Vercel.GetRollingReleaseBillingStatusResponseVariant4>), TypeInfoPropertyName = "GetRollingReleaseBillingStatusResponseVariant4_b5df865dd71f7e5d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.GetRollingReleaseBillingStatusResponseVariant1, global::Vercel.GetRollingReleaseBillingStatusResponseVariant2, global::Vercel.GetRollingReleaseBillingStatusResponseVariant3, global::Vercel.GetRollingReleaseBillingStatusResponseVariant4>?), TypeInfoPropertyName = "GetRollingReleaseBillingStatusResponseVariant4_c711982a09f92f95")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKShared42a87d29a5696121))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKShared24441ee6c19033d7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKSharedfabd867705b7541a))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKShared3976a2c0c206ff70))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKShared3976a2c0c206ff70Action), TypeInfoPropertyName = "AutoSDKShared3976a2c0c206ff70Action2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared3976a2c0c206ff70Check>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKShared3976a2c0c206ff70Check))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKShared3976a2c0c206ff70CheckType), TypeInfoPropertyName = "AutoSDKShared3976a2c0c206ff70CheckType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.AutoSDKShared42a87d29a5696121Stage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKShared42a87d29a5696121Stage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKSharedfabd867705b7541aActiveStage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKSharedfabd867705b7541aAdvancementType), TypeInfoPropertyName = "AutoSDKSharedfabd867705b7541aAdvancementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKSharedfabd867705b7541aCanaryDeployment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKSharedfabd867705b7541aCanaryDeploymentReadyState), TypeInfoPropertyName = "AutoSDKSharedfabd867705b7541aCanaryDeploymentReadyState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKSharedfabd867705b7541aCanaryDeploymentSource), TypeInfoPropertyName = "AutoSDKSharedfabd867705b7541aCanaryDeploymentSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKSharedfabd867705b7541aCanaryDeploymentTarget), TypeInfoPropertyName = "AutoSDKSharedfabd867705b7541aCanaryDeploymentTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKSharedfabd867705b7541aCurrentDeployment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKSharedfabd867705b7541aCurrentDeploymentReadyState), TypeInfoPropertyName = "AutoSDKSharedfabd867705b7541aCurrentDeploymentReadyState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKSharedfabd867705b7541aCurrentDeploymentSource), TypeInfoPropertyName = "AutoSDKSharedfabd867705b7541aCurrentDeploymentSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKSharedfabd867705b7541aCurrentDeploymentTarget), TypeInfoPropertyName = "AutoSDKSharedfabd867705b7541aCurrentDeploymentTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKSharedfabd867705b7541aNextStage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.AutoSDKSharedfabd867705b7541aStage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKSharedfabd867705b7541aStage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKSharedfabd867705b7541aState), TypeInfoPropertyName = "AutoSDKSharedfabd867705b7541aState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKSharedfabd867705b7541aSubstate), TypeInfoPropertyName = "AutoSDKSharedfabd867705b7541aSubstate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ApproveRollingReleaseStageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.StartRollingReleaseRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.CompleteRollingReleaseRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseState), TypeInfoPropertyName = "GetRollingReleaseState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant1Reason), TypeInfoPropertyName = "GetRollingReleaseBillingStatusResponseVariant1Reason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant2AvailableSlots), TypeInfoPropertyName = "GetRollingReleaseBillingStatusResponseVariant2AvailableSlots2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant2Reason), TypeInfoPropertyName = "GetRollingReleaseBillingStatusResponseVariant2Reason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant3Reason), TypeInfoPropertyName = "GetRollingReleaseBillingStatusResponseVariant3Reason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant4Reason), TypeInfoPropertyName = "GetRollingReleaseBillingStatusResponseVariant4Reason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseConfigResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.DeleteRollingReleaseConfigResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.UpdateRollingReleaseConfigResponseVariant1, global::Vercel.UpdateRollingReleaseConfigResponseVariant2>), TypeInfoPropertyName = "OneOfUpdateRollingReleaseConfigResponseVariant1UpdateRollingReleaseConfigResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateRollingReleaseConfigResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateRollingReleaseConfigResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateRollingReleaseConfigResponseVariant2RollingRelease))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.UpdateRollingReleaseConfigResponseVariant2RollingReleaseStage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UpdateRollingReleaseConfigResponseVariant2RollingReleaseStage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKShared3976a2c0c206ff70Action?), TypeInfoPropertyName = "NullableAutoSDKShared3976a2c0c206ff70Action2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKShared3976a2c0c206ff70CheckType?), TypeInfoPropertyName = "NullableAutoSDKShared3976a2c0c206ff70CheckType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKSharedfabd867705b7541aAdvancementType?), TypeInfoPropertyName = "NullableAutoSDKSharedfabd867705b7541aAdvancementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKSharedfabd867705b7541aCanaryDeploymentReadyState?), TypeInfoPropertyName = "NullableAutoSDKSharedfabd867705b7541aCanaryDeploymentReadyState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKSharedfabd867705b7541aCanaryDeploymentSource?), TypeInfoPropertyName = "NullableAutoSDKSharedfabd867705b7541aCanaryDeploymentSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKSharedfabd867705b7541aCanaryDeploymentTarget?), TypeInfoPropertyName = "NullableAutoSDKSharedfabd867705b7541aCanaryDeploymentTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKSharedfabd867705b7541aCurrentDeploymentReadyState?), TypeInfoPropertyName = "NullableAutoSDKSharedfabd867705b7541aCurrentDeploymentReadyState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKSharedfabd867705b7541aCurrentDeploymentSource?), TypeInfoPropertyName = "NullableAutoSDKSharedfabd867705b7541aCurrentDeploymentSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKSharedfabd867705b7541aCurrentDeploymentTarget?), TypeInfoPropertyName = "NullableAutoSDKSharedfabd867705b7541aCurrentDeploymentTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKSharedfabd867705b7541aState?), TypeInfoPropertyName = "NullableAutoSDKSharedfabd867705b7541aState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AutoSDKSharedfabd867705b7541aSubstate?), TypeInfoPropertyName = "NullableAutoSDKSharedfabd867705b7541aSubstate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseState?), TypeInfoPropertyName = "NullableGetRollingReleaseState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant1Reason?), TypeInfoPropertyName = "NullableGetRollingReleaseBillingStatusResponseVariant1Reason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant2AvailableSlots?), TypeInfoPropertyName = "NullableGetRollingReleaseBillingStatusResponseVariant2AvailableSlots2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant2Reason?), TypeInfoPropertyName = "NullableGetRollingReleaseBillingStatusResponseVariant2Reason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant3Reason?), TypeInfoPropertyName = "NullableGetRollingReleaseBillingStatusResponseVariant3Reason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant4Reason?), TypeInfoPropertyName = "NullableGetRollingReleaseBillingStatusResponseVariant4Reason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.UpdateRollingReleaseConfigResponseVariant1, global::Vercel.UpdateRollingReleaseConfigResponseVariant2>?), TypeInfoPropertyName = "NullableOneOfUpdateRollingReleaseConfigResponseVariant1UpdateRollingReleaseConfigResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.AutoSDKShared3976a2c0c206ff70Check>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.AutoSDKShared42a87d29a5696121Stage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.AutoSDKSharedfabd867705b7541aStage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.UpdateRollingReleaseConfigResponseVariant2RollingReleaseStage>))]
    internal sealed partial class RollingReleaseSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RollingReleaseSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static RollingReleaseSourceGenerationContext Default { get; } = new(DefaultOptions);

        private RollingReleaseSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.GetRollingReleaseBillingStatusResponseVariant1, global::Vercel.GetRollingReleaseBillingStatusResponseVariant2, global::Vercel.GetRollingReleaseBillingStatusResponseVariant3, global::Vercel.GetRollingReleaseBillingStatusResponseVariant4>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.UpdateRollingReleaseConfigResponseVariant1, global::Vercel.UpdateRollingReleaseConfigResponseVariant2>());
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
                    typeToConvert == typeof(global::Vercel.AutoSDKShared3976a2c0c206ff70Action)

                    || typeToConvert == typeof(global::Vercel.AutoSDKShared3976a2c0c206ff70Action?)

                    || typeToConvert == typeof(global::Vercel.AutoSDKShared3976a2c0c206ff70CheckType)

                    || typeToConvert == typeof(global::Vercel.AutoSDKShared3976a2c0c206ff70CheckType?)

                    || typeToConvert == typeof(global::Vercel.AutoSDKSharedfabd867705b7541aAdvancementType)

                    || typeToConvert == typeof(global::Vercel.AutoSDKSharedfabd867705b7541aAdvancementType?)

                    || typeToConvert == typeof(global::Vercel.AutoSDKSharedfabd867705b7541aCanaryDeploymentReadyState)

                    || typeToConvert == typeof(global::Vercel.AutoSDKSharedfabd867705b7541aCanaryDeploymentReadyState?)

                    || typeToConvert == typeof(global::Vercel.AutoSDKSharedfabd867705b7541aCanaryDeploymentSource)

                    || typeToConvert == typeof(global::Vercel.AutoSDKSharedfabd867705b7541aCanaryDeploymentSource?)

                    || typeToConvert == typeof(global::Vercel.AutoSDKSharedfabd867705b7541aCanaryDeploymentTarget)

                    || typeToConvert == typeof(global::Vercel.AutoSDKSharedfabd867705b7541aCanaryDeploymentTarget?)

                    || typeToConvert == typeof(global::Vercel.AutoSDKSharedfabd867705b7541aCurrentDeploymentReadyState)

                    || typeToConvert == typeof(global::Vercel.AutoSDKSharedfabd867705b7541aCurrentDeploymentReadyState?)

                    || typeToConvert == typeof(global::Vercel.AutoSDKSharedfabd867705b7541aCurrentDeploymentSource)

                    || typeToConvert == typeof(global::Vercel.AutoSDKSharedfabd867705b7541aCurrentDeploymentSource?)

                    || typeToConvert == typeof(global::Vercel.AutoSDKSharedfabd867705b7541aCurrentDeploymentTarget)

                    || typeToConvert == typeof(global::Vercel.AutoSDKSharedfabd867705b7541aCurrentDeploymentTarget?)

                    || typeToConvert == typeof(global::Vercel.AutoSDKSharedfabd867705b7541aState)

                    || typeToConvert == typeof(global::Vercel.AutoSDKSharedfabd867705b7541aState?)

                    || typeToConvert == typeof(global::Vercel.AutoSDKSharedfabd867705b7541aSubstate)

                    || typeToConvert == typeof(global::Vercel.AutoSDKSharedfabd867705b7541aSubstate?)

                    || typeToConvert == typeof(global::Vercel.GetRollingReleaseState)

                    || typeToConvert == typeof(global::Vercel.GetRollingReleaseState?)

                    || typeToConvert == typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant1Reason)

                    || typeToConvert == typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant1Reason?)

                    || typeToConvert == typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant2AvailableSlots)

                    || typeToConvert == typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant2AvailableSlots?)

                    || typeToConvert == typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant2Reason)

                    || typeToConvert == typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant2Reason?)

                    || typeToConvert == typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant3Reason)

                    || typeToConvert == typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant3Reason?)

                    || typeToConvert == typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant4Reason)

                    || typeToConvert == typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant4Reason?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Vercel.AutoSDKShared3976a2c0c206ff70Action))
                {
                    return new global::Vercel.JsonConverters.AutoSDKShared3976a2c0c206ff70ActionJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AutoSDKShared3976a2c0c206ff70Action?))
                {
                    return new global::Vercel.JsonConverters.AutoSDKShared3976a2c0c206ff70ActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AutoSDKShared3976a2c0c206ff70CheckType))
                {
                    return new global::Vercel.JsonConverters.AutoSDKShared3976a2c0c206ff70CheckTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AutoSDKShared3976a2c0c206ff70CheckType?))
                {
                    return new global::Vercel.JsonConverters.AutoSDKShared3976a2c0c206ff70CheckTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AutoSDKSharedfabd867705b7541aAdvancementType))
                {
                    return new global::Vercel.JsonConverters.AutoSDKSharedfabd867705b7541aAdvancementTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AutoSDKSharedfabd867705b7541aAdvancementType?))
                {
                    return new global::Vercel.JsonConverters.AutoSDKSharedfabd867705b7541aAdvancementTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AutoSDKSharedfabd867705b7541aCanaryDeploymentReadyState))
                {
                    return new global::Vercel.JsonConverters.AutoSDKSharedfabd867705b7541aCanaryDeploymentReadyStateJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AutoSDKSharedfabd867705b7541aCanaryDeploymentReadyState?))
                {
                    return new global::Vercel.JsonConverters.AutoSDKSharedfabd867705b7541aCanaryDeploymentReadyStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AutoSDKSharedfabd867705b7541aCanaryDeploymentSource))
                {
                    return new global::Vercel.JsonConverters.AutoSDKSharedfabd867705b7541aCanaryDeploymentSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AutoSDKSharedfabd867705b7541aCanaryDeploymentSource?))
                {
                    return new global::Vercel.JsonConverters.AutoSDKSharedfabd867705b7541aCanaryDeploymentSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AutoSDKSharedfabd867705b7541aCanaryDeploymentTarget))
                {
                    return new global::Vercel.JsonConverters.AutoSDKSharedfabd867705b7541aCanaryDeploymentTargetJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AutoSDKSharedfabd867705b7541aCanaryDeploymentTarget?))
                {
                    return new global::Vercel.JsonConverters.AutoSDKSharedfabd867705b7541aCanaryDeploymentTargetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AutoSDKSharedfabd867705b7541aCurrentDeploymentReadyState))
                {
                    return new global::Vercel.JsonConverters.AutoSDKSharedfabd867705b7541aCurrentDeploymentReadyStateJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AutoSDKSharedfabd867705b7541aCurrentDeploymentReadyState?))
                {
                    return new global::Vercel.JsonConverters.AutoSDKSharedfabd867705b7541aCurrentDeploymentReadyStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AutoSDKSharedfabd867705b7541aCurrentDeploymentSource))
                {
                    return new global::Vercel.JsonConverters.AutoSDKSharedfabd867705b7541aCurrentDeploymentSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AutoSDKSharedfabd867705b7541aCurrentDeploymentSource?))
                {
                    return new global::Vercel.JsonConverters.AutoSDKSharedfabd867705b7541aCurrentDeploymentSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AutoSDKSharedfabd867705b7541aCurrentDeploymentTarget))
                {
                    return new global::Vercel.JsonConverters.AutoSDKSharedfabd867705b7541aCurrentDeploymentTargetJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AutoSDKSharedfabd867705b7541aCurrentDeploymentTarget?))
                {
                    return new global::Vercel.JsonConverters.AutoSDKSharedfabd867705b7541aCurrentDeploymentTargetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AutoSDKSharedfabd867705b7541aState))
                {
                    return new global::Vercel.JsonConverters.AutoSDKSharedfabd867705b7541aStateJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AutoSDKSharedfabd867705b7541aState?))
                {
                    return new global::Vercel.JsonConverters.AutoSDKSharedfabd867705b7541aStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AutoSDKSharedfabd867705b7541aSubstate))
                {
                    return new global::Vercel.JsonConverters.AutoSDKSharedfabd867705b7541aSubstateJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AutoSDKSharedfabd867705b7541aSubstate?))
                {
                    return new global::Vercel.JsonConverters.AutoSDKSharedfabd867705b7541aSubstateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRollingReleaseState))
                {
                    return new global::Vercel.JsonConverters.GetRollingReleaseStateJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRollingReleaseState?))
                {
                    return new global::Vercel.JsonConverters.GetRollingReleaseStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant1Reason))
                {
                    return new global::Vercel.JsonConverters.GetRollingReleaseBillingStatusResponseVariant1ReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant1Reason?))
                {
                    return new global::Vercel.JsonConverters.GetRollingReleaseBillingStatusResponseVariant1ReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant2AvailableSlots))
                {
                    return new global::Vercel.JsonConverters.GetRollingReleaseBillingStatusResponseVariant2AvailableSlotsJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant2AvailableSlots?))
                {
                    return new global::Vercel.JsonConverters.GetRollingReleaseBillingStatusResponseVariant2AvailableSlotsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant2Reason))
                {
                    return new global::Vercel.JsonConverters.GetRollingReleaseBillingStatusResponseVariant2ReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant2Reason?))
                {
                    return new global::Vercel.JsonConverters.GetRollingReleaseBillingStatusResponseVariant2ReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant3Reason))
                {
                    return new global::Vercel.JsonConverters.GetRollingReleaseBillingStatusResponseVariant3ReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant3Reason?))
                {
                    return new global::Vercel.JsonConverters.GetRollingReleaseBillingStatusResponseVariant3ReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant4Reason))
                {
                    return new global::Vercel.JsonConverters.GetRollingReleaseBillingStatusResponseVariant4ReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.GetRollingReleaseBillingStatusResponseVariant4Reason?))
                {
                    return new global::Vercel.JsonConverters.GetRollingReleaseBillingStatusResponseVariant4ReasonNullableJsonConverter();
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
                    0 => new RollingReleaseSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}