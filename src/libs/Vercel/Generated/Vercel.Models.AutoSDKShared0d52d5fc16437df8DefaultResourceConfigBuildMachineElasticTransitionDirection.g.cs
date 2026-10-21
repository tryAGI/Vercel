
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared0d52d5fc16437df8DefaultResourceConfigBuildMachineElasticTransitionDirection
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
    public static class AutoSDKShared0d52d5fc16437df8DefaultResourceConfigBuildMachineElasticTransitionDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared0d52d5fc16437df8DefaultResourceConfigBuildMachineElasticTransitionDirection value)
        {
            return value switch
            {
                AutoSDKShared0d52d5fc16437df8DefaultResourceConfigBuildMachineElasticTransitionDirection.Downgrade => "downgrade",
                AutoSDKShared0d52d5fc16437df8DefaultResourceConfigBuildMachineElasticTransitionDirection.Upgrade => "upgrade",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared0d52d5fc16437df8DefaultResourceConfigBuildMachineElasticTransitionDirection? ToEnum(string value)
        {
            return value switch
            {
                "downgrade" => AutoSDKShared0d52d5fc16437df8DefaultResourceConfigBuildMachineElasticTransitionDirection.Downgrade,
                "upgrade" => AutoSDKShared0d52d5fc16437df8DefaultResourceConfigBuildMachineElasticTransitionDirection.Upgrade,
                _ => null,
            };
        }
    }
}