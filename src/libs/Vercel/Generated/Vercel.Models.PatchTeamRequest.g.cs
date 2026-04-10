
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchTeamRequest
    {
        /// <summary>
        /// The hash value of an uploaded image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar")]
        public string? Avatar { get; set; }

        /// <summary>
        /// A short text that describes the team.<br/>
        /// Example: Our mission is to make cloud computing accessible to everyone
        /// </summary>
        /// <example>Our mission is to make cloud computing accessible to everyone</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Example: example.com
        /// </summary>
        /// <example>example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("emailDomain")]
        public string? EmailDomain { get; set; }

        /// <summary>
        /// The name of the team.<br/>
        /// Example: My Team
        /// </summary>
        /// <example>My Team</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Suffix that will be used for all preview deployments.<br/>
        /// Example: example.dev
        /// </summary>
        /// <example>example.dev</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("previewDeploymentSuffix")]
        public string? PreviewDeploymentSuffix { get; set; }

        /// <summary>
        /// Create a new invite code and replace the current one.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("regenerateInviteCode")]
        public bool? RegenerateInviteCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("saml")]
        public global::Vercel.PatchTeamRequestSaml? Saml { get; set; }

        /// <summary>
        /// A new slug for the team.<br/>
        /// Example: my-team
        /// </summary>
        /// <example>my-team</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// Enable preview toolbar: one of on, off or default.<br/>
        /// Example: on
        /// </summary>
        /// <example>on</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enablePreviewFeedback")]
        public string? EnablePreviewFeedback { get; set; }

        /// <summary>
        /// Enable production toolbar: one of on, off or default.<br/>
        /// Example: on
        /// </summary>
        /// <example>on</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enableProductionFeedback")]
        public string? EnableProductionFeedback { get; set; }

        /// <summary>
        /// Sensitive environment variable policy: one of on, off or default.<br/>
        /// Example: on
        /// </summary>
        /// <example>on</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sensitiveEnvironmentVariablePolicy")]
        public string? SensitiveEnvironmentVariablePolicy { get; set; }

        /// <summary>
        /// Whether or not remote caching is enabled for the team
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remoteCaching")]
        public global::Vercel.PatchTeamRequestRemoteCaching? RemoteCaching { get; set; }

        /// <summary>
        /// Display or hide IP addresses in Monitoring queries.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("hideIpAddresses")]
        public bool? HideIpAddresses { get; set; }

        /// <summary>
        /// Display or hide IP addresses in Log Drains.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("hideIpAddressesInLogDrains")]
        public bool? HideIpAddressesInLogDrains { get; set; }

        /// <summary>
        /// Default deployment protection settings for new projects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultDeploymentProtection")]
        public global::Vercel.PatchTeamRequestDefaultDeploymentProtection? DefaultDeploymentProtection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultExpirationSettings")]
        public global::Vercel.PatchTeamRequestDefaultExpirationSettings? DefaultExpirationSettings { get; set; }

        /// <summary>
        /// When enabled, deployment protection settings require stricter permissions (owner-only).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strictDeploymentProtectionSettings")]
        public global::Vercel.PatchTeamRequestStrictDeploymentProtectionSettings? StrictDeploymentProtectionSettings { get; set; }

        /// <summary>
        /// When enabled, creating shareable links requires Owner role.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strictShareableLinks")]
        public global::Vercel.PatchTeamRequestStrictShareableLinks? StrictShareableLinks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nsnbConfig")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AnyOfJsonConverter<global::Vercel.PatchTeamRequestNsnbConfig, string>))]
        public global::Vercel.AnyOf<global::Vercel.PatchTeamRequestNsnbConfig, string>? NsnbConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultProjectJobs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.OneOfJsonConverter<global::Vercel.PatchTeamRequestDefaultProjectJobs, string>))]
        public global::Vercel.OneOf<global::Vercel.PatchTeamRequestDefaultProjectJobs, string>? DefaultProjectJobs { get; set; }

        /// <summary>
        /// Resource configuration for the team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceConfig")]
        public global::Vercel.PatchTeamRequestResourceConfig? ResourceConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchTeamRequest" /> class.
        /// </summary>
        /// <param name="avatar">
        /// The hash value of an uploaded image.
        /// </param>
        /// <param name="description">
        /// A short text that describes the team.<br/>
        /// Example: Our mission is to make cloud computing accessible to everyone
        /// </param>
        /// <param name="emailDomain">
        /// Example: example.com
        /// </param>
        /// <param name="name">
        /// The name of the team.<br/>
        /// Example: My Team
        /// </param>
        /// <param name="previewDeploymentSuffix">
        /// Suffix that will be used for all preview deployments.<br/>
        /// Example: example.dev
        /// </param>
        /// <param name="regenerateInviteCode">
        /// Create a new invite code and replace the current one.<br/>
        /// Example: true
        /// </param>
        /// <param name="saml"></param>
        /// <param name="slug">
        /// A new slug for the team.<br/>
        /// Example: my-team
        /// </param>
        /// <param name="enablePreviewFeedback">
        /// Enable preview toolbar: one of on, off or default.<br/>
        /// Example: on
        /// </param>
        /// <param name="enableProductionFeedback">
        /// Enable production toolbar: one of on, off or default.<br/>
        /// Example: on
        /// </param>
        /// <param name="sensitiveEnvironmentVariablePolicy">
        /// Sensitive environment variable policy: one of on, off or default.<br/>
        /// Example: on
        /// </param>
        /// <param name="remoteCaching">
        /// Whether or not remote caching is enabled for the team
        /// </param>
        /// <param name="hideIpAddresses">
        /// Display or hide IP addresses in Monitoring queries.<br/>
        /// Example: false
        /// </param>
        /// <param name="hideIpAddressesInLogDrains">
        /// Display or hide IP addresses in Log Drains.<br/>
        /// Example: false
        /// </param>
        /// <param name="defaultDeploymentProtection">
        /// Default deployment protection settings for new projects.
        /// </param>
        /// <param name="defaultExpirationSettings"></param>
        /// <param name="strictDeploymentProtectionSettings">
        /// When enabled, deployment protection settings require stricter permissions (owner-only).
        /// </param>
        /// <param name="strictShareableLinks">
        /// When enabled, creating shareable links requires Owner role.
        /// </param>
        /// <param name="nsnbConfig"></param>
        /// <param name="defaultProjectJobs"></param>
        /// <param name="resourceConfig">
        /// Resource configuration for the team.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchTeamRequest(
            string? avatar,
            string? description,
            string? emailDomain,
            string? name,
            string? previewDeploymentSuffix,
            bool? regenerateInviteCode,
            global::Vercel.PatchTeamRequestSaml? saml,
            string? slug,
            string? enablePreviewFeedback,
            string? enableProductionFeedback,
            string? sensitiveEnvironmentVariablePolicy,
            global::Vercel.PatchTeamRequestRemoteCaching? remoteCaching,
            bool? hideIpAddresses,
            bool? hideIpAddressesInLogDrains,
            global::Vercel.PatchTeamRequestDefaultDeploymentProtection? defaultDeploymentProtection,
            global::Vercel.PatchTeamRequestDefaultExpirationSettings? defaultExpirationSettings,
            global::Vercel.PatchTeamRequestStrictDeploymentProtectionSettings? strictDeploymentProtectionSettings,
            global::Vercel.PatchTeamRequestStrictShareableLinks? strictShareableLinks,
            global::Vercel.AnyOf<global::Vercel.PatchTeamRequestNsnbConfig, string>? nsnbConfig,
            global::Vercel.OneOf<global::Vercel.PatchTeamRequestDefaultProjectJobs, string>? defaultProjectJobs,
            global::Vercel.PatchTeamRequestResourceConfig? resourceConfig)
        {
            this.Avatar = avatar;
            this.Description = description;
            this.EmailDomain = emailDomain;
            this.Name = name;
            this.PreviewDeploymentSuffix = previewDeploymentSuffix;
            this.RegenerateInviteCode = regenerateInviteCode;
            this.Saml = saml;
            this.Slug = slug;
            this.EnablePreviewFeedback = enablePreviewFeedback;
            this.EnableProductionFeedback = enableProductionFeedback;
            this.SensitiveEnvironmentVariablePolicy = sensitiveEnvironmentVariablePolicy;
            this.RemoteCaching = remoteCaching;
            this.HideIpAddresses = hideIpAddresses;
            this.HideIpAddressesInLogDrains = hideIpAddressesInLogDrains;
            this.DefaultDeploymentProtection = defaultDeploymentProtection;
            this.DefaultExpirationSettings = defaultExpirationSettings;
            this.StrictDeploymentProtectionSettings = strictDeploymentProtectionSettings;
            this.StrictShareableLinks = strictShareableLinks;
            this.NsnbConfig = nsnbConfig;
            this.DefaultProjectJobs = defaultProjectJobs;
            this.ResourceConfig = resourceConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchTeamRequest" /> class.
        /// </summary>
        public PatchTeamRequest()
        {
        }
    }
}