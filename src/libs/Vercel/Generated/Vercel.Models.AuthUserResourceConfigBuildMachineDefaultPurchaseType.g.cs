
#nullable enable

namespace Vercel
{
    /// <summary>
    /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
    /// </summary>
    public enum AuthUserResourceConfigBuildMachineDefaultPurchaseType
    {
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
    public static class AuthUserResourceConfigBuildMachineDefaultPurchaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthUserResourceConfigBuildMachineDefaultPurchaseType value)
        {
            return value switch
            {
                AuthUserResourceConfigBuildMachineDefaultPurchaseType.Enhanced => "enhanced",
                AuthUserResourceConfigBuildMachineDefaultPurchaseType.Standard => "standard",
                AuthUserResourceConfigBuildMachineDefaultPurchaseType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthUserResourceConfigBuildMachineDefaultPurchaseType? ToEnum(string value)
        {
            return value switch
            {
                "enhanced" => AuthUserResourceConfigBuildMachineDefaultPurchaseType.Enhanced,
                "standard" => AuthUserResourceConfigBuildMachineDefaultPurchaseType.Standard,
                "turbo" => AuthUserResourceConfigBuildMachineDefaultPurchaseType.Turbo,
                _ => null,
            };
        }
    }
}