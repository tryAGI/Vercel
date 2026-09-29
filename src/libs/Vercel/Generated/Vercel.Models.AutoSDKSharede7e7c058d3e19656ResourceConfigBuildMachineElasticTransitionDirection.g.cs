
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharede7e7c058d3e19656ResourceConfigBuildMachineElasticTransitionDirection
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
    public static class AutoSDKSharede7e7c058d3e19656ResourceConfigBuildMachineElasticTransitionDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharede7e7c058d3e19656ResourceConfigBuildMachineElasticTransitionDirection value)
        {
            return value switch
            {
                AutoSDKSharede7e7c058d3e19656ResourceConfigBuildMachineElasticTransitionDirection.Downgrade => "downgrade",
                AutoSDKSharede7e7c058d3e19656ResourceConfigBuildMachineElasticTransitionDirection.Upgrade => "upgrade",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharede7e7c058d3e19656ResourceConfigBuildMachineElasticTransitionDirection? ToEnum(string value)
        {
            return value switch
            {
                "downgrade" => AutoSDKSharede7e7c058d3e19656ResourceConfigBuildMachineElasticTransitionDirection.Downgrade,
                "upgrade" => AutoSDKSharede7e7c058d3e19656ResourceConfigBuildMachineElasticTransitionDirection.Upgrade,
                _ => null,
            };
        }
    }
}