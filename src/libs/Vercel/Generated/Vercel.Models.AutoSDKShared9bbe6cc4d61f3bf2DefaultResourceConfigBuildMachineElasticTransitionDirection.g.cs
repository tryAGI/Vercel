
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShared9bbe6cc4d61f3bf2DefaultResourceConfigBuildMachineElasticTransitionDirection
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
    public static class AutoSDKShared9bbe6cc4d61f3bf2DefaultResourceConfigBuildMachineElasticTransitionDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared9bbe6cc4d61f3bf2DefaultResourceConfigBuildMachineElasticTransitionDirection value)
        {
            return value switch
            {
                AutoSDKShared9bbe6cc4d61f3bf2DefaultResourceConfigBuildMachineElasticTransitionDirection.Downgrade => "downgrade",
                AutoSDKShared9bbe6cc4d61f3bf2DefaultResourceConfigBuildMachineElasticTransitionDirection.Upgrade => "upgrade",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared9bbe6cc4d61f3bf2DefaultResourceConfigBuildMachineElasticTransitionDirection? ToEnum(string value)
        {
            return value switch
            {
                "downgrade" => AutoSDKShared9bbe6cc4d61f3bf2DefaultResourceConfigBuildMachineElasticTransitionDirection.Downgrade,
                "upgrade" => AutoSDKShared9bbe6cc4d61f3bf2DefaultResourceConfigBuildMachineElasticTransitionDirection.Upgrade,
                _ => null,
            };
        }
    }
}