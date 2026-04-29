
#nullable enable

namespace Vercel
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason
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
    public static class UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason value)
        {
            return value switch
            {
                UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.AnalyticsUsage => "analyticsUsage",
                UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.Artifacts => "artifacts",
                UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.Bandwidth => "bandwidth",
                UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.BlobDataTransfer => "blobDataTransfer",
                UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.BlobTotalAdvancedRequests => "blobTotalAdvancedRequests",
                UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.BlobTotalAvgSizeInBytes => "blobTotalAvgSizeInBytes",
                UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.BlobTotalGetResponseObjectSizeInBytes => "blobTotalGetResponseObjectSizeInBytes",
                UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.BlobTotalSimpleRequests => "blobTotalSimpleRequests",
                UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.ConnectDataTransfer => "connectDataTransfer",
                UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.DataCacheRead => "dataCacheRead",
                UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.DataCacheWrite => "dataCacheWrite",
                UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.EdgeConfigRead => "edgeConfigRead",
                UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.EdgeConfigWrite => "edgeConfigWrite",
                UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.EdgeFunctionExecutionUnits => "edgeFunctionExecutionUnits",
                UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.EdgeMiddlewareInvocations => "edgeMiddlewareInvocations",
                UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.EdgeRequest => "edgeRequest",
                UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.EdgeRequestAdditionalCpuDuration => "edgeRequestAdditionalCpuDuration",
                UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.ElasticConcurrencyBuildSlots => "elasticConcurrencyBuildSlots",
                UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.FastDataTransfer => "fastDataTransfer",
                UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.FastOriginTransfer => "fastOriginTransfer",
                UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.FluidCpuDuration => "fluidCpuDuration",
                UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.FluidDuration => "fluidDuration",
                UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.FunctionDuration => "functionDuration",
                UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.FunctionInvocation => "functionInvocation",
                UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.ImageOptimizationCacheRead => "imageOptimizationCacheRead",
                UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.ImageOptimizationCacheWrite => "imageOptimizationCacheWrite",
                UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.ImageOptimizationTransformation => "imageOptimizationTransformation",
                UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.LogDrainsVolume => "logDrainsVolume",
                UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.MonitoringMetric => "monitoringMetric",
                UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.ObservabilityEvent => "observabilityEvent",
                UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.OnDemandConcurrencyMinutes => "onDemandConcurrencyMinutes",
                UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.RuntimeCacheRead => "runtimeCacheRead",
                UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.RuntimeCacheWrite => "runtimeCacheWrite",
                UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.ServerlessFunctionExecution => "serverlessFunctionExecution",
                UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.SourceImages => "sourceImages",
                UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.WafOwaspExcessBytes => "wafOwaspExcessBytes",
                UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.WafOwaspRequests => "wafOwaspRequests",
                UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.WafRateLimitRequest => "wafRateLimitRequest",
                UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.WebAnalyticsEvent => "webAnalyticsEvent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason? ToEnum(string value)
        {
            return value switch
            {
                "analyticsUsage" => UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.AnalyticsUsage,
                "artifacts" => UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.Artifacts,
                "bandwidth" => UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.Bandwidth,
                "blobDataTransfer" => UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.BlobDataTransfer,
                "blobTotalAdvancedRequests" => UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.BlobTotalAdvancedRequests,
                "blobTotalAvgSizeInBytes" => UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.BlobTotalAvgSizeInBytes,
                "blobTotalGetResponseObjectSizeInBytes" => UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.BlobTotalGetResponseObjectSizeInBytes,
                "blobTotalSimpleRequests" => UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.BlobTotalSimpleRequests,
                "connectDataTransfer" => UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.ConnectDataTransfer,
                "dataCacheRead" => UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.DataCacheRead,
                "dataCacheWrite" => UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.DataCacheWrite,
                "edgeConfigRead" => UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.EdgeConfigRead,
                "edgeConfigWrite" => UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.EdgeConfigWrite,
                "edgeFunctionExecutionUnits" => UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.EdgeFunctionExecutionUnits,
                "edgeMiddlewareInvocations" => UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.EdgeMiddlewareInvocations,
                "edgeRequest" => UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.EdgeRequest,
                "edgeRequestAdditionalCpuDuration" => UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.EdgeRequestAdditionalCpuDuration,
                "elasticConcurrencyBuildSlots" => UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.ElasticConcurrencyBuildSlots,
                "fastDataTransfer" => UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.FastDataTransfer,
                "fastOriginTransfer" => UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.FastOriginTransfer,
                "fluidCpuDuration" => UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.FluidCpuDuration,
                "fluidDuration" => UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.FluidDuration,
                "functionDuration" => UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.FunctionDuration,
                "functionInvocation" => UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.FunctionInvocation,
                "imageOptimizationCacheRead" => UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.ImageOptimizationCacheRead,
                "imageOptimizationCacheWrite" => UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.ImageOptimizationCacheWrite,
                "imageOptimizationTransformation" => UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.ImageOptimizationTransformation,
                "logDrainsVolume" => UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.LogDrainsVolume,
                "monitoringMetric" => UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.MonitoringMetric,
                "observabilityEvent" => UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.ObservabilityEvent,
                "onDemandConcurrencyMinutes" => UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.OnDemandConcurrencyMinutes,
                "runtimeCacheRead" => UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.RuntimeCacheRead,
                "runtimeCacheWrite" => UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.RuntimeCacheWrite,
                "serverlessFunctionExecution" => UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.ServerlessFunctionExecution,
                "sourceImages" => UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.SourceImages,
                "wafOwaspExcessBytes" => UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.WafOwaspExcessBytes,
                "wafOwaspRequests" => UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.WafOwaspRequests,
                "wafRateLimitRequest" => UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.WafRateLimitRequest,
                "webAnalyticsEvent" => UserEventPayloadVariant122NewOwnerFeatureBlocksRedisVariant1OverageReason.WebAnalyticsEvent,
                _ => null,
            };
        }
    }
}