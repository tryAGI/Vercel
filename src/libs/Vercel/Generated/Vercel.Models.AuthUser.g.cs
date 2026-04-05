
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Data for the currently authenticated User.
    /// </summary>
    public sealed partial class AuthUser
    {
        /// <summary>
        /// UNIX timestamp (in milliseconds) when the User account was created.<br/>
        /// Example: 1630748523395L
        /// </summary>
        /// <example>1630748523395L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// When the User account has been "soft blocked", this property will contain the date when the restriction was enacted, and the identifier for why.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("softBlock")]
        public global::Vercel.AuthUserSoftBlock? SoftBlock { get; set; }

        /// <summary>
        /// An object containing billing infomation associated with the User account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billing")]
        public object? Billing { get; set; }

        /// <summary>
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceConfig")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.AuthUserResourceConfig ResourceConfig { get; set; }

        /// <summary>
        /// Prefix that will be used in the URL of "Preview" deployments created by the User account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stagingPrefix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StagingPrefix { get; set; }

        /// <summary>
        /// set of dashboard view preferences (cards or list) per scopeId
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activeDashboardViews")]
        public global::System.Collections.Generic.IList<global::Vercel.AuthUserActiveDashboardView>? ActiveDashboardViews { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("importFlowGitNamespace")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>))]
        public global::Vercel.OneOf<string, double?>? ImportFlowGitNamespace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("importFlowGitNamespaceId")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<string, double?>))]
        public global::Vercel.OneOf<string, double?>? ImportFlowGitNamespaceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("importFlowGitProvider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AuthUserImportFlowGitProviderJsonConverter))]
        public global::Vercel.AuthUserImportFlowGitProvider? ImportFlowGitProvider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preferredScopesAndGitNamespaces")]
        public global::System.Collections.Generic.IList<global::Vercel.AuthUserPreferredScopesAndGitNamespace>? PreferredScopesAndGitNamespaces { get; set; }

        /// <summary>
        /// A record of when, under a certain scopeId, a toast was dismissed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismissedToasts")]
        public global::System.Collections.Generic.IList<global::Vercel.AuthUserDismissedToast>? DismissedToasts { get; set; }

        /// <summary>
        /// A list of projects and spaces across teams that a user has marked as a favorite.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("favoriteProjectsAndSpaces")]
        public global::System.Collections.Generic.IList<global::Vercel.AuthUserFavoriteProjectsAndSpace>? FavoriteProjectsAndSpaces { get; set; }

        /// <summary>
        /// Whether the user has a trial available for a paid plan subscription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasTrialAvailable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasTrialAvailable { get; set; }

        /// <summary>
        /// remote caching settings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remoteCaching")]
        public global::Vercel.AuthUserRemoteCaching? RemoteCaching { get; set; }

        /// <summary>
        /// data cache settings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataCache")]
        public global::Vercel.AuthUserDataCache? DataCache { get; set; }

        /// <summary>
        /// Feature blocks for the user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("featureBlocks")]
        public global::Vercel.AuthUserFeatureBlocks? FeatureBlocks { get; set; }

        /// <summary>
        /// The User's unique identifier.<br/>
        /// Example: AEIIDYVk59zbFF2Sxfyxxmua
        /// </summary>
        /// <example>AEIIDYVk59zbFF2Sxfyxxmua</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Email address associated with the User account.<br/>
        /// Example: me@example.com
        /// </summary>
        /// <example>me@example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// Name associated with the User account, or `null` if none has been provided.<br/>
        /// Example: John Doe
        /// </summary>
        /// <example>John Doe</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Unique username associated with the User account.<br/>
        /// Example: jdoe
        /// </summary>
        /// <example>jdoe</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Username { get; set; }

        /// <summary>
        /// SHA1 hash of the avatar for the User account. Can be used in conjuction with the ... endpoint to retrieve the avatar image.<br/>
        /// Example: 22cb30c85ff45ac4c72de8981500006b28114aa1
        /// </summary>
        /// <example>22cb30c85ff45ac4c72de8981500006b28114aa1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar")]
        public string? Avatar { get; set; }

        /// <summary>
        /// The user's default team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultTeamId")]
        public string? DefaultTeamId { get; set; }

        /// <summary>
        /// Indicates whether the user is managed by an enterprise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isEnterpriseManaged")]
        public bool? IsEnterpriseManaged { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthUser" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// UNIX timestamp (in milliseconds) when the User account was created.<br/>
        /// Example: 1630748523395L
        /// </param>
        /// <param name="resourceConfig">
        /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
        /// </param>
        /// <param name="stagingPrefix">
        /// Prefix that will be used in the URL of "Preview" deployments created by the User account.
        /// </param>
        /// <param name="hasTrialAvailable">
        /// Whether the user has a trial available for a paid plan subscription.
        /// </param>
        /// <param name="id">
        /// The User's unique identifier.<br/>
        /// Example: AEIIDYVk59zbFF2Sxfyxxmua
        /// </param>
        /// <param name="email">
        /// Email address associated with the User account.<br/>
        /// Example: me@example.com
        /// </param>
        /// <param name="username">
        /// Unique username associated with the User account.<br/>
        /// Example: jdoe
        /// </param>
        /// <param name="softBlock">
        /// When the User account has been "soft blocked", this property will contain the date when the restriction was enacted, and the identifier for why.
        /// </param>
        /// <param name="billing">
        /// An object containing billing infomation associated with the User account.
        /// </param>
        /// <param name="activeDashboardViews">
        /// set of dashboard view preferences (cards or list) per scopeId
        /// </param>
        /// <param name="importFlowGitNamespace"></param>
        /// <param name="importFlowGitNamespaceId"></param>
        /// <param name="importFlowGitProvider"></param>
        /// <param name="preferredScopesAndGitNamespaces"></param>
        /// <param name="dismissedToasts">
        /// A record of when, under a certain scopeId, a toast was dismissed
        /// </param>
        /// <param name="favoriteProjectsAndSpaces">
        /// A list of projects and spaces across teams that a user has marked as a favorite.
        /// </param>
        /// <param name="remoteCaching">
        /// remote caching settings
        /// </param>
        /// <param name="dataCache">
        /// data cache settings
        /// </param>
        /// <param name="featureBlocks">
        /// Feature blocks for the user
        /// </param>
        /// <param name="name">
        /// Name associated with the User account, or `null` if none has been provided.<br/>
        /// Example: John Doe
        /// </param>
        /// <param name="avatar">
        /// SHA1 hash of the avatar for the User account. Can be used in conjuction with the ... endpoint to retrieve the avatar image.<br/>
        /// Example: 22cb30c85ff45ac4c72de8981500006b28114aa1
        /// </param>
        /// <param name="defaultTeamId">
        /// The user's default team.
        /// </param>
        /// <param name="isEnterpriseManaged">
        /// Indicates whether the user is managed by an enterprise.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthUser(
            double createdAt,
            global::Vercel.AuthUserResourceConfig resourceConfig,
            string stagingPrefix,
            bool hasTrialAvailable,
            string id,
            string email,
            string username,
            global::Vercel.AuthUserSoftBlock? softBlock,
            object? billing,
            global::System.Collections.Generic.IList<global::Vercel.AuthUserActiveDashboardView>? activeDashboardViews,
            global::Vercel.OneOf<string, double?>? importFlowGitNamespace,
            global::Vercel.OneOf<string, double?>? importFlowGitNamespaceId,
            global::Vercel.AuthUserImportFlowGitProvider? importFlowGitProvider,
            global::System.Collections.Generic.IList<global::Vercel.AuthUserPreferredScopesAndGitNamespace>? preferredScopesAndGitNamespaces,
            global::System.Collections.Generic.IList<global::Vercel.AuthUserDismissedToast>? dismissedToasts,
            global::System.Collections.Generic.IList<global::Vercel.AuthUserFavoriteProjectsAndSpace>? favoriteProjectsAndSpaces,
            global::Vercel.AuthUserRemoteCaching? remoteCaching,
            global::Vercel.AuthUserDataCache? dataCache,
            global::Vercel.AuthUserFeatureBlocks? featureBlocks,
            string? name,
            string? avatar,
            string? defaultTeamId,
            bool? isEnterpriseManaged)
        {
            this.CreatedAt = createdAt;
            this.SoftBlock = softBlock;
            this.Billing = billing;
            this.ResourceConfig = resourceConfig ?? throw new global::System.ArgumentNullException(nameof(resourceConfig));
            this.StagingPrefix = stagingPrefix ?? throw new global::System.ArgumentNullException(nameof(stagingPrefix));
            this.ActiveDashboardViews = activeDashboardViews;
            this.ImportFlowGitNamespace = importFlowGitNamespace;
            this.ImportFlowGitNamespaceId = importFlowGitNamespaceId;
            this.ImportFlowGitProvider = importFlowGitProvider;
            this.PreferredScopesAndGitNamespaces = preferredScopesAndGitNamespaces;
            this.DismissedToasts = dismissedToasts;
            this.FavoriteProjectsAndSpaces = favoriteProjectsAndSpaces;
            this.HasTrialAvailable = hasTrialAvailable;
            this.RemoteCaching = remoteCaching;
            this.DataCache = dataCache;
            this.FeatureBlocks = featureBlocks;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Name = name;
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.Avatar = avatar;
            this.DefaultTeamId = defaultTeamId;
            this.IsEnterpriseManaged = isEnterpriseManaged;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthUser" /> class.
        /// </summary>
        public AuthUser()
        {
        }
    }
}