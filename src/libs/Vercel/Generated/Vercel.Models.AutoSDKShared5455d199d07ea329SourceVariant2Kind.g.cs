
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared5455d199d07ea329SourceVariant2Kind
    {
        /// <summary>
        ///
        /// </summary>
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared5455d199d07ea329SourceVariant2KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared5455d199d07ea329SourceVariant2Kind value)
        {
            return value switch
            {
                AutoSDKShared5455d199d07ea329SourceVariant2Kind.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared5455d199d07ea329SourceVariant2Kind? ToEnum(string value)
        {
            return value switch
            {
                "webhook" => AutoSDKShared5455d199d07ea329SourceVariant2Kind.Webhook,
                _ => null,
            };
        }
    }
}