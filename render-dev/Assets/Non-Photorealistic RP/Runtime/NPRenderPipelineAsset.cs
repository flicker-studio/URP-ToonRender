using UnityEngine;
using UnityEngine.Rendering;

namespace Non_Photorealistic_RP.Runtime
{
    /// <summary>
    ///     Give Unity a way to get a hold of a pipeline object instance that is responsible for rendering.
    /// </summary>
    [CreateAssetMenu(menuName = "Rendering/Non-Photorealistic Render Pipeline")]
    public class NPRenderPipelineAsset : RenderPipelineAsset
    {
        /// <summary>
        ///     Whether to enable dynamic batching
        /// </summary>
        [SerializeField] public bool useDynamicBatching = true;

        /// <summary>
        ///     Whether to enable GPU instancing
        /// </summary>
        [SerializeField] public bool useGPUInstancing = true;

        /// <summary>
        ///     Whether to enable SPR batcher
        /// </summary>
        [SerializeField] public bool useSRPBatcher = true;

        ///<inheritdoc />
        protected override RenderPipeline CreatePipeline()
        {
            return new NPRenderPipeline(useDynamicBatching, useGPUInstancing, useSRPBatcher);
        }
    }
}