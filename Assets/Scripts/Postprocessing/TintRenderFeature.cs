using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;


public class TintRenderFeature : ScriptableRendererFeature
{

    private TintPass tintPass;

    public override void Create()
    {
        tintPass = new TintPass();
    }

    public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
    {
        renderer.EnqueuePass(tintPass);
    }

    class TintPass : ScriptableRenderPass
    {


        public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
        {
            throw new System.NotImplementedException();
        }
    }
}
