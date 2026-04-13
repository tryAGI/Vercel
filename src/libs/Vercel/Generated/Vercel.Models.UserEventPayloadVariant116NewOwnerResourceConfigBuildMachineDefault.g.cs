
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant116NewOwnerResourceConfigBuildMachineDefault
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
    public static class UserEventPayloadVariant116NewOwnerResourceConfigBuildMachineDefaultExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant116NewOwnerResourceConfigBuildMachineDefault value)
        {
            return value switch
            {
                UserEventPayloadVariant116NewOwnerResourceConfigBuildMachineDefault.Elastic => "elastic",
                UserEventPayloadVariant116NewOwnerResourceConfigBuildMachineDefault.Enhanced => "enhanced",
                UserEventPayloadVariant116NewOwnerResourceConfigBuildMachineDefault.Standard => "standard",
                UserEventPayloadVariant116NewOwnerResourceConfigBuildMachineDefault.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant116NewOwnerResourceConfigBuildMachineDefault? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => UserEventPayloadVariant116NewOwnerResourceConfigBuildMachineDefault.Elastic,
                "enhanced" => UserEventPayloadVariant116NewOwnerResourceConfigBuildMachineDefault.Enhanced,
                "standard" => UserEventPayloadVariant116NewOwnerResourceConfigBuildMachineDefault.Standard,
                "turbo" => UserEventPayloadVariant116NewOwnerResourceConfigBuildMachineDefault.Turbo,
                _ => null,
            };
        }
    }
}