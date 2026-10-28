
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The build ran on a fixed machine. Drives billing.
    /// </summary>
    public enum AutoSDKShared6120795acc1bdfb3Variant2MachineSelectionType
    {
        /// <summary>
        ///
        /// </summary>
        Fixed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared6120795acc1bdfb3Variant2MachineSelectionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared6120795acc1bdfb3Variant2MachineSelectionType value)
        {
            return value switch
            {
                AutoSDKShared6120795acc1bdfb3Variant2MachineSelectionType.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared6120795acc1bdfb3Variant2MachineSelectionType? ToEnum(string value)
        {
            return value switch
            {
                "fixed" => AutoSDKShared6120795acc1bdfb3Variant2MachineSelectionType.Fixed,
                _ => null,
            };
        }
    }
}