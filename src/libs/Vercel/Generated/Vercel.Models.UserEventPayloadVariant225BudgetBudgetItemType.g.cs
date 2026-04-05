
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The budget type
    /// </summary>
    public enum UserEventPayloadVariant225BudgetBudgetItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Fixed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant225BudgetBudgetItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant225BudgetBudgetItemType value)
        {
            return value switch
            {
                UserEventPayloadVariant225BudgetBudgetItemType.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant225BudgetBudgetItemType? ToEnum(string value)
        {
            return value switch
            {
                "fixed" => UserEventPayloadVariant225BudgetBudgetItemType.Fixed,
                _ => null,
            };
        }
    }
}