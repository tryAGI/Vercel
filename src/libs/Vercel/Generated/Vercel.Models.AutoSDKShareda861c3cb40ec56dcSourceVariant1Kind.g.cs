
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda861c3cb40ec56dcSourceVariant1Kind
    {
        /// <summary>
        ///
        /// </summary>
        SelfServed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShareda861c3cb40ec56dcSourceVariant1KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda861c3cb40ec56dcSourceVariant1Kind value)
        {
            return value switch
            {
                AutoSDKShareda861c3cb40ec56dcSourceVariant1Kind.SelfServed => "self-served",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda861c3cb40ec56dcSourceVariant1Kind? ToEnum(string value)
        {
            return value switch
            {
                "self-served" => AutoSDKShareda861c3cb40ec56dcSourceVariant1Kind.SelfServed,
                _ => null,
            };
        }
    }
}