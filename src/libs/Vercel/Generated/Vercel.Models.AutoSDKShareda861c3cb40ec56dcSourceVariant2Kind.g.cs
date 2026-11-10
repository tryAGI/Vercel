
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda861c3cb40ec56dcSourceVariant2Kind
    {
        /// <summary>
        ///
        /// </summary>
        Integration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShareda861c3cb40ec56dcSourceVariant2KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda861c3cb40ec56dcSourceVariant2Kind value)
        {
            return value switch
            {
                AutoSDKShareda861c3cb40ec56dcSourceVariant2Kind.Integration => "integration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda861c3cb40ec56dcSourceVariant2Kind? ToEnum(string value)
        {
            return value switch
            {
                "integration" => AutoSDKShareda861c3cb40ec56dcSourceVariant2Kind.Integration,
                _ => null,
            };
        }
    }
}