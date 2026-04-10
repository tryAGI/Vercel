
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant115NewOwnerResourceConfigBuildMachineDefault
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
    public static class UserEventPayloadVariant115NewOwnerResourceConfigBuildMachineDefaultExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant115NewOwnerResourceConfigBuildMachineDefault value)
        {
            return value switch
            {
                UserEventPayloadVariant115NewOwnerResourceConfigBuildMachineDefault.Elastic => "elastic",
                UserEventPayloadVariant115NewOwnerResourceConfigBuildMachineDefault.Enhanced => "enhanced",
                UserEventPayloadVariant115NewOwnerResourceConfigBuildMachineDefault.Standard => "standard",
                UserEventPayloadVariant115NewOwnerResourceConfigBuildMachineDefault.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant115NewOwnerResourceConfigBuildMachineDefault? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => UserEventPayloadVariant115NewOwnerResourceConfigBuildMachineDefault.Elastic,
                "enhanced" => UserEventPayloadVariant115NewOwnerResourceConfigBuildMachineDefault.Enhanced,
                "standard" => UserEventPayloadVariant115NewOwnerResourceConfigBuildMachineDefault.Standard,
                "turbo" => UserEventPayloadVariant115NewOwnerResourceConfigBuildMachineDefault.Turbo,
                _ => null,
            };
        }
    }
}