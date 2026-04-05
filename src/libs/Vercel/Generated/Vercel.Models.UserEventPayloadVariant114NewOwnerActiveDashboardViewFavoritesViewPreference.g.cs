
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant114NewOwnerActiveDashboardViewFavoritesViewPreference
    {
        /// <summary>
        /// 
        /// </summary>
        Closed,
        /// <summary>
        /// 
        /// </summary>
        Open,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant114NewOwnerActiveDashboardViewFavoritesViewPreferenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant114NewOwnerActiveDashboardViewFavoritesViewPreference value)
        {
            return value switch
            {
                UserEventPayloadVariant114NewOwnerActiveDashboardViewFavoritesViewPreference.Closed => "closed",
                UserEventPayloadVariant114NewOwnerActiveDashboardViewFavoritesViewPreference.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant114NewOwnerActiveDashboardViewFavoritesViewPreference? ToEnum(string value)
        {
            return value switch
            {
                "closed" => UserEventPayloadVariant114NewOwnerActiveDashboardViewFavoritesViewPreference.Closed,
                "open" => UserEventPayloadVariant114NewOwnerActiveDashboardViewFavoritesViewPreference.Open,
                _ => null,
            };
        }
    }
}