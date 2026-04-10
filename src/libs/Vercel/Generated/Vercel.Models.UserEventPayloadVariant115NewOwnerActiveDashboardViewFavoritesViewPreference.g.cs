
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant115NewOwnerActiveDashboardViewFavoritesViewPreference
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
    public static class UserEventPayloadVariant115NewOwnerActiveDashboardViewFavoritesViewPreferenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant115NewOwnerActiveDashboardViewFavoritesViewPreference value)
        {
            return value switch
            {
                UserEventPayloadVariant115NewOwnerActiveDashboardViewFavoritesViewPreference.Closed => "closed",
                UserEventPayloadVariant115NewOwnerActiveDashboardViewFavoritesViewPreference.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant115NewOwnerActiveDashboardViewFavoritesViewPreference? ToEnum(string value)
        {
            return value switch
            {
                "closed" => UserEventPayloadVariant115NewOwnerActiveDashboardViewFavoritesViewPreference.Closed,
                "open" => UserEventPayloadVariant115NewOwnerActiveDashboardViewFavoritesViewPreference.Open,
                _ => null,
            };
        }
    }
}