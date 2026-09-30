
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildMachineElasticTransitionDirection
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
    public static class AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildMachineElasticTransitionDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildMachineElasticTransitionDirection value)
        {
            return value switch
            {
                AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildMachineElasticTransitionDirection.Downgrade => "downgrade",
                AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildMachineElasticTransitionDirection.Upgrade => "upgrade",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildMachineElasticTransitionDirection? ToEnum(string value)
        {
            return value switch
            {
                "downgrade" => AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildMachineElasticTransitionDirection.Downgrade,
                "upgrade" => AutoSDKSharedea12f8422dc06e51DefaultResourceConfigBuildMachineElasticTransitionDirection.Upgrade,
                _ => null,
            };
        }
    }
}