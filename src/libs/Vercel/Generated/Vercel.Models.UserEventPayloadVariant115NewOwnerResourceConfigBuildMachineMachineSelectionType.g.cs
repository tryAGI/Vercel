
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant115NewOwnerResourceConfigBuildMachineMachineSelectionType
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
    public static class UserEventPayloadVariant115NewOwnerResourceConfigBuildMachineMachineSelectionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant115NewOwnerResourceConfigBuildMachineMachineSelectionType value)
        {
            return value switch
            {
                UserEventPayloadVariant115NewOwnerResourceConfigBuildMachineMachineSelectionType.Elastic => "elastic",
                UserEventPayloadVariant115NewOwnerResourceConfigBuildMachineMachineSelectionType.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant115NewOwnerResourceConfigBuildMachineMachineSelectionType? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => UserEventPayloadVariant115NewOwnerResourceConfigBuildMachineMachineSelectionType.Elastic,
                "fixed" => UserEventPayloadVariant115NewOwnerResourceConfigBuildMachineMachineSelectionType.Fixed,
                _ => null,
            };
        }
    }
}