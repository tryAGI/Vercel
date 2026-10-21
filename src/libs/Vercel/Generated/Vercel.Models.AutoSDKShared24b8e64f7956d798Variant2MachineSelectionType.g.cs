
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The build ran on a fixed machine. Drives billing.
    /// </summary>
    public enum AutoSDKShared24b8e64f7956d798Variant2MachineSelectionType
    {
        /// <summary>
        ///
        /// </summary>
        Fixed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared24b8e64f7956d798Variant2MachineSelectionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared24b8e64f7956d798Variant2MachineSelectionType value)
        {
            return value switch
            {
                AutoSDKShared24b8e64f7956d798Variant2MachineSelectionType.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared24b8e64f7956d798Variant2MachineSelectionType? ToEnum(string value)
        {
            return value switch
            {
                "fixed" => AutoSDKShared24b8e64f7956d798Variant2MachineSelectionType.Fixed,
                _ => null,
            };
        }
    }
}