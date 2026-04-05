
#nullable enable

namespace Vercel
{
    /// <summary>
    /// An object containing infomation related to the amount of platform resources may be allocated to the User account.
    /// </summary>
    public enum AuthUserResourceConfigBuildMachineMachineSelectionType
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
    public static class AuthUserResourceConfigBuildMachineMachineSelectionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthUserResourceConfigBuildMachineMachineSelectionType value)
        {
            return value switch
            {
                AuthUserResourceConfigBuildMachineMachineSelectionType.Elastic => "elastic",
                AuthUserResourceConfigBuildMachineMachineSelectionType.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthUserResourceConfigBuildMachineMachineSelectionType? ToEnum(string value)
        {
            return value switch
            {
                "elastic" => AuthUserResourceConfigBuildMachineMachineSelectionType.Elastic,
                "fixed" => AuthUserResourceConfigBuildMachineMachineSelectionType.Fixed,
                _ => null,
            };
        }
    }
}