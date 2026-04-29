
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType
    {
        /// <summary>
        /// 
        /// </summary>
        AnalyticsUsage,
        /// <summary>
        /// 
        /// </summary>
        Artifacts,
        /// <summary>
        /// 
        /// </summary>
        Bandwidth,
        /// <summary>
        /// 
        /// </summary>
        BlobDataTransfer,
        /// <summary>
        /// 
        /// </summary>
        BlobTotalAdvancedRequests,
        /// <summary>
        /// 
        /// </summary>
        BlobTotalAvgSizeInBytes,
        /// <summary>
        /// 
        /// </summary>
        BlobTotalGetResponseObjectSizeInBytes,
        /// <summary>
        /// 
        /// </summary>
        BlobTotalSimpleRequests,
        /// <summary>
        /// 
        /// </summary>
        ConnectDataTransfer,
        /// <summary>
        /// 
        /// </summary>
        DataCacheRead,
        /// <summary>
        /// 
        /// </summary>
        DataCacheWrite,
        /// <summary>
        /// 
        /// </summary>
        EdgeConfigRead,
        /// <summary>
        /// 
        /// </summary>
        EdgeConfigWrite,
        /// <summary>
        /// 
        /// </summary>
        EdgeFunctionExecutionUnits,
        /// <summary>
        /// 
        /// </summary>
        EdgeMiddlewareInvocations,
        /// <summary>
        /// 
        /// </summary>
        EdgeRequest,
        /// <summary>
        /// 
        /// </summary>
        EdgeRequestAdditionalCpuDuration,
        /// <summary>
        /// 
        /// </summary>
        ElasticConcurrencyBuildSlots,
        /// <summary>
        /// 
        /// </summary>
        FastDataTransfer,
        /// <summary>
        /// 
        /// </summary>
        FastOriginTransfer,
        /// <summary>
        /// 
        /// </summary>
        FluidCpuDuration,
        /// <summary>
        /// 
        /// </summary>
        FluidDuration,
        /// <summary>
        /// 
        /// </summary>
        FunctionDuration,
        /// <summary>
        /// 
        /// </summary>
        FunctionInvocation,
        /// <summary>
        /// 
        /// </summary>
        ImageOptimizationCacheRead,
        /// <summary>
        /// 
        /// </summary>
        ImageOptimizationCacheWrite,
        /// <summary>
        /// 
        /// </summary>
        ImageOptimizationTransformation,
        /// <summary>
        /// 
        /// </summary>
        LogDrainsVolume,
        /// <summary>
        /// 
        /// </summary>
        MonitoringMetric,
        /// <summary>
        /// 
        /// </summary>
        ObservabilityEvent,
        /// <summary>
        /// 
        /// </summary>
        OnDemandConcurrencyMinutes,
        /// <summary>
        /// 
        /// </summary>
        RuntimeCacheRead,
        /// <summary>
        /// 
        /// </summary>
        RuntimeCacheWrite,
        /// <summary>
        /// 
        /// </summary>
        ServerlessFunctionExecution,
        /// <summary>
        /// 
        /// </summary>
        SourceImages,
        /// <summary>
        /// 
        /// </summary>
        WafOwaspExcessBytes,
        /// <summary>
        /// 
        /// </summary>
        WafOwaspRequests,
        /// <summary>
        /// 
        /// </summary>
        WafRateLimitRequest,
        /// <summary>
        /// 
        /// </summary>
        WebAnalyticsEvent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType value)
        {
            return value switch
            {
                UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.AnalyticsUsage => "analyticsUsage",
                UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.Artifacts => "artifacts",
                UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.Bandwidth => "bandwidth",
                UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.BlobDataTransfer => "blobDataTransfer",
                UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.BlobTotalAdvancedRequests => "blobTotalAdvancedRequests",
                UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.BlobTotalAvgSizeInBytes => "blobTotalAvgSizeInBytes",
                UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.BlobTotalGetResponseObjectSizeInBytes => "blobTotalGetResponseObjectSizeInBytes",
                UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.BlobTotalSimpleRequests => "blobTotalSimpleRequests",
                UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.ConnectDataTransfer => "connectDataTransfer",
                UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.DataCacheRead => "dataCacheRead",
                UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.DataCacheWrite => "dataCacheWrite",
                UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.EdgeConfigRead => "edgeConfigRead",
                UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.EdgeConfigWrite => "edgeConfigWrite",
                UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.EdgeFunctionExecutionUnits => "edgeFunctionExecutionUnits",
                UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.EdgeMiddlewareInvocations => "edgeMiddlewareInvocations",
                UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.EdgeRequest => "edgeRequest",
                UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.EdgeRequestAdditionalCpuDuration => "edgeRequestAdditionalCpuDuration",
                UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.ElasticConcurrencyBuildSlots => "elasticConcurrencyBuildSlots",
                UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.FastDataTransfer => "fastDataTransfer",
                UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.FastOriginTransfer => "fastOriginTransfer",
                UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.FluidCpuDuration => "fluidCpuDuration",
                UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.FluidDuration => "fluidDuration",
                UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.FunctionDuration => "functionDuration",
                UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.FunctionInvocation => "functionInvocation",
                UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.ImageOptimizationCacheRead => "imageOptimizationCacheRead",
                UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.ImageOptimizationCacheWrite => "imageOptimizationCacheWrite",
                UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.ImageOptimizationTransformation => "imageOptimizationTransformation",
                UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.LogDrainsVolume => "logDrainsVolume",
                UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.MonitoringMetric => "monitoringMetric",
                UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.ObservabilityEvent => "observabilityEvent",
                UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.OnDemandConcurrencyMinutes => "onDemandConcurrencyMinutes",
                UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.RuntimeCacheRead => "runtimeCacheRead",
                UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.RuntimeCacheWrite => "runtimeCacheWrite",
                UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.ServerlessFunctionExecution => "serverlessFunctionExecution",
                UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.SourceImages => "sourceImages",
                UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.WafOwaspExcessBytes => "wafOwaspExcessBytes",
                UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.WafOwaspRequests => "wafOwaspRequests",
                UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.WafRateLimitRequest => "wafRateLimitRequest",
                UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.WebAnalyticsEvent => "webAnalyticsEvent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType? ToEnum(string value)
        {
            return value switch
            {
                "analyticsUsage" => UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.AnalyticsUsage,
                "artifacts" => UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.Artifacts,
                "bandwidth" => UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.Bandwidth,
                "blobDataTransfer" => UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.BlobDataTransfer,
                "blobTotalAdvancedRequests" => UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.BlobTotalAdvancedRequests,
                "blobTotalAvgSizeInBytes" => UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.BlobTotalAvgSizeInBytes,
                "blobTotalGetResponseObjectSizeInBytes" => UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.BlobTotalGetResponseObjectSizeInBytes,
                "blobTotalSimpleRequests" => UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.BlobTotalSimpleRequests,
                "connectDataTransfer" => UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.ConnectDataTransfer,
                "dataCacheRead" => UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.DataCacheRead,
                "dataCacheWrite" => UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.DataCacheWrite,
                "edgeConfigRead" => UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.EdgeConfigRead,
                "edgeConfigWrite" => UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.EdgeConfigWrite,
                "edgeFunctionExecutionUnits" => UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.EdgeFunctionExecutionUnits,
                "edgeMiddlewareInvocations" => UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.EdgeMiddlewareInvocations,
                "edgeRequest" => UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.EdgeRequest,
                "edgeRequestAdditionalCpuDuration" => UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.EdgeRequestAdditionalCpuDuration,
                "elasticConcurrencyBuildSlots" => UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.ElasticConcurrencyBuildSlots,
                "fastDataTransfer" => UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.FastDataTransfer,
                "fastOriginTransfer" => UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.FastOriginTransfer,
                "fluidCpuDuration" => UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.FluidCpuDuration,
                "fluidDuration" => UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.FluidDuration,
                "functionDuration" => UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.FunctionDuration,
                "functionInvocation" => UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.FunctionInvocation,
                "imageOptimizationCacheRead" => UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.ImageOptimizationCacheRead,
                "imageOptimizationCacheWrite" => UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.ImageOptimizationCacheWrite,
                "imageOptimizationTransformation" => UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.ImageOptimizationTransformation,
                "logDrainsVolume" => UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.LogDrainsVolume,
                "monitoringMetric" => UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.MonitoringMetric,
                "observabilityEvent" => UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.ObservabilityEvent,
                "onDemandConcurrencyMinutes" => UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.OnDemandConcurrencyMinutes,
                "runtimeCacheRead" => UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.RuntimeCacheRead,
                "runtimeCacheWrite" => UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.RuntimeCacheWrite,
                "serverlessFunctionExecution" => UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.ServerlessFunctionExecution,
                "sourceImages" => UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.SourceImages,
                "wafOwaspExcessBytes" => UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.WafOwaspExcessBytes,
                "wafOwaspRequests" => UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.WafOwaspRequests,
                "wafRateLimitRequest" => UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.WafRateLimitRequest,
                "webAnalyticsEvent" => UserEventPayloadVariant122NewOwnerSoftBlockBlockedDueToOverageType.WebAnalyticsEvent,
                _ => null,
            };
        }
    }
}