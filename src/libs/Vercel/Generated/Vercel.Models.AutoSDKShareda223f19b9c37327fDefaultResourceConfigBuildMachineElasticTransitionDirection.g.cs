
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda223f19b9c37327fDefaultResourceConfigBuildMachineElasticTransitionDirection
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
    public static class AutoSDKShareda223f19b9c37327fDefaultResourceConfigBuildMachineElasticTransitionDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda223f19b9c37327fDefaultResourceConfigBuildMachineElasticTransitionDirection value)
        {
            return value switch
            {
                AutoSDKShareda223f19b9c37327fDefaultResourceConfigBuildMachineElasticTransitionDirection.Downgrade => "downgrade",
                AutoSDKShareda223f19b9c37327fDefaultResourceConfigBuildMachineElasticTransitionDirection.Upgrade => "upgrade",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda223f19b9c37327fDefaultResourceConfigBuildMachineElasticTransitionDirection? ToEnum(string value)
        {
            return value switch
            {
                "downgrade" => AutoSDKShareda223f19b9c37327fDefaultResourceConfigBuildMachineElasticTransitionDirection.Downgrade,
                "upgrade" => AutoSDKShareda223f19b9c37327fDefaultResourceConfigBuildMachineElasticTransitionDirection.Upgrade,
                _ => null,
            };
        }
    }
}