
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Which tracing destination this rule applies to. `internal` is the hidden Vercel production-tracing drain (internal delivery); `external` is any customer-configured drain. Derived from the owning drain's delivery type when project tracing is computed; absent on configs persisted before this field existed.
    /// </summary>
    public enum AutoSDKShared0f99f1735f329c6cTracingSamplingRuleDestination
    {
        /// <summary>
        ///
        /// </summary>
        External,
        /// <summary>
        ///
        /// </summary>
        Internal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared0f99f1735f329c6cTracingSamplingRuleDestinationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0f99f1735f329c6cTracingSamplingRuleDestination value)
        {
            return value switch
            {
                AutoSDKShared0f99f1735f329c6cTracingSamplingRuleDestination.External => "external",
                AutoSDKShared0f99f1735f329c6cTracingSamplingRuleDestination.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0f99f1735f329c6cTracingSamplingRuleDestination? ToEnum(string value)
        {
            return value switch
            {
                "external" => AutoSDKShared0f99f1735f329c6cTracingSamplingRuleDestination.External,
                "internal" => AutoSDKShared0f99f1735f329c6cTracingSamplingRuleDestination.Internal,
                _ => null,
            };
        }
    }
}