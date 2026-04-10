
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserEventPayloadVariant115NewOwnerActiveDashboardView
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant115NewOwnerActiveDashboardViewViewPreferenceJsonConverter))]
        public global::Vercel.UserEventPayloadVariant115NewOwnerActiveDashboardViewViewPreference? ViewPreference { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("favoritesViewPreference")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant115NewOwnerActiveDashboardViewFavoritesViewPreferenceJsonConverter))]
        public global::Vercel.UserEventPayloadVariant115NewOwnerActiveDashboardViewFavoritesViewPreference? FavoritesViewPreference { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recentsViewPreference")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vercel.JsonConverters.UserEventPayloadVariant115NewOwnerActiveDashboardViewRecentsViewPreferenceJsonConverter))]
        public global::Vercel.UserEventPayloadVariant115NewOwnerActiveDashboardViewRecentsViewPreference? RecentsViewPreference { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant115NewOwnerActiveDashboardView" /> class.
        /// </summary>
        /// <param name="scopeId"></param>
        /// <param name="viewPreference"></param>
        /// <param name="favoritesViewPreference"></param>
        /// <param name="recentsViewPreference"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEventPayloadVariant115NewOwnerActiveDashboardView(
            string scopeId,
            global::Vercel.UserEventPayloadVariant115NewOwnerActiveDashboardViewViewPreference? viewPreference,
            global::Vercel.UserEventPayloadVariant115NewOwnerActiveDashboardViewFavoritesViewPreference? favoritesViewPreference,
            global::Vercel.UserEventPayloadVariant115NewOwnerActiveDashboardViewRecentsViewPreference? recentsViewPreference)
        {
            this.ScopeId = scopeId ?? throw new global::System.ArgumentNullException(nameof(scopeId));
            this.ViewPreference = viewPreference;
            this.FavoritesViewPreference = favoritesViewPreference;
            this.RecentsViewPreference = recentsViewPreference;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEventPayloadVariant115NewOwnerActiveDashboardView" /> class.
        /// </summary>
        public UserEventPayloadVariant115NewOwnerActiveDashboardView()
        {
        }
    }
}