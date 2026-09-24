
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UserEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.UserEventCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UserEventCategorie), TypeInfoPropertyName = "UserEventCategorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.UserEventEntitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UserEventEntitie))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UserEventEntitieType), TypeInfoPropertyName = "UserEventEntitieType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.UserEventPrincipalVariant1, global::Vercel.UserEventPrincipalVariant2, global::Vercel.UserEventPrincipalVariant3, global::Vercel.UserEventPrincipalVariant4>), TypeInfoPropertyName = "OneOfUserEventPrincipalVariant1UserEventPrincipalVariant2UserEventPrincipalVariant3UserEventPrincipalVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UserEventPrincipalVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UserEventPrincipalVariant1Type), TypeInfoPropertyName = "UserEventPrincipalVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UserEventPrincipalVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UserEventPrincipalVariant2Type), TypeInfoPropertyName = "UserEventPrincipalVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UserEventPrincipalVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UserEventPrincipalVariant3Type), TypeInfoPropertyName = "UserEventPrincipalVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UserEventPrincipalVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UserEventPrincipalVariant4Type), TypeInfoPropertyName = "UserEventPrincipalVariant4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UserEventType), TypeInfoPropertyName = "UserEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UserEventUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.OneOf<global::Vercel.UserEventViaItemVariant1, global::Vercel.UserEventViaItemVariant2, global::Vercel.UserEventViaItemVariant3, global::Vercel.UserEventViaItemVariant4>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.UserEventViaItemVariant1, global::Vercel.UserEventViaItemVariant2, global::Vercel.UserEventViaItemVariant3, global::Vercel.UserEventViaItemVariant4>), TypeInfoPropertyName = "OneOfUserEventViaItemVariant1UserEventViaItemVariant2UserEventViaItemVariant3UserEventViaItemVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UserEventViaItemVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UserEventViaItemVariant1Type), TypeInfoPropertyName = "UserEventViaItemVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UserEventViaItemVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UserEventViaItemVariant2Type), TypeInfoPropertyName = "UserEventViaItemVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UserEventViaItemVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UserEventViaItemVariant3Type), TypeInfoPropertyName = "UserEventViaItemVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UserEventViaItemVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UserEventViaItemVariant4Type), TypeInfoPropertyName = "UserEventViaItemVariant4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.ListEventTypeCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListEventTypeCategorie), TypeInfoPropertyName = "ListEventTypeCategorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListEventTypeName), TypeInfoPropertyName = "ListEventTypeName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.ListEventTypeReplacedByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListEventTypeReplacedByItem), TypeInfoPropertyName = "ListEventTypeReplacedByItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListEventTypesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.ListEventTypesResponseCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListEventTypesResponseCategorie))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListEventTypesResponseCategorieName), TypeInfoPropertyName = "ListEventTypesResponseCategorieName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.ListEventType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, double?>), TypeInfoPropertyName = "OneOfStringDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AuthUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AuthUserAccountUpdateContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.AuthUserAccountUpdateContextManagedTeam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AuthUserAccountUpdateContextManagedTeam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AuthUserAccountUpdateContextOrganization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.AuthUserActiveDashboardView>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AuthUserActiveDashboardView))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AuthUserActiveDashboardViewFavoritesViewPreference), TypeInfoPropertyName = "AuthUserActiveDashboardViewFavoritesViewPreference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AuthUserActiveDashboardViewRecentsViewPreference), TypeInfoPropertyName = "AuthUserActiveDashboardViewRecentsViewPreference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AuthUserActiveDashboardViewViewPreference), TypeInfoPropertyName = "AuthUserActiveDashboardViewViewPreference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AuthUserDataCache))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.AuthUserDismissedToast>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AuthUserDismissedToast))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.AuthUserDismissedToastDismissal>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AuthUserDismissedToastDismissal))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.AuthUserFavoriteProjectsAndSpace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AuthUserFavoriteProjectsAndSpace))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AuthUserFeatureBlocks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AuthUserFeatureBlocksSpeedInsightsFree))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AuthUserFeatureBlocksSpeedInsightsFreeBlockReason), TypeInfoPropertyName = "AuthUserFeatureBlocksSpeedInsightsFreeBlockReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AuthUserFeatureBlocksWebAnalytics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AuthUserImportFlowGitProvider), TypeInfoPropertyName = "AuthUserImportFlowGitProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.AuthUserPreferredScopesAndGitNamespace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AuthUserPreferredScopesAndGitNamespace))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AuthUserRemoteCaching))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AuthUserResourceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AuthUserResourceConfigBuildEntitlements))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AuthUserResourceConfigBuildQueue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AuthUserResourceConfigBuildQueueConfiguration), TypeInfoPropertyName = "AuthUserResourceConfigBuildQueueConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AuthUserResourceConfigSecurity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AuthUserSoftBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AuthUserSoftBlockBlockedDueToOverageType), TypeInfoPropertyName = "AuthUserSoftBlockBlockedDueToOverageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AuthUserSoftBlockReason), TypeInfoPropertyName = "AuthUserSoftBlockReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AuthUserLimited))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.RequestDeleteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.RequestDeleteRequestReason>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.RequestDeleteRequestReason))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListUserEventsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vercel.UserEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.GetAuthUserResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.AuthUser, global::Vercel.AuthUserLimited>), TypeInfoPropertyName = "OneOfAuthUserAuthUserLimited2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.RequestDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UserEventCategorie?), TypeInfoPropertyName = "NullableUserEventCategorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UserEventEntitieType?), TypeInfoPropertyName = "NullableUserEventEntitieType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.UserEventPrincipalVariant1, global::Vercel.UserEventPrincipalVariant2, global::Vercel.UserEventPrincipalVariant3, global::Vercel.UserEventPrincipalVariant4>?), TypeInfoPropertyName = "NullableOneOfUserEventPrincipalVariant1UserEventPrincipalVariant2UserEventPrincipalVariant3UserEventPrincipalVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UserEventPrincipalVariant1Type?), TypeInfoPropertyName = "NullableUserEventPrincipalVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UserEventPrincipalVariant2Type?), TypeInfoPropertyName = "NullableUserEventPrincipalVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UserEventPrincipalVariant3Type?), TypeInfoPropertyName = "NullableUserEventPrincipalVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UserEventPrincipalVariant4Type?), TypeInfoPropertyName = "NullableUserEventPrincipalVariant4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UserEventType?), TypeInfoPropertyName = "NullableUserEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.UserEventViaItemVariant1, global::Vercel.UserEventViaItemVariant2, global::Vercel.UserEventViaItemVariant3, global::Vercel.UserEventViaItemVariant4>?), TypeInfoPropertyName = "NullableOneOfUserEventViaItemVariant1UserEventViaItemVariant2UserEventViaItemVariant3UserEventViaItemVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UserEventViaItemVariant1Type?), TypeInfoPropertyName = "NullableUserEventViaItemVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UserEventViaItemVariant2Type?), TypeInfoPropertyName = "NullableUserEventViaItemVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UserEventViaItemVariant3Type?), TypeInfoPropertyName = "NullableUserEventViaItemVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.UserEventViaItemVariant4Type?), TypeInfoPropertyName = "NullableUserEventViaItemVariant4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListEventTypeCategorie?), TypeInfoPropertyName = "NullableListEventTypeCategorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListEventTypeName?), TypeInfoPropertyName = "NullableListEventTypeName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListEventTypeReplacedByItem?), TypeInfoPropertyName = "NullableListEventTypeReplacedByItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.ListEventTypesResponseCategorieName?), TypeInfoPropertyName = "NullableListEventTypesResponseCategorieName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<string, double?>?), TypeInfoPropertyName = "NullableOneOfStringDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AuthUserActiveDashboardViewFavoritesViewPreference?), TypeInfoPropertyName = "NullableAuthUserActiveDashboardViewFavoritesViewPreference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AuthUserActiveDashboardViewRecentsViewPreference?), TypeInfoPropertyName = "NullableAuthUserActiveDashboardViewRecentsViewPreference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AuthUserActiveDashboardViewViewPreference?), TypeInfoPropertyName = "NullableAuthUserActiveDashboardViewViewPreference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AuthUserFeatureBlocksSpeedInsightsFreeBlockReason?), TypeInfoPropertyName = "NullableAuthUserFeatureBlocksSpeedInsightsFreeBlockReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AuthUserImportFlowGitProvider?), TypeInfoPropertyName = "NullableAuthUserImportFlowGitProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AuthUserResourceConfigBuildQueueConfiguration?), TypeInfoPropertyName = "NullableAuthUserResourceConfigBuildQueueConfiguration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AuthUserSoftBlockBlockedDueToOverageType?), TypeInfoPropertyName = "NullableAuthUserSoftBlockBlockedDueToOverageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.AuthUserSoftBlockReason?), TypeInfoPropertyName = "NullableAuthUserSoftBlockReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vercel.OneOf<global::Vercel.AuthUser, global::Vercel.AuthUserLimited>?), TypeInfoPropertyName = "NullableOneOfAuthUserAuthUserLimited2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.UserEventCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.UserEventEntitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.OneOf<global::Vercel.UserEventViaItemVariant1, global::Vercel.UserEventViaItemVariant2, global::Vercel.UserEventViaItemVariant3, global::Vercel.UserEventViaItemVariant4>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.ListEventTypeCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.ListEventTypeReplacedByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.ListEventTypesResponseCategorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.ListEventType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.AuthUserAccountUpdateContextManagedTeam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.AuthUserActiveDashboardView>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.AuthUserDismissedToast>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.AuthUserDismissedToastDismissal>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.AuthUserFavoriteProjectsAndSpace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.AuthUserPreferredScopesAndGitNamespace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.RequestDeleteRequestReason>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vercel.UserEvent>))]
    internal sealed partial class UserSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UserSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static UserSourceGenerationContext Default { get; } = new(DefaultOptions);

        private UserSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.UserEventPrincipalVariant1, global::Vercel.UserEventPrincipalVariant2, global::Vercel.UserEventPrincipalVariant3, global::Vercel.UserEventPrincipalVariant4>());
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.UserEventViaItemVariant1, global::Vercel.UserEventViaItemVariant2, global::Vercel.UserEventViaItemVariant3, global::Vercel.UserEventViaItemVariant4>());
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
            options.Converters.Add(new global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.AuthUser, global::Vercel.AuthUserLimited>());
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
                    typeToConvert == typeof(global::Vercel.UserEventCategorie)

                    || typeToConvert == typeof(global::Vercel.UserEventCategorie?)

                    || typeToConvert == typeof(global::Vercel.UserEventEntitieType)

                    || typeToConvert == typeof(global::Vercel.UserEventEntitieType?)

                    || typeToConvert == typeof(global::Vercel.UserEventPrincipalVariant1Type)

                    || typeToConvert == typeof(global::Vercel.UserEventPrincipalVariant1Type?)

                    || typeToConvert == typeof(global::Vercel.UserEventPrincipalVariant2Type)

                    || typeToConvert == typeof(global::Vercel.UserEventPrincipalVariant2Type?)

                    || typeToConvert == typeof(global::Vercel.UserEventPrincipalVariant3Type)

                    || typeToConvert == typeof(global::Vercel.UserEventPrincipalVariant3Type?)

                    || typeToConvert == typeof(global::Vercel.UserEventPrincipalVariant4Type)

                    || typeToConvert == typeof(global::Vercel.UserEventPrincipalVariant4Type?)

                    || typeToConvert == typeof(global::Vercel.UserEventType)

                    || typeToConvert == typeof(global::Vercel.UserEventType?)

                    || typeToConvert == typeof(global::Vercel.UserEventViaItemVariant1Type)

                    || typeToConvert == typeof(global::Vercel.UserEventViaItemVariant1Type?)

                    || typeToConvert == typeof(global::Vercel.UserEventViaItemVariant2Type)

                    || typeToConvert == typeof(global::Vercel.UserEventViaItemVariant2Type?)

                    || typeToConvert == typeof(global::Vercel.UserEventViaItemVariant3Type)

                    || typeToConvert == typeof(global::Vercel.UserEventViaItemVariant3Type?)

                    || typeToConvert == typeof(global::Vercel.UserEventViaItemVariant4Type)

                    || typeToConvert == typeof(global::Vercel.UserEventViaItemVariant4Type?)

                    || typeToConvert == typeof(global::Vercel.ListEventTypeCategorie)

                    || typeToConvert == typeof(global::Vercel.ListEventTypeCategorie?)

                    || typeToConvert == typeof(global::Vercel.ListEventTypeName)

                    || typeToConvert == typeof(global::Vercel.ListEventTypeName?)

                    || typeToConvert == typeof(global::Vercel.ListEventTypeReplacedByItem)

                    || typeToConvert == typeof(global::Vercel.ListEventTypeReplacedByItem?)

                    || typeToConvert == typeof(global::Vercel.ListEventTypesResponseCategorieName)

                    || typeToConvert == typeof(global::Vercel.ListEventTypesResponseCategorieName?)

                    || typeToConvert == typeof(global::Vercel.AuthUserActiveDashboardViewFavoritesViewPreference)

                    || typeToConvert == typeof(global::Vercel.AuthUserActiveDashboardViewFavoritesViewPreference?)

                    || typeToConvert == typeof(global::Vercel.AuthUserActiveDashboardViewRecentsViewPreference)

                    || typeToConvert == typeof(global::Vercel.AuthUserActiveDashboardViewRecentsViewPreference?)

                    || typeToConvert == typeof(global::Vercel.AuthUserActiveDashboardViewViewPreference)

                    || typeToConvert == typeof(global::Vercel.AuthUserActiveDashboardViewViewPreference?)

                    || typeToConvert == typeof(global::Vercel.AuthUserFeatureBlocksSpeedInsightsFreeBlockReason)

                    || typeToConvert == typeof(global::Vercel.AuthUserFeatureBlocksSpeedInsightsFreeBlockReason?)

                    || typeToConvert == typeof(global::Vercel.AuthUserImportFlowGitProvider)

                    || typeToConvert == typeof(global::Vercel.AuthUserImportFlowGitProvider?)

                    || typeToConvert == typeof(global::Vercel.AuthUserResourceConfigBuildQueueConfiguration)

                    || typeToConvert == typeof(global::Vercel.AuthUserResourceConfigBuildQueueConfiguration?)

                    || typeToConvert == typeof(global::Vercel.AuthUserSoftBlockBlockedDueToOverageType)

                    || typeToConvert == typeof(global::Vercel.AuthUserSoftBlockBlockedDueToOverageType?)

                    || typeToConvert == typeof(global::Vercel.AuthUserSoftBlockReason)

                    || typeToConvert == typeof(global::Vercel.AuthUserSoftBlockReason?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Vercel.UserEventCategorie))
                {
                    return new global::Vercel.JsonConverters.UserEventCategorieJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UserEventCategorie?))
                {
                    return new global::Vercel.JsonConverters.UserEventCategorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UserEventEntitieType))
                {
                    return new global::Vercel.JsonConverters.UserEventEntitieTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UserEventEntitieType?))
                {
                    return new global::Vercel.JsonConverters.UserEventEntitieTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UserEventPrincipalVariant1Type))
                {
                    return new global::Vercel.JsonConverters.UserEventPrincipalVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UserEventPrincipalVariant1Type?))
                {
                    return new global::Vercel.JsonConverters.UserEventPrincipalVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UserEventPrincipalVariant2Type))
                {
                    return new global::Vercel.JsonConverters.UserEventPrincipalVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UserEventPrincipalVariant2Type?))
                {
                    return new global::Vercel.JsonConverters.UserEventPrincipalVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UserEventPrincipalVariant3Type))
                {
                    return new global::Vercel.JsonConverters.UserEventPrincipalVariant3TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UserEventPrincipalVariant3Type?))
                {
                    return new global::Vercel.JsonConverters.UserEventPrincipalVariant3TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UserEventPrincipalVariant4Type))
                {
                    return new global::Vercel.JsonConverters.UserEventPrincipalVariant4TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UserEventPrincipalVariant4Type?))
                {
                    return new global::Vercel.JsonConverters.UserEventPrincipalVariant4TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UserEventType))
                {
                    return new global::Vercel.JsonConverters.UserEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UserEventType?))
                {
                    return new global::Vercel.JsonConverters.UserEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UserEventViaItemVariant1Type))
                {
                    return new global::Vercel.JsonConverters.UserEventViaItemVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UserEventViaItemVariant1Type?))
                {
                    return new global::Vercel.JsonConverters.UserEventViaItemVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UserEventViaItemVariant2Type))
                {
                    return new global::Vercel.JsonConverters.UserEventViaItemVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UserEventViaItemVariant2Type?))
                {
                    return new global::Vercel.JsonConverters.UserEventViaItemVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UserEventViaItemVariant3Type))
                {
                    return new global::Vercel.JsonConverters.UserEventViaItemVariant3TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UserEventViaItemVariant3Type?))
                {
                    return new global::Vercel.JsonConverters.UserEventViaItemVariant3TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UserEventViaItemVariant4Type))
                {
                    return new global::Vercel.JsonConverters.UserEventViaItemVariant4TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.UserEventViaItemVariant4Type?))
                {
                    return new global::Vercel.JsonConverters.UserEventViaItemVariant4TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ListEventTypeCategorie))
                {
                    return new global::Vercel.JsonConverters.ListEventTypeCategorieJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ListEventTypeCategorie?))
                {
                    return new global::Vercel.JsonConverters.ListEventTypeCategorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ListEventTypeName))
                {
                    return new global::Vercel.JsonConverters.ListEventTypeNameJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ListEventTypeName?))
                {
                    return new global::Vercel.JsonConverters.ListEventTypeNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ListEventTypeReplacedByItem))
                {
                    return new global::Vercel.JsonConverters.ListEventTypeReplacedByItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ListEventTypeReplacedByItem?))
                {
                    return new global::Vercel.JsonConverters.ListEventTypeReplacedByItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ListEventTypesResponseCategorieName))
                {
                    return new global::Vercel.JsonConverters.ListEventTypesResponseCategorieNameJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.ListEventTypesResponseCategorieName?))
                {
                    return new global::Vercel.JsonConverters.ListEventTypesResponseCategorieNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AuthUserActiveDashboardViewFavoritesViewPreference))
                {
                    return new global::Vercel.JsonConverters.AuthUserActiveDashboardViewFavoritesViewPreferenceJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AuthUserActiveDashboardViewFavoritesViewPreference?))
                {
                    return new global::Vercel.JsonConverters.AuthUserActiveDashboardViewFavoritesViewPreferenceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AuthUserActiveDashboardViewRecentsViewPreference))
                {
                    return new global::Vercel.JsonConverters.AuthUserActiveDashboardViewRecentsViewPreferenceJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AuthUserActiveDashboardViewRecentsViewPreference?))
                {
                    return new global::Vercel.JsonConverters.AuthUserActiveDashboardViewRecentsViewPreferenceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AuthUserActiveDashboardViewViewPreference))
                {
                    return new global::Vercel.JsonConverters.AuthUserActiveDashboardViewViewPreferenceJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AuthUserActiveDashboardViewViewPreference?))
                {
                    return new global::Vercel.JsonConverters.AuthUserActiveDashboardViewViewPreferenceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AuthUserFeatureBlocksSpeedInsightsFreeBlockReason))
                {
                    return new global::Vercel.JsonConverters.AuthUserFeatureBlocksSpeedInsightsFreeBlockReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AuthUserFeatureBlocksSpeedInsightsFreeBlockReason?))
                {
                    return new global::Vercel.JsonConverters.AuthUserFeatureBlocksSpeedInsightsFreeBlockReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AuthUserImportFlowGitProvider))
                {
                    return new global::Vercel.JsonConverters.AuthUserImportFlowGitProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AuthUserImportFlowGitProvider?))
                {
                    return new global::Vercel.JsonConverters.AuthUserImportFlowGitProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AuthUserResourceConfigBuildQueueConfiguration))
                {
                    return new global::Vercel.JsonConverters.AuthUserResourceConfigBuildQueueConfigurationJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AuthUserResourceConfigBuildQueueConfiguration?))
                {
                    return new global::Vercel.JsonConverters.AuthUserResourceConfigBuildQueueConfigurationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AuthUserSoftBlockBlockedDueToOverageType))
                {
                    return new global::Vercel.JsonConverters.AuthUserSoftBlockBlockedDueToOverageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AuthUserSoftBlockBlockedDueToOverageType?))
                {
                    return new global::Vercel.JsonConverters.AuthUserSoftBlockBlockedDueToOverageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AuthUserSoftBlockReason))
                {
                    return new global::Vercel.JsonConverters.AuthUserSoftBlockReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Vercel.AuthUserSoftBlockReason?))
                {
                    return new global::Vercel.JsonConverters.AuthUserSoftBlockReasonNullableJsonConverter();
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
                    0 => new UserSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}