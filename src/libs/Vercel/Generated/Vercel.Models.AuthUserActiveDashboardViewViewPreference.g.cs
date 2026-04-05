
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum AuthUserActiveDashboardViewViewPreference
    {
        /// <summary>
        /// 
        /// </summary>
        Cards,
        /// <summary>
        /// 
        /// </summary>
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuthUserActiveDashboardViewViewPreferenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthUserActiveDashboardViewViewPreference value)
        {
            return value switch
            {
                AuthUserActiveDashboardViewViewPreference.Cards => "cards",
                AuthUserActiveDashboardViewViewPreference.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthUserActiveDashboardViewViewPreference? ToEnum(string value)
        {
            return value switch
            {
                "cards" => AuthUserActiveDashboardViewViewPreference.Cards,
                "list" => AuthUserActiveDashboardViewViewPreference.List,
                _ => null,
            };
        }
    }
}