
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The build ran on an elastic machine. Drives billing.
    /// </summary>
    public enum AutoSDKShared24b8e64f7956d798Variant1MachineSelectionType
    {
        /// <summary>
        ///
        /// </summary>
        Elastic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShared24b8e64f7956d798Variant1MachineSelectionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared24b8e64f7956d798Variant1MachineSelectionType value)
        {
            return value switch
            {
                AutoSDKShared24b8e64f7956d798Variant1MachineSelectionType.Elastic => "elastic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared24b8e64f7956d798Variant1MachineSelectionType? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => AutoSDKShared24b8e64f7956d798Variant1MachineSelectionType.Elastic,
                _ => null,
            };
        }
    }
}