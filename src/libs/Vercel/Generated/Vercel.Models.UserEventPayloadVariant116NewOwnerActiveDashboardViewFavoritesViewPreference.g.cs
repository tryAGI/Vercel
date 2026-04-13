
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant116NewOwnerActiveDashboardViewFavoritesViewPreference
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
    public static class UserEventPayloadVariant116NewOwnerActiveDashboardViewFavoritesViewPreferenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant116NewOwnerActiveDashboardViewFavoritesViewPreference value)
        {
            return value switch
            {
                UserEventPayloadVariant116NewOwnerActiveDashboardViewFavoritesViewPreference.Closed => "closed",
                UserEventPayloadVariant116NewOwnerActiveDashboardViewFavoritesViewPreference.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant116NewOwnerActiveDashboardViewFavoritesViewPreference? ToEnum(string value)
        {
            return value switch
            {
                "closed" => UserEventPayloadVariant116NewOwnerActiveDashboardViewFavoritesViewPreference.Closed,
                "open" => UserEventPayloadVariant116NewOwnerActiveDashboardViewFavoritesViewPreference.Open,
                _ => null,
            };
        }
    }
}