
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateFlagResponseExperimentAllocationUnit
    {
        /// <summary>
        /// 
        /// </summary>
        CookieId,
        /// <summary>
        /// 
        /// </summary>
        UserId,
        /// <summary>
        /// 
        /// </summary>
        VisitorId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateFlagResponseExperimentAllocationUnitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateFlagResponseExperimentAllocationUnit value)
        {
            return value switch
            {
                CreateFlagResponseExperimentAllocationUnit.CookieId => "cookieId",
                CreateFlagResponseExperimentAllocationUnit.UserId => "userId",
                CreateFlagResponseExperimentAllocationUnit.VisitorId => "visitorId",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateFlagResponseExperimentAllocationUnit? ToEnum(string value)
        {
            return value switch
            {
                "cookieId" => CreateFlagResponseExperimentAllocationUnit.CookieId,
                "userId" => CreateFlagResponseExperimentAllocationUnit.UserId,
                "visitorId" => CreateFlagResponseExperimentAllocationUnit.VisitorId,
                _ => null,
            };
        }
    }
}