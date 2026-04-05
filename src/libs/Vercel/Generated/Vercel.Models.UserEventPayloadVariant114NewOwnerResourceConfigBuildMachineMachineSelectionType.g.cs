
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant114NewOwnerResourceConfigBuildMachineMachineSelectionType
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
    public static class UserEventPayloadVariant114NewOwnerResourceConfigBuildMachineMachineSelectionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant114NewOwnerResourceConfigBuildMachineMachineSelectionType value)
        {
            return value switch
            {
                UserEventPayloadVariant114NewOwnerResourceConfigBuildMachineMachineSelectionType.Elastic => "elastic",
                UserEventPayloadVariant114NewOwnerResourceConfigBuildMachineMachineSelectionType.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant114NewOwnerResourceConfigBuildMachineMachineSelectionType? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => UserEventPayloadVariant114NewOwnerResourceConfigBuildMachineMachineSelectionType.Elastic,
                "fixed" => UserEventPayloadVariant114NewOwnerResourceConfigBuildMachineMachineSelectionType.Fixed,
                _ => null,
            };
        }
    }
}