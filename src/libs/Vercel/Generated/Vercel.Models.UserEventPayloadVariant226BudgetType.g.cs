
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The budget type
    /// </summary>
    public enum UserEventPayloadVariant226BudgetType
    {
        /// <summary>
        /// 
        /// </summary>
        Fixed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant226BudgetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant226BudgetType value)
        {
            return value switch
            {
                UserEventPayloadVariant226BudgetType.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant226BudgetType? ToEnum(string value)
        {
            return value switch
            {
                "fixed" => UserEventPayloadVariant226BudgetType.Fixed,
                _ => null,
            };
        }
    }
}