
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared9c06dfe8dd59ad6dSourceVariant1Kind
    {
        /// <summary>
        ///
        /// </summary>
        SelfServed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared9c06dfe8dd59ad6dSourceVariant1KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared9c06dfe8dd59ad6dSourceVariant1Kind value)
        {
            return value switch
            {
                AutoSDKShared9c06dfe8dd59ad6dSourceVariant1Kind.SelfServed => "self-served",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared9c06dfe8dd59ad6dSourceVariant1Kind? ToEnum(string value)
        {
            return value switch
            {
                "self-served" => AutoSDKShared9c06dfe8dd59ad6dSourceVariant1Kind.SelfServed,
                _ => null,
            };
        }
    }
}