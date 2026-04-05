
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum AuthUserActiveDashboardViewRecentsViewPreference
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
    public static class AuthUserActiveDashboardViewRecentsViewPreferenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthUserActiveDashboardViewRecentsViewPreference value)
        {
            return value switch
            {
                AuthUserActiveDashboardViewRecentsViewPreference.Closed => "closed",
                AuthUserActiveDashboardViewRecentsViewPreference.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthUserActiveDashboardViewRecentsViewPreference? ToEnum(string value)
        {
            return value switch
            {
                "closed" => AuthUserActiveDashboardViewRecentsViewPreference.Closed,
                "open" => AuthUserActiveDashboardViewRecentsViewPreference.Open,
                _ => null,
            };
        }
    }
}