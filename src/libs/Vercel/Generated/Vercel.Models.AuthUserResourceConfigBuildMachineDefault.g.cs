
#nullable enable

namespace Vercel
{
    /// <summary>
    /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
    /// </summary>
    public enum AuthUserResourceConfigBuildMachineDefault
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
    public static class AuthUserResourceConfigBuildMachineDefaultExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthUserResourceConfigBuildMachineDefault value)
        {
            return value switch
            {
                AuthUserResourceConfigBuildMachineDefault.Elastic => "elastic",
                AuthUserResourceConfigBuildMachineDefault.Enhanced => "enhanced",
                AuthUserResourceConfigBuildMachineDefault.Standard => "standard",
                AuthUserResourceConfigBuildMachineDefault.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthUserResourceConfigBuildMachineDefault? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => AuthUserResourceConfigBuildMachineDefault.Elastic,
                "enhanced" => AuthUserResourceConfigBuildMachineDefault.Enhanced,
                "standard" => AuthUserResourceConfigBuildMachineDefault.Standard,
                "turbo" => AuthUserResourceConfigBuildMachineDefault.Turbo,
                _ => null,
            };
        }
    }
}