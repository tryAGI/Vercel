
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateConditionalBypassRequestConditionGroupItemConditionVariant2Op
    {
        /// <summary>
        ///
        /// </summary>
        Eq,
        /// <summary>
        ///
        /// </summary>
        Pre,
        /// <summary>
        ///
        /// </summary>
        Sub,
        /// <summary>
        ///
        /// </summary>
        Suf,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateConditionalBypassRequestConditionGroupItemConditionVariant2OpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateConditionalBypassRequestConditionGroupItemConditionVariant2Op value)
        {
            return value switch
            {
                CreateConditionalBypassRequestConditionGroupItemConditionVariant2Op.Eq => "eq",
                CreateConditionalBypassRequestConditionGroupItemConditionVariant2Op.Pre => "pre",
                CreateConditionalBypassRequestConditionGroupItemConditionVariant2Op.Sub => "sub",
                CreateConditionalBypassRequestConditionGroupItemConditionVariant2Op.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateConditionalBypassRequestConditionGroupItemConditionVariant2Op? ToEnum(string value)
        {
            return value switch
            {
                "eq" => CreateConditionalBypassRequestConditionGroupItemConditionVariant2Op.Eq,
                "pre" => CreateConditionalBypassRequestConditionGroupItemConditionVariant2Op.Pre,
                "sub" => CreateConditionalBypassRequestConditionGroupItemConditionVariant2Op.Sub,
                "suf" => CreateConditionalBypassRequestConditionGroupItemConditionVariant2Op.Suf,
                _ => null,
            };
        }
    }
}