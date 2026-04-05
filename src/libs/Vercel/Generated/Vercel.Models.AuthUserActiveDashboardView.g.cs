
#nullable enable

namespace Vercel
{
    /// <summary>
    /// set of dashboard view preferences (cards or list) per scopeId
    /// </summary>
    public sealed partial class AuthUserActiveDashboardView
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopeId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ScopeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("viewPreference")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AuthUserActiveDashboardViewViewPreferenceJsonConverter))]
        public global::Vercel.AuthUserActiveDashboardViewViewPreference? ViewPreference { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("favoritesViewPreference")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AuthUserActiveDashboardViewFavoritesViewPreferenceJsonConverter))]
        public global::Vercel.AuthUserActiveDashboardViewFavoritesViewPreference? FavoritesViewPreference { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recentsViewPreference")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.AuthUserActiveDashboardViewRecentsViewPreferenceJsonConverter))]
        public global::Vercel.AuthUserActiveDashboardViewRecentsViewPreference? RecentsViewPreference { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthUserActiveDashboardView" /> class.
        /// </summary>
        /// <param name="scopeId"></param>
        /// <param name="viewPreference"></param>
        /// <param name="favoritesViewPreference"></param>
        /// <param name="recentsViewPreference"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthUserActiveDashboardView(
            string scopeId,
            global::Vercel.AuthUserActiveDashboardViewViewPreference? viewPreference,
            global::Vercel.AuthUserActiveDashboardViewFavoritesViewPreference? favoritesViewPreference,
            global::Vercel.AuthUserActiveDashboardViewRecentsViewPreference? recentsViewPreference)
        {
            this.ScopeId = scopeId ?? throw new global::System.ArgumentNullException(nameof(scopeId));
            this.ViewPreference = viewPreference;
            this.FavoritesViewPreference = favoritesViewPreference;
            this.RecentsViewPreference = recentsViewPreference;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthUserActiveDashboardView" /> class.
        /// </summary>
        public AuthUserActiveDashboardView()
        {
        }
    }
}