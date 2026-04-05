
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum AuthTokenScopeVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Team,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuthTokenScopeVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthTokenScopeVariant2Type value)
        {
            return value switch
            {
                AuthTokenScopeVariant2Type.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthTokenScopeVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "team" => AuthTokenScopeVariant2Type.Team,
                _ => null,
            };
        }
    }
}