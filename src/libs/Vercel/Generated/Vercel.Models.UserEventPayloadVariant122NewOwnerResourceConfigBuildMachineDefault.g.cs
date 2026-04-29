
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant122NewOwnerResourceConfigBuildMachineDefault
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
    public static class UserEventPayloadVariant122NewOwnerResourceConfigBuildMachineDefaultExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant122NewOwnerResourceConfigBuildMachineDefault value)
        {
            return value switch
            {
                UserEventPayloadVariant122NewOwnerResourceConfigBuildMachineDefault.Elastic => "elastic",
                UserEventPayloadVariant122NewOwnerResourceConfigBuildMachineDefault.Enhanced => "enhanced",
                UserEventPayloadVariant122NewOwnerResourceConfigBuildMachineDefault.Standard => "standard",
                UserEventPayloadVariant122NewOwnerResourceConfigBuildMachineDefault.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant122NewOwnerResourceConfigBuildMachineDefault? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => UserEventPayloadVariant122NewOwnerResourceConfigBuildMachineDefault.Elastic,
                "enhanced" => UserEventPayloadVariant122NewOwnerResourceConfigBuildMachineDefault.Enhanced,
                "standard" => UserEventPayloadVariant122NewOwnerResourceConfigBuildMachineDefault.Standard,
                "turbo" => UserEventPayloadVariant122NewOwnerResourceConfigBuildMachineDefault.Turbo,
                _ => null,
            };
        }
    }
}