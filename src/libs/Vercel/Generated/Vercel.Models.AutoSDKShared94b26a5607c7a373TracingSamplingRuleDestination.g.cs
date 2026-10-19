
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Which tracing destination this rule applies to. `internal` is the hidden Vercel production-tracing drain (internal delivery); `external` is any customer-configured drain. Derived from the owning drain's delivery type when project tracing is computed; absent on configs persisted before this field existed.
    /// </summary>
    public enum AutoSDKShared94b26a5607c7a373TracingSamplingRuleDestination
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
    public static class AutoSDKShared94b26a5607c7a373TracingSamplingRuleDestinationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared94b26a5607c7a373TracingSamplingRuleDestination value)
        {
            return value switch
            {
                AutoSDKShared94b26a5607c7a373TracingSamplingRuleDestination.External => "external",
                AutoSDKShared94b26a5607c7a373TracingSamplingRuleDestination.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared94b26a5607c7a373TracingSamplingRuleDestination? ToEnum(string value)
        {
            return value switch
            {
                "external" => AutoSDKShared94b26a5607c7a373TracingSamplingRuleDestination.External,
                "internal" => AutoSDKShared94b26a5607c7a373TracingSamplingRuleDestination.Internal,
                _ => null,
            };
        }
    }
}