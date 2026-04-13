
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType
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
    public static class UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType value)
        {
            return value switch
            {
                UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.AnalyticsUsage => "analyticsUsage",
                UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.Artifacts => "artifacts",
                UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.Bandwidth => "bandwidth",
                UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.BlobDataTransfer => "blobDataTransfer",
                UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.BlobTotalAdvancedRequests => "blobTotalAdvancedRequests",
                UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.BlobTotalAvgSizeInBytes => "blobTotalAvgSizeInBytes",
                UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.BlobTotalGetResponseObjectSizeInBytes => "blobTotalGetResponseObjectSizeInBytes",
                UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.BlobTotalSimpleRequests => "blobTotalSimpleRequests",
                UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.ConnectDataTransfer => "connectDataTransfer",
                UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.DataCacheRead => "dataCacheRead",
                UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.DataCacheWrite => "dataCacheWrite",
                UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.EdgeConfigRead => "edgeConfigRead",
                UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.EdgeConfigWrite => "edgeConfigWrite",
                UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.EdgeFunctionExecutionUnits => "edgeFunctionExecutionUnits",
                UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.EdgeMiddlewareInvocations => "edgeMiddlewareInvocations",
                UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.EdgeRequest => "edgeRequest",
                UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.EdgeRequestAdditionalCpuDuration => "edgeRequestAdditionalCpuDuration",
                UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.ElasticConcurrencyBuildSlots => "elasticConcurrencyBuildSlots",
                UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.FastDataTransfer => "fastDataTransfer",
                UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.FastOriginTransfer => "fastOriginTransfer",
                UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.FluidCpuDuration => "fluidCpuDuration",
                UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.FluidDuration => "fluidDuration",
                UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.FunctionDuration => "functionDuration",
                UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.FunctionInvocation => "functionInvocation",
                UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.ImageOptimizationCacheRead => "imageOptimizationCacheRead",
                UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.ImageOptimizationCacheWrite => "imageOptimizationCacheWrite",
                UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.ImageOptimizationTransformation => "imageOptimizationTransformation",
                UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.LogDrainsVolume => "logDrainsVolume",
                UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.MonitoringMetric => "monitoringMetric",
                UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.ObservabilityEvent => "observabilityEvent",
                UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.OnDemandConcurrencyMinutes => "onDemandConcurrencyMinutes",
                UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.RuntimeCacheRead => "runtimeCacheRead",
                UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.RuntimeCacheWrite => "runtimeCacheWrite",
                UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.ServerlessFunctionExecution => "serverlessFunctionExecution",
                UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.SourceImages => "sourceImages",
                UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.WafOwaspExcessBytes => "wafOwaspExcessBytes",
                UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.WafOwaspRequests => "wafOwaspRequests",
                UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.WafRateLimitRequest => "wafRateLimitRequest",
                UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.WebAnalyticsEvent => "webAnalyticsEvent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType? ToEnum(string value)
        {
            return value switch
            {
                "analyticsUsage" => UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.AnalyticsUsage,
                "artifacts" => UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.Artifacts,
                "bandwidth" => UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.Bandwidth,
                "blobDataTransfer" => UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.BlobDataTransfer,
                "blobTotalAdvancedRequests" => UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.BlobTotalAdvancedRequests,
                "blobTotalAvgSizeInBytes" => UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.BlobTotalAvgSizeInBytes,
                "blobTotalGetResponseObjectSizeInBytes" => UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.BlobTotalGetResponseObjectSizeInBytes,
                "blobTotalSimpleRequests" => UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.BlobTotalSimpleRequests,
                "connectDataTransfer" => UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.ConnectDataTransfer,
                "dataCacheRead" => UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.DataCacheRead,
                "dataCacheWrite" => UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.DataCacheWrite,
                "edgeConfigRead" => UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.EdgeConfigRead,
                "edgeConfigWrite" => UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.EdgeConfigWrite,
                "edgeFunctionExecutionUnits" => UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.EdgeFunctionExecutionUnits,
                "edgeMiddlewareInvocations" => UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.EdgeMiddlewareInvocations,
                "edgeRequest" => UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.EdgeRequest,
                "edgeRequestAdditionalCpuDuration" => UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.EdgeRequestAdditionalCpuDuration,
                "elasticConcurrencyBuildSlots" => UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.ElasticConcurrencyBuildSlots,
                "fastDataTransfer" => UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.FastDataTransfer,
                "fastOriginTransfer" => UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.FastOriginTransfer,
                "fluidCpuDuration" => UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.FluidCpuDuration,
                "fluidDuration" => UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.FluidDuration,
                "functionDuration" => UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.FunctionDuration,
                "functionInvocation" => UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.FunctionInvocation,
                "imageOptimizationCacheRead" => UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.ImageOptimizationCacheRead,
                "imageOptimizationCacheWrite" => UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.ImageOptimizationCacheWrite,
                "imageOptimizationTransformation" => UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.ImageOptimizationTransformation,
                "logDrainsVolume" => UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.LogDrainsVolume,
                "monitoringMetric" => UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.MonitoringMetric,
                "observabilityEvent" => UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.ObservabilityEvent,
                "onDemandConcurrencyMinutes" => UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.OnDemandConcurrencyMinutes,
                "runtimeCacheRead" => UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.RuntimeCacheRead,
                "runtimeCacheWrite" => UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.RuntimeCacheWrite,
                "serverlessFunctionExecution" => UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.ServerlessFunctionExecution,
                "sourceImages" => UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.SourceImages,
                "wafOwaspExcessBytes" => UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.WafOwaspExcessBytes,
                "wafOwaspRequests" => UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.WafOwaspRequests,
                "wafRateLimitRequest" => UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.WafRateLimitRequest,
                "webAnalyticsEvent" => UserEventPayloadVariant116NewOwnerSoftBlockBlockedDueToOverageType.WebAnalyticsEvent,
                _ => null,
            };
        }
    }
}