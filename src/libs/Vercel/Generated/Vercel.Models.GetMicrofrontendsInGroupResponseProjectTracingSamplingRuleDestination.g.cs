
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Which tracing destination this rule applies to. `internal` is the hidden Vercel production-tracing drain (internal delivery); `external` is any customer-configured drain. Derived from the owning drain's delivery type when project tracing is computed; absent on configs persisted before this field existed.
    /// </summary>
    public enum GetMicrofrontendsInGroupResponseProjectTracingSamplingRuleDestination
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
    public static class GetMicrofrontendsInGroupResponseProjectTracingSamplingRuleDestinationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMicrofrontendsInGroupResponseProjectTracingSamplingRuleDestination value)
        {
            return value switch
            {
                GetMicrofrontendsInGroupResponseProjectTracingSamplingRuleDestination.External => "external",
                GetMicrofrontendsInGroupResponseProjectTracingSamplingRuleDestination.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMicrofrontendsInGroupResponseProjectTracingSamplingRuleDestination? ToEnum(string value)
        {
            return value switch
            {
                "external" => GetMicrofrontendsInGroupResponseProjectTracingSamplingRuleDestination.External,
                "internal" => GetMicrofrontendsInGroupResponseProjectTracingSamplingRuleDestination.Internal,
                _ => null,
            };
        }
    }
}