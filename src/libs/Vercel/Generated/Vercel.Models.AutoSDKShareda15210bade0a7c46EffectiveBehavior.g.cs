
#nullable enable

namespace Vercel
{
    /// <summary>
    /// When the subscription change should take effect.
    /// </summary>
    public enum AutoSDKShareda15210bade0a7c46EffectiveBehavior
    {
        /// <summary>
        ///
        /// </summary>
        EndOfTerm,
        /// <summary>
        ///
        /// </summary>
        Immediate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoSDKShareda15210bade0a7c46EffectiveBehaviorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShareda15210bade0a7c46EffectiveBehavior value)
        {
            return value switch
            {
                AutoSDKShareda15210bade0a7c46EffectiveBehavior.EndOfTerm => "end_of_term",
                AutoSDKShareda15210bade0a7c46EffectiveBehavior.Immediate => "immediate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShareda15210bade0a7c46EffectiveBehavior? ToEnum(string value)
        {
            return value switch
            {
                "end_of_term" => AutoSDKShareda15210bade0a7c46EffectiveBehavior.EndOfTerm,
                "immediate" => AutoSDKShareda15210bade0a7c46EffectiveBehavior.Immediate,
                _ => null,
            };
        }
    }
}