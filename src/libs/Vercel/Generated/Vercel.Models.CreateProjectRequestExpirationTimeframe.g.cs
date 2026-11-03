
#nullable enable

namespace Vercel
{
    /// <summary>
    /// How far in the future the project will be automatically deleted
    /// </summary>
    public enum CreateProjectRequestExpirationTimeframe
    {
        /// <summary>
        ///
        /// </summary>
        x1Day,
        /// <summary>
        ///
        /// </summary>
        x1Hour,
        /// <summary>
        ///
        /// </summary>
        x1Month,
        /// <summary>
        ///
        /// </summary>
        x1Week,
        /// <summary>
        ///
        /// </summary>
        x2Week,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectRequestExpirationTimeframeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectRequestExpirationTimeframe value)
        {
            return value switch
            {
                CreateProjectRequestExpirationTimeframe.x1Day => "1-day",
                CreateProjectRequestExpirationTimeframe.x1Hour => "1-hour",
                CreateProjectRequestExpirationTimeframe.x1Month => "1-month",
                CreateProjectRequestExpirationTimeframe.x1Week => "1-week",
                CreateProjectRequestExpirationTimeframe.x2Week => "2-week",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectRequestExpirationTimeframe? ToEnum(string value)
        {
            return value switch
            {
                "1-day" => CreateProjectRequestExpirationTimeframe.x1Day,
                "1-hour" => CreateProjectRequestExpirationTimeframe.x1Hour,
                "1-month" => CreateProjectRequestExpirationTimeframe.x1Month,
                "1-week" => CreateProjectRequestExpirationTimeframe.x1Week,
                "2-week" => CreateProjectRequestExpirationTimeframe.x2Week,
                _ => null,
            };
        }
    }
}