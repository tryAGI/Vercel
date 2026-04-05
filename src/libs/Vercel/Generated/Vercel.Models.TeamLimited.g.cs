
#nullable enable

namespace Vercel
{
    /// <summary>
    /// A limited form of data representing a Team, due to the authentication token missing privileges to read the full Team data.
    /// </summary>
    public sealed partial class TeamLimited
    {
        /// <summary>
        /// Property indicating that this Team data contains only limited information, due to the authentication token missing privileges to read the full Team data or due to team having MFA enforced and the user not having MFA enabled. Re-login with the Team's configured SAML Single Sign-On provider in order to upgrade the authentication token with the necessary privileges.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limited")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Limited { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limitedBy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vercel.TeamLimitedLimitedByItem> LimitedBy { get; set; }

        /// <summary>
        /// When "Single Sign-On (SAML)" is configured, this object contains information that allows the client-side to identify whether or not this Team has SAML enforced.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("saml")]
        public global::Vercel.TeamLimitedSaml? Saml { get; set; }

        /// <summary>
        /// The Team's unique identifier.<br/>
        /// Example: team_nllPyCtREAqxxdyFKbbMDlxd
        /// </summary>
        /// <example>team_nllPyCtREAqxxdyFKbbMDlxd</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The Team's slug, which is unique across the Vercel platform.<br/>
        /// Example: my-team
        /// </summary>
        /// <example>my-team</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// Name associated with the Team account, or `null` if none has been provided.<br/>
        /// Example: My Team
        /// </summary>
        /// <example>My Team</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The ID of the file used as avatar for this Team.<br/>
        /// Example: 6eb07268bcfadd309905ffb1579354084c24655c
        /// </summary>
        /// <example>6eb07268bcfadd309905ffb1579354084c24655c</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar")]
        public string? Avatar { get; set; }

        /// <summary>
        /// The membership of the authenticated User in relation to the Team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("membership")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vercel.TeamLimitedMembership Membership { get; set; }

        /// <summary>
        /// UNIX timestamp (in milliseconds) when the Team was created.<br/>
        /// Example: 1630748523395L
        /// </summary>
        /// <example>1630748523395L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamLimited" /> class.
        /// </summary>
        /// <param name="limited">
        /// Property indicating that this Team data contains only limited information, due to the authentication token missing privileges to read the full Team data or due to team having MFA enforced and the user not having MFA enabled. Re-login with the Team's configured SAML Single Sign-On provider in order to upgrade the authentication token with the necessary privileges.
        /// </param>
        /// <param name="limitedBy"></param>
        /// <param name="id">
        /// The Team's unique identifier.<br/>
        /// Example: team_nllPyCtREAqxxdyFKbbMDlxd
        /// </param>
        /// <param name="slug">
        /// The Team's slug, which is unique across the Vercel platform.<br/>
        /// Example: my-team
        /// </param>
        /// <param name="membership">
        /// The membership of the authenticated User in relation to the Team.
        /// </param>
        /// <param name="createdAt">
        /// UNIX timestamp (in milliseconds) when the Team was created.<br/>
        /// Example: 1630748523395L
        /// </param>
        /// <param name="saml">
        /// When "Single Sign-On (SAML)" is configured, this object contains information that allows the client-side to identify whether or not this Team has SAML enforced.
        /// </param>
        /// <param name="name">
        /// Name associated with the Team account, or `null` if none has been provided.<br/>
        /// Example: My Team
        /// </param>
        /// <param name="avatar">
        /// The ID of the file used as avatar for this Team.<br/>
        /// Example: 6eb07268bcfadd309905ffb1579354084c24655c
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamLimited(
            bool limited,
            global::System.Collections.Generic.IList<global::Vercel.TeamLimitedLimitedByItem> limitedBy,
            string id,
            string slug,
            global::Vercel.TeamLimitedMembership membership,
            double createdAt,
            global::Vercel.TeamLimitedSaml? saml,
            string? name,
            string? avatar)
        {
            this.Limited = limited;
            this.LimitedBy = limitedBy ?? throw new global::System.ArgumentNullException(nameof(limitedBy));
            this.Saml = saml;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Name = name;
            this.Avatar = avatar;
            this.Membership = membership ?? throw new global::System.ArgumentNullException(nameof(membership));
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamLimited" /> class.
        /// </summary>
        public TeamLimited()
        {
        }
    }
}