
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant114NewOwnerActiveDashboardView
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant114NewOwnerActiveDashboardViewViewPreferenceJsonConverter))]
        public global::Vercel.UserEventPayloadVariant114NewOwnerActiveDashboardViewViewPreference? ViewPreference { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("favoritesViewPreference")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant114NewOwnerActiveDashboardViewFavoritesViewPreferenceJsonConverter))]
        public global::Vercel.UserEventPayloadVariant114NewOwnerActiveDashboardViewFavoritesViewPreference? FavoritesViewPreference { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recentsViewPreference")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant114NewOwnerActiveDashboardViewRecentsViewPreferenceJsonConverter))]
        public global::Vercel.UserEventPayloadVariant114NewOwnerActiveDashboardViewRecentsViewPreference? RecentsViewPreference { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant114NewOwnerActiveDashboardView" /> class.
        /// </summary>
        /// <param name="scopeId"></param>
        /// <param name="viewPreference"></param>
        /// <param name="favoritesViewPreference"></param>
        /// <param name="recentsViewPreference"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant114NewOwnerActiveDashboardView(
            string scopeId,
            global::Vercel.UserEventPayloadVariant114NewOwnerActiveDashboardViewViewPreference? viewPreference,
            global::Vercel.UserEventPayloadVariant114NewOwnerActiveDashboardViewFavoritesViewPreference? favoritesViewPreference,
            global::Vercel.UserEventPayloadVariant114NewOwnerActiveDashboardViewRecentsViewPreference? recentsViewPreference)
        {
            this.ScopeId = scopeId ?? throw new global::System.ArgumentNullException(nameof(scopeId));
            this.ViewPreference = viewPreference;
            this.FavoritesViewPreference = favoritesViewPreference;
            this.RecentsViewPreference = recentsViewPreference;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant114NewOwnerActiveDashboardView" /> class.
        /// </summary>
        public UserEventPayloadVariant114NewOwnerActiveDashboardView()
        {
        }
    }
}