
#nullable enable

namespace Vercel
{
    /// <summary>
    /// When the subscription change should take effect.
    /// </summary>
    public enum AutoSDKShared7eafcec92f234b4aEffectiveBehavior
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
    public static class AutoSDKShared7eafcec92f234b4aEffectiveBehaviorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoSDKShared7eafcec92f234b4aEffectiveBehavior value)
        {
            return value switch
            {
                AutoSDKShared7eafcec92f234b4aEffectiveBehavior.EndOfTerm => "end_of_term",
                AutoSDKShared7eafcec92f234b4aEffectiveBehavior.Immediate => "immediate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoSDKShared7eafcec92f234b4aEffectiveBehavior? ToEnum(string value)
        {
            return value switch
            {
                "end_of_term" => AutoSDKShared7eafcec92f234b4aEffectiveBehavior.EndOfTerm,
                "immediate" => AutoSDKShared7eafcec92f234b4aEffectiveBehavior.Immediate,
                _ => null,
            };
        }
    }
}