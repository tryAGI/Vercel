
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedba7c6b12ca723bfbResourceConfigBuildMachineElasticTransitionDirection
    {
        /// <summary>
        ///
        /// </summary>
        Downgrade,
        /// <summary>
        ///
        /// </summary>
        Upgrade,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKSharedba7c6b12ca723bfbResourceConfigBuildMachineElasticTransitionDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedba7c6b12ca723bfbResourceConfigBuildMachineElasticTransitionDirection value)
        {
            return value switch
            {
                AutoSDKSharedba7c6b12ca723bfbResourceConfigBuildMachineElasticTransitionDirection.Downgrade => "downgrade",
                AutoSDKSharedba7c6b12ca723bfbResourceConfigBuildMachineElasticTransitionDirection.Upgrade => "upgrade",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedba7c6b12ca723bfbResourceConfigBuildMachineElasticTransitionDirection? ToEnum(string value)
        {
            return value switch
            {
                "downgrade" => AutoSDKSharedba7c6b12ca723bfbResourceConfigBuildMachineElasticTransitionDirection.Downgrade,
                "upgrade" => AutoSDKSharedba7c6b12ca723bfbResourceConfigBuildMachineElasticTransitionDirection.Upgrade,
                _ => null,
            };
        }
    }
}