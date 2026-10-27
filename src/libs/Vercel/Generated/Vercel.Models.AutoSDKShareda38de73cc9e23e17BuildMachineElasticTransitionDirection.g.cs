
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKShareda38de73cc9e23e17BuildMachineElasticTransitionDirection
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
    public static class AutoSDKShareda38de73cc9e23e17BuildMachineElasticTransitionDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda38de73cc9e23e17BuildMachineElasticTransitionDirection value)
        {
            return value switch
            {
                AutoSDKShareda38de73cc9e23e17BuildMachineElasticTransitionDirection.Downgrade => "downgrade",
                AutoSDKShareda38de73cc9e23e17BuildMachineElasticTransitionDirection.Upgrade => "upgrade",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda38de73cc9e23e17BuildMachineElasticTransitionDirection? ToEnum(string value)
        {
            return value switch
            {
                "downgrade" => AutoSDKShareda38de73cc9e23e17BuildMachineElasticTransitionDirection.Downgrade,
                "upgrade" => AutoSDKShareda38de73cc9e23e17BuildMachineElasticTransitionDirection.Upgrade,
                _ => null,
            };
        }
    }
}