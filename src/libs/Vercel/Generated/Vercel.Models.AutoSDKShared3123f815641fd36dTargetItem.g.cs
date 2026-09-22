
#nullable enable

namespace Vercel
{
    /// <summary>
    /// environments this env variable targets<br/>
    /// Example: production
    /// </summary>
    public enum AutoSDKShared3123f815641fd36dTargetItem
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
    public static class AutoSDKShared3123f815641fd36dTargetItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared3123f815641fd36dTargetItem value)
        {
            return value switch
            {
                AutoSDKShared3123f815641fd36dTargetItem.Development => "development",
                AutoSDKShared3123f815641fd36dTargetItem.Preview => "preview",
                AutoSDKShared3123f815641fd36dTargetItem.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared3123f815641fd36dTargetItem? ToEnum(string value)
        {
            return value switch
            {
                "development" => AutoSDKShared3123f815641fd36dTargetItem.Development,
                "preview" => AutoSDKShared3123f815641fd36dTargetItem.Preview,
                "production" => AutoSDKShared3123f815641fd36dTargetItem.Production,
                _ => null,
            };
        }
    }
}