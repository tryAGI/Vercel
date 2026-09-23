
#nullable enable

namespace Vercel
{
    /// <summary>
    /// environments this env variable targets<br/>
    /// Example: production
    /// </summary>
    public enum AutoSDKShared2e531c6dd7d2b280TargetItem
    {
        /// <summary>
        ///
        /// </summary>
        Development,
        /// <summary>
        ///
        /// </summary>
        Preview,
        /// <summary>
        ///
        /// </summary>
        Production,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared2e531c6dd7d2b280TargetItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared2e531c6dd7d2b280TargetItem value)
        {
            return value switch
            {
                AutoSDKShared2e531c6dd7d2b280TargetItem.Development => "development",
                AutoSDKShared2e531c6dd7d2b280TargetItem.Preview => "preview",
                AutoSDKShared2e531c6dd7d2b280TargetItem.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared2e531c6dd7d2b280TargetItem? ToEnum(string value)
        {
            return value switch
            {
                "development" => AutoSDKShared2e531c6dd7d2b280TargetItem.Development,
                "preview" => AutoSDKShared2e531c6dd7d2b280TargetItem.Preview,
                "production" => AutoSDKShared2e531c6dd7d2b280TargetItem.Production,
                _ => null,
            };
        }
    }
}