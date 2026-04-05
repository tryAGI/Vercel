
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum AuthUserActiveDashboardViewFavoritesViewPreference
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
    public static class AuthUserActiveDashboardViewFavoritesViewPreferenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthUserActiveDashboardViewFavoritesViewPreference value)
        {
            return value switch
            {
                AuthUserActiveDashboardViewFavoritesViewPreference.Closed => "closed",
                AuthUserActiveDashboardViewFavoritesViewPreference.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthUserActiveDashboardViewFavoritesViewPreference? ToEnum(string value)
        {
            return value switch
            {
                "closed" => AuthUserActiveDashboardViewFavoritesViewPreference.Closed,
                "open" => AuthUserActiveDashboardViewFavoritesViewPreference.Open,
                _ => null,
            };
        }
    }
}