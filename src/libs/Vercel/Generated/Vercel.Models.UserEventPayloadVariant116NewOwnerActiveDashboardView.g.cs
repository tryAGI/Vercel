
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant116NewOwnerActiveDashboardView
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant116NewOwnerActiveDashboardViewViewPreferenceJsonConverter))]
        public global::Vercel.UserEventPayloadVariant116NewOwnerActiveDashboardViewViewPreference? ViewPreference { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("favoritesViewPreference")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant116NewOwnerActiveDashboardViewFavoritesViewPreferenceJsonConverter))]
        public global::Vercel.UserEventPayloadVariant116NewOwnerActiveDashboardViewFavoritesViewPreference? FavoritesViewPreference { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recentsViewPreference")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant116NewOwnerActiveDashboardViewRecentsViewPreferenceJsonConverter))]
        public global::Vercel.UserEventPayloadVariant116NewOwnerActiveDashboardViewRecentsViewPreference? RecentsViewPreference { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant116NewOwnerActiveDashboardView" /> class.
        /// </summary>
        /// <param name="scopeId"></param>
        /// <param name="viewPreference"></param>
        /// <param name="favoritesViewPreference"></param>
        /// <param name="recentsViewPreference"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant116NewOwnerActiveDashboardView(
            string scopeId,
            global::Vercel.UserEventPayloadVariant116NewOwnerActiveDashboardViewViewPreference? viewPreference,
            global::Vercel.UserEventPayloadVariant116NewOwnerActiveDashboardViewFavoritesViewPreference? favoritesViewPreference,
            global::Vercel.UserEventPayloadVariant116NewOwnerActiveDashboardViewRecentsViewPreference? recentsViewPreference)
        {
            this.ScopeId = scopeId ?? throw new global::System.ArgumentNullException(nameof(scopeId));
            this.ViewPreference = viewPreference;
            this.FavoritesViewPreference = favoritesViewPreference;
            this.RecentsViewPreference = recentsViewPreference;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant116NewOwnerActiveDashboardView" /> class.
        /// </summary>
        public UserEventPayloadVariant116NewOwnerActiveDashboardView()
        {
        }
    }
}