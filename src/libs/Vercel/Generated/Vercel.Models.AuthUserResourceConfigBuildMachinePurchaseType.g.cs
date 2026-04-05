
#nullable enable

namespace Vercel
{
    /// <summary>
    /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
    /// </summary>
    public enum AuthUserResourceConfigBuildMachinePurchaseType
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
    public static class AuthUserResourceConfigBuildMachinePurchaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthUserResourceConfigBuildMachinePurchaseType value)
        {
            return value switch
            {
                AuthUserResourceConfigBuildMachinePurchaseType.Enhanced => "enhanced",
                AuthUserResourceConfigBuildMachinePurchaseType.Standard => "standard",
                AuthUserResourceConfigBuildMachinePurchaseType.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthUserResourceConfigBuildMachinePurchaseType? ToEnum(string value)
        {
            return value switch
            {
                "enhanced" => AuthUserResourceConfigBuildMachinePurchaseType.Enhanced,
                "standard" => AuthUserResourceConfigBuildMachinePurchaseType.Standard,
                "turbo" => AuthUserResourceConfigBuildMachinePurchaseType.Turbo,
                _ => null,
            };
        }
    }
}