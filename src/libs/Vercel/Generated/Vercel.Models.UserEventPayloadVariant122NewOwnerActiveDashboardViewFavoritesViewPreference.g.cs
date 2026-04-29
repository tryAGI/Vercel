
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant122NewOwnerActiveDashboardViewFavoritesViewPreference
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
    public static class UserEventPayloadVariant122NewOwnerActiveDashboardViewFavoritesViewPreferenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant122NewOwnerActiveDashboardViewFavoritesViewPreference value)
        {
            return value switch
            {
                UserEventPayloadVariant122NewOwnerActiveDashboardViewFavoritesViewPreference.Closed => "closed",
                UserEventPayloadVariant122NewOwnerActiveDashboardViewFavoritesViewPreference.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant122NewOwnerActiveDashboardViewFavoritesViewPreference? ToEnum(string value)
        {
            return value switch
            {
                "closed" => UserEventPayloadVariant122NewOwnerActiveDashboardViewFavoritesViewPreference.Closed,
                "open" => UserEventPayloadVariant122NewOwnerActiveDashboardViewFavoritesViewPreference.Open,
                _ => null,
            };
        }
    }
}