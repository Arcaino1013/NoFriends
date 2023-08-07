using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[Serializable, VolumeComponentMenuForRenderPipeline("CustomVolumes/CustomScreenTint", typeof(UniversalRenderPipeline))]
public class CustomPostScreenTint : VolumeComponent, IPostProcessComponent
{
    public FloatParameter tinIntensity = new FloatParameter(1);
    public ColorParameter tintColor = new ColorParameter(Color.white); 
    public bool IsActive()
    {
        throw new NotImplementedException();
    }

    public bool IsTileCompatible()
    {
        throw new NotImplementedException();
    }
}
