
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateConditionalBypassRequestConditionGroupItemConditionVariant3Op
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
    public static class CreateConditionalBypassRequestConditionGroupItemConditionVariant3OpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateConditionalBypassRequestConditionGroupItemConditionVariant3Op value)
        {
            return value switch
            {
                CreateConditionalBypassRequestConditionGroupItemConditionVariant3Op.Eq => "eq",
                CreateConditionalBypassRequestConditionGroupItemConditionVariant3Op.Pre => "pre",
                CreateConditionalBypassRequestConditionGroupItemConditionVariant3Op.Sub => "sub",
                CreateConditionalBypassRequestConditionGroupItemConditionVariant3Op.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateConditionalBypassRequestConditionGroupItemConditionVariant3Op? ToEnum(string value)
        {
            return value switch
            {
                "eq" => CreateConditionalBypassRequestConditionGroupItemConditionVariant3Op.Eq,
                "pre" => CreateConditionalBypassRequestConditionGroupItemConditionVariant3Op.Pre,
                "sub" => CreateConditionalBypassRequestConditionGroupItemConditionVariant3Op.Sub,
                "suf" => CreateConditionalBypassRequestConditionGroupItemConditionVariant3Op.Suf,
                _ => null,
            };
        }
    }
}