
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateConditionalBypassRequestConditionGroupItemConditionVariant4Op
    {
        /// <summary>
        ///
        /// </summary>
        Ex,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateConditionalBypassRequestConditionGroupItemConditionVariant4OpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateConditionalBypassRequestConditionGroupItemConditionVariant4Op value)
        {
            return value switch
            {
                CreateConditionalBypassRequestConditionGroupItemConditionVariant4Op.Ex => "ex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateConditionalBypassRequestConditionGroupItemConditionVariant4Op? ToEnum(string value)
        {
            return value switch
            {
                "ex" => CreateConditionalBypassRequestConditionGroupItemConditionVariant4Op.Ex,
                _ => null,
            };
        }
    }
}