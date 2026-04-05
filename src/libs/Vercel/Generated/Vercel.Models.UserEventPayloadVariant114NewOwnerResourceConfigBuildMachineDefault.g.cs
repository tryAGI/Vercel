
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant114NewOwnerResourceConfigBuildMachineDefault
    {
        /// <summary>
        /// 
        /// </summary>
        Elastic,
        /// <summary>
        /// 
        /// </summary>
        Enhanced,
        /// <summary>
        /// 
        /// </summary>
        Standard,
        /// <summary>
        /// 
        /// </summary>
        Turbo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant114NewOwnerResourceConfigBuildMachineDefaultExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant114NewOwnerResourceConfigBuildMachineDefault value)
        {
            return value switch
            {
                UserEventPayloadVariant114NewOwnerResourceConfigBuildMachineDefault.Elastic => "elastic",
                UserEventPayloadVariant114NewOwnerResourceConfigBuildMachineDefault.Enhanced => "enhanced",
                UserEventPayloadVariant114NewOwnerResourceConfigBuildMachineDefault.Standard => "standard",
                UserEventPayloadVariant114NewOwnerResourceConfigBuildMachineDefault.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant114NewOwnerResourceConfigBuildMachineDefault? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => UserEventPayloadVariant114NewOwnerResourceConfigBuildMachineDefault.Elastic,
                "enhanced" => UserEventPayloadVariant114NewOwnerResourceConfigBuildMachineDefault.Enhanced,
                "standard" => UserEventPayloadVariant114NewOwnerResourceConfigBuildMachineDefault.Standard,
                "turbo" => UserEventPayloadVariant114NewOwnerResourceConfigBuildMachineDefault.Turbo,
                _ => null,
            };
        }
    }
}