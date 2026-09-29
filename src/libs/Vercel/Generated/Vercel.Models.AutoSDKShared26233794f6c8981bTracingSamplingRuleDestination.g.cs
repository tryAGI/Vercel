
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Which tracing destination this rule applies to. `internal` is the hidden Vercel production-tracing drain (internal delivery); `external` is any customer-configured drain. Derived from the owning drain's delivery type when project tracing is computed; absent on configs persisted before this field existed.
    /// </summary>
    public enum AutoSDKShared26233794f6c8981bTracingSamplingRuleDestination
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
    public static class AutoSDKShared26233794f6c8981bTracingSamplingRuleDestinationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared26233794f6c8981bTracingSamplingRuleDestination value)
        {
            return value switch
            {
                AutoSDKShared26233794f6c8981bTracingSamplingRuleDestination.External => "external",
                AutoSDKShared26233794f6c8981bTracingSamplingRuleDestination.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared26233794f6c8981bTracingSamplingRuleDestination? ToEnum(string value)
        {
            return value switch
            {
                "external" => AutoSDKShared26233794f6c8981bTracingSamplingRuleDestination.External,
                "internal" => AutoSDKShared26233794f6c8981bTracingSamplingRuleDestination.Internal,
                _ => null,
            };
        }
    }
}