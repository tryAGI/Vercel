
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Which tracing destination this rule applies to. `internal` is the hidden Vercel production-tracing drain (internal delivery); `external` is any customer-configured drain. Derived from the owning drain's delivery type when project tracing is computed; absent on configs persisted before this field existed.
    /// </summary>
    public enum AutoSDKShared9bbe6cc4d61f3bf2TracingSamplingRuleDestination
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
    public static class AutoSDKShared9bbe6cc4d61f3bf2TracingSamplingRuleDestinationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared9bbe6cc4d61f3bf2TracingSamplingRuleDestination value)
        {
            return value switch
            {
                AutoSDKShared9bbe6cc4d61f3bf2TracingSamplingRuleDestination.External => "external",
                AutoSDKShared9bbe6cc4d61f3bf2TracingSamplingRuleDestination.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared9bbe6cc4d61f3bf2TracingSamplingRuleDestination? ToEnum(string value)
        {
            return value switch
            {
                "external" => AutoSDKShared9bbe6cc4d61f3bf2TracingSamplingRuleDestination.External,
                "internal" => AutoSDKShared9bbe6cc4d61f3bf2TracingSamplingRuleDestination.Internal,
                _ => null,
            };
        }
    }
}