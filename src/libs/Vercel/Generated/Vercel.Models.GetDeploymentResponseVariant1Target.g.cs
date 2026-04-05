
#nullable enable

namespace Vercel
{
    /// <summary>
    /// If defined, either `staging` if a staging alias in the format `&lt;project&gt;.&lt;team&gt;.now.sh` was assigned upon creation, or `production` if the aliases from `alias` were assigned. `null` value indicates the "preview" deployment.<br/>
    /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
    /// </summary>
    public enum GetDeploymentResponseVariant1Target
    {
        /// <summary>
        /// 
        /// </summary>
        Production,
        /// <summary>
        /// 
        /// </summary>
        Staging,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeploymentResponseVariant1TargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeploymentResponseVariant1Target value)
        {
            return value switch
            {
                GetDeploymentResponseVariant1Target.Production => "production",
                GetDeploymentResponseVariant1Target.Staging => "staging",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeploymentResponseVariant1Target? ToEnum(string value)
        {
            return value switch
            {
                "production" => GetDeploymentResponseVariant1Target.Production,
                "staging" => GetDeploymentResponseVariant1Target.Staging,
                _ => null,
            };
        }
    }
}