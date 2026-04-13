
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant116NewOwnerResourceConfigBuildMachineMachineSelectionType
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
    public static class UserEventPayloadVariant116NewOwnerResourceConfigBuildMachineMachineSelectionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant116NewOwnerResourceConfigBuildMachineMachineSelectionType value)
        {
            return value switch
            {
                UserEventPayloadVariant116NewOwnerResourceConfigBuildMachineMachineSelectionType.Elastic => "elastic",
                UserEventPayloadVariant116NewOwnerResourceConfigBuildMachineMachineSelectionType.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant116NewOwnerResourceConfigBuildMachineMachineSelectionType? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => UserEventPayloadVariant116NewOwnerResourceConfigBuildMachineMachineSelectionType.Elastic,
                "fixed" => UserEventPayloadVariant116NewOwnerResourceConfigBuildMachineMachineSelectionType.Fixed,
                _ => null,
            };
        }
    }
}