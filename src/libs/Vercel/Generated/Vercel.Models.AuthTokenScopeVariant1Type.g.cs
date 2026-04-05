
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum AuthTokenScopeVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuthTokenScopeVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthTokenScopeVariant1Type value)
        {
            return value switch
            {
                AuthTokenScopeVariant1Type.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthTokenScopeVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "user" => AuthTokenScopeVariant1Type.User,
                _ => null,
            };
        }
    }
}