
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedc396e89a7a8d84fbSourceVariant1Kind
    {
        /// <summary>
        ///
        /// </summary>
        SelfServed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedc396e89a7a8d84fbSourceVariant1KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedc396e89a7a8d84fbSourceVariant1Kind value)
        {
            return value switch
            {
                AutoSDKSharedc396e89a7a8d84fbSourceVariant1Kind.SelfServed => "self-served",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedc396e89a7a8d84fbSourceVariant1Kind? ToEnum(string value)
        {
            return value switch
            {
                "self-served" => AutoSDKSharedc396e89a7a8d84fbSourceVariant1Kind.SelfServed,
                _ => null,
            };
        }
    }
}