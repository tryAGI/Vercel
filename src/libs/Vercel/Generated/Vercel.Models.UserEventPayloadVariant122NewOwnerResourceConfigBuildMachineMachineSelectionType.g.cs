
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant122NewOwnerResourceConfigBuildMachineMachineSelectionType
    {
        /// <summary>
        /// 
        /// </summary>
        Elastic,
        /// <summary>
        /// 
        /// </summary>
        Fixed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant122NewOwnerResourceConfigBuildMachineMachineSelectionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant122NewOwnerResourceConfigBuildMachineMachineSelectionType value)
        {
            return value switch
            {
                UserEventPayloadVariant122NewOwnerResourceConfigBuildMachineMachineSelectionType.Elastic => "elastic",
                UserEventPayloadVariant122NewOwnerResourceConfigBuildMachineMachineSelectionType.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant122NewOwnerResourceConfigBuildMachineMachineSelectionType? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => UserEventPayloadVariant122NewOwnerResourceConfigBuildMachineMachineSelectionType.Elastic,
                "fixed" => UserEventPayloadVariant122NewOwnerResourceConfigBuildMachineMachineSelectionType.Fixed,
                _ => null,
            };
        }
    }
}