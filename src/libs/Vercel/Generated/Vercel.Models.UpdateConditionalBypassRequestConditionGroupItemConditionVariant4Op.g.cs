
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateConditionalBypassRequestConditionGroupItemConditionVariant4Op
    {
        /// <summary>
        ///
        /// </summary>
        Ex,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateConditionalBypassRequestConditionGroupItemConditionVariant4OpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateConditionalBypassRequestConditionGroupItemConditionVariant4Op value)
        {
            return value switch
            {
                UpdateConditionalBypassRequestConditionGroupItemConditionVariant4Op.Ex => "ex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateConditionalBypassRequestConditionGroupItemConditionVariant4Op? ToEnum(string value)
        {
            return value switch
            {
                "ex" => UpdateConditionalBypassRequestConditionGroupItemConditionVariant4Op.Ex,
                _ => null,
            };
        }
    }
}