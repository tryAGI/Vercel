
#nullable enable

namespace Vercel
{
    /// <summary>
    /// The budget type
    /// </summary>
    public enum UserEventPayloadVariant241BudgetBudgetItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Fixed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant241BudgetBudgetItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant241BudgetBudgetItemType value)
        {
            return value switch
            {
                UserEventPayloadVariant241BudgetBudgetItemType.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant241BudgetBudgetItemType? ToEnum(string value)
        {
            return value switch
            {
                "fixed" => UserEventPayloadVariant241BudgetBudgetItemType.Fixed,
                _ => null,
            };
        }
    }
}