
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum AutoSDKSharedd67d8d405d3f0000BuildMachineElasticTransitionDirection
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
    public static class AutoSDKSharedd67d8d405d3f0000BuildMachineElasticTransitionDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKSharedd67d8d405d3f0000BuildMachineElasticTransitionDirection value)
        {
            return value switch
            {
                AutoSDKSharedd67d8d405d3f0000BuildMachineElasticTransitionDirection.Downgrade => "downgrade",
                AutoSDKSharedd67d8d405d3f0000BuildMachineElasticTransitionDirection.Upgrade => "upgrade",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKSharedd67d8d405d3f0000BuildMachineElasticTransitionDirection? ToEnum(string value)
        {
            return value switch
            {
                "downgrade" => AutoSDKSharedd67d8d405d3f0000BuildMachineElasticTransitionDirection.Downgrade,
                "upgrade" => AutoSDKSharedd67d8d405d3f0000BuildMachineElasticTransitionDirection.Upgrade,
                _ => null,
            };
        }
    }
}