
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedea12f8422dc06e51ResourceConfigBuildMachineElasticTransitionDirection
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
    public static class AutoSDKSharedea12f8422dc06e51ResourceConfigBuildMachineElasticTransitionDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedea12f8422dc06e51ResourceConfigBuildMachineElasticTransitionDirection value)
        {
            return value switch
            {
                AutoSDKSharedea12f8422dc06e51ResourceConfigBuildMachineElasticTransitionDirection.Downgrade => "downgrade",
                AutoSDKSharedea12f8422dc06e51ResourceConfigBuildMachineElasticTransitionDirection.Upgrade => "upgrade",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedea12f8422dc06e51ResourceConfigBuildMachineElasticTransitionDirection? ToEnum(string value)
        {
            return value switch
            {
                "downgrade" => AutoSDKSharedea12f8422dc06e51ResourceConfigBuildMachineElasticTransitionDirection.Downgrade,
                "upgrade" => AutoSDKSharedea12f8422dc06e51ResourceConfigBuildMachineElasticTransitionDirection.Upgrade,
                _ => null,
            };
        }
    }
}