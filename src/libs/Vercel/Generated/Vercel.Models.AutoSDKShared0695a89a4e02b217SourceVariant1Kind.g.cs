
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0695a89a4e02b217SourceVariant1Kind
    {
        /// <summary>
        ///
        /// </summary>
        SelfServed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared0695a89a4e02b217SourceVariant1KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0695a89a4e02b217SourceVariant1Kind value)
        {
            return value switch
            {
                AutoSDKShared0695a89a4e02b217SourceVariant1Kind.SelfServed => "self-served",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0695a89a4e02b217SourceVariant1Kind? ToEnum(string value)
        {
            return value switch
            {
                "self-served" => AutoSDKShared0695a89a4e02b217SourceVariant1Kind.SelfServed,
                _ => null,
            };
        }
    }
}