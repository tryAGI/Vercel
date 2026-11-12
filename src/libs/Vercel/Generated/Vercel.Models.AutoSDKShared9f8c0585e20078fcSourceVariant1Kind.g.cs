
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared9f8c0585e20078fcSourceVariant1Kind
    {
        /// <summary>
        ///
        /// </summary>
        SelfServed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared9f8c0585e20078fcSourceVariant1KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared9f8c0585e20078fcSourceVariant1Kind value)
        {
            return value switch
            {
                AutoSDKShared9f8c0585e20078fcSourceVariant1Kind.SelfServed => "self-served",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared9f8c0585e20078fcSourceVariant1Kind? ToEnum(string value)
        {
            return value switch
            {
                "self-served" => AutoSDKShared9f8c0585e20078fcSourceVariant1Kind.SelfServed,
                _ => null,
            };
        }
    }
}