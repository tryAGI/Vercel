
#nullable enable

namespace Vercel
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateConditionalBypassRequestConditionGroupItemConditionVariant1Op
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
    public static class CreateConditionalBypassRequestConditionGroupItemConditionVariant1OpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateConditionalBypassRequestConditionGroupItemConditionVariant1Op value)
        {
            return value switch
            {
                CreateConditionalBypassRequestConditionGroupItemConditionVariant1Op.Eq => "eq",
                CreateConditionalBypassRequestConditionGroupItemConditionVariant1Op.Pre => "pre",
                CreateConditionalBypassRequestConditionGroupItemConditionVariant1Op.Sub => "sub",
                CreateConditionalBypassRequestConditionGroupItemConditionVariant1Op.Suf => "suf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateConditionalBypassRequestConditionGroupItemConditionVariant1Op? ToEnum(string value)
        {
            return value switch
            {
                "eq" => CreateConditionalBypassRequestConditionGroupItemConditionVariant1Op.Eq,
                "pre" => CreateConditionalBypassRequestConditionGroupItemConditionVariant1Op.Pre,
                "sub" => CreateConditionalBypassRequestConditionGroupItemConditionVariant1Op.Sub,
                "suf" => CreateConditionalBypassRequestConditionGroupItemConditionVariant1Op.Suf,
                _ => null,
            };
        }
    }
}