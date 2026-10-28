
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The build ran on an elastic machine. Drives billing.
    /// </summary>
    public enum AutoSDKShared6120795acc1bdfb3Variant1MachineSelectionType
    {
        /// <summary>
        ///
        /// </summary>
        Elastic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared6120795acc1bdfb3Variant1MachineSelectionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6120795acc1bdfb3Variant1MachineSelectionType value)
        {
            return value switch
            {
                AutoSDKShared6120795acc1bdfb3Variant1MachineSelectionType.Elastic => "elastic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6120795acc1bdfb3Variant1MachineSelectionType? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => AutoSDKShared6120795acc1bdfb3Variant1MachineSelectionType.Elastic,
                _ => null,
            };
        }
    }
}