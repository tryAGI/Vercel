
#nullable enable

namespace Vercel
{
    /// <summary>
    /// Require production secrets to use a different value than preview or development.
    /// </summary>
    public enum TeamDisjunctiveProductionSecretPolicy
    {
        /// <summary>
        ///
        /// </summary>
        Default,
        /// <summary>
        ///
        /// </summary>
        Off,
        /// <summary>
        ///
        /// </summary>
        On,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TeamDisjunctiveProductionSecretPolicyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamDisjunctiveProductionSecretPolicy value)
        {
            return value switch
            {
                TeamDisjunctiveProductionSecretPolicy.Default => "default",
                TeamDisjunctiveProductionSecretPolicy.Off => "off",
                TeamDisjunctiveProductionSecretPolicy.On => "on",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamDisjunctiveProductionSecretPolicy? ToEnum(string value)
        {
            return value switch
            {
                "default" => TeamDisjunctiveProductionSecretPolicy.Default,
                "off" => TeamDisjunctiveProductionSecretPolicy.Off,
                "on" => TeamDisjunctiveProductionSecretPolicy.On,
                _ => null,
            };
        }
    }
}