using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[DefaultExecutionOrder(100)]
public class VelocityController : MonoBehaviour
{
    Cached<Rigidbody> CachedRB;
    Rigidbody RB => CachedRB[this];

    private readonly List<VelocityLayer> layers = new();
    public Vector3 Velocity => RB.velocity;

    public void AddLayer(int priority = 0, float opacity = 1, Vector3 velocity = default, VelocityLayer.BlendMode blend = VelocityLayer.BlendMode.Blend, VelocityLayer.ChannelMask channelMask = VelocityLayer.ChannelMask.XYZ)
    => layers.Add(new(priority, opacity, velocity, blend, channelMask));
    public void AddLayer(int priority = 0, Func<float> opacity = null, Func<Vector3> velocity = null, Func<bool> keep = null, VelocityLayer.BlendMode blend = VelocityLayer.BlendMode.Blend, VelocityLayer.ChannelMask channelMask = VelocityLayer.ChannelMask.XYZ)
    => layers.Add(new(priority, opacity ?? (() => 1), velocity ?? (() => default), keep ?? (() => false), blend, channelMask));
    public void AddLayer(VelocityLayer layer)
    => layers.Add(layer);

    void FixedUpdate()
    {
        var byPrio = layers.OrderBy(layer => layer.priority);
        var vel = RB.velocity;
        foreach (var layer in byPrio)
            vel = layer.Apply(vel);
        RB.velocity = vel;
        layers.RemoveAll(layer => !(layer.keep?.Invoke() ?? false));
    }
}

public struct VelocityLayer
{
    public int priority;
    public Func<float> opacity;
    public Func<Vector3> velocity;
    public Func<bool> keep;
    public BlendMode blendMode;
    public ChannelMask channelMask;

    public enum ChannelMask
    {
        X = 0b100,
        Y = 0b010,
        Z = 0b001,
        XY = 0b110,
        YZ = 0b011,
        XZ = 0b101,
        XYZ = 0b111,
    }

    private readonly float Opacity => opacity?.Invoke() ?? 1f;
    private readonly Vector3 Velocity => velocity?.Invoke() ?? default;


    public Vector3 Apply(Vector3 velocity)
    {
        var blendedVelocity = blendMode switch
        {
            BlendMode.Additive => velocity + Velocity * Opacity,
            BlendMode.Multiplicative => Vector3.Lerp(velocity, Vector3.Scale(velocity, Velocity), Opacity),
            BlendMode.Blend => Vector3.Lerp(velocity, Velocity, Opacity),
            _ => velocity,
        };

        var channelMaskVector = new Vector3((channelMask & ChannelMask.X) != 0 ? 1f : 0f,
                                            (channelMask & ChannelMask.Y) != 0 ? 1f : 0f,
                                            (channelMask & ChannelMask.Z) != 0 ? 1f : 0f);
        var inverseChannelMaskVector = Vector3.one - channelMaskVector;
        return Vector3.Scale(inverseChannelMaskVector, velocity) + Vector3.Scale(channelMaskVector, blendedVelocity);
    }

    public VelocityLayer(int priority, float opacity, Vector3 velocity, BlendMode blendMode, ChannelMask channelMask) : this(priority, () => opacity, () => velocity, () => false, blendMode, channelMask) { }
    public VelocityLayer(int priority, Func<float> opacity, Func<Vector3> velocity, Func<bool> keep, BlendMode blendMode, ChannelMask channelMask)
    {
        this.priority = priority;
        this.opacity = opacity;
        this.velocity = velocity;
        this.keep = keep;
        this.blendMode = blendMode;
        this.channelMask = channelMask;
    }

    public enum BlendMode
    {
        Additive,
        Multiplicative,
        Blend
    }

    public readonly VelocityLayer WithPriority(int priority) => new()
    {
        priority = priority,
        opacity = opacity,
        velocity = velocity,
        keep = keep,
        blendMode = blendMode,
        channelMask = channelMask,
    };

    public readonly VelocityLayer WithOpacity(float opacity) => WithOpacity(() => opacity);
    public readonly VelocityLayer WithOpacity(Func<float> opacity) => new()
    {
        priority = priority,
        opacity = opacity,
        velocity = velocity,
        keep = keep,
        blendMode = blendMode,
        channelMask = channelMask,
    };

    public readonly VelocityLayer WithVelocity(Vector3 velocity) => WithVelocity(() => velocity);
    public readonly VelocityLayer WithVelocity(Func<Vector3> velocity) => new()
    {
        priority = priority,
        opacity = opacity,
        velocity = velocity,
        keep = keep,
        blendMode = blendMode,
        channelMask = channelMask,
    };

    public readonly VelocityLayer WithKeep(bool keep) => WithKeep(() => keep);
    public readonly VelocityLayer WithKeep(Func<bool> keep) => new()
    {
        priority = priority,
        opacity = opacity,
        velocity = velocity,
        keep = keep,
        blendMode = blendMode,
        channelMask = channelMask,
    };

    public readonly VelocityLayer WithBlendMode(BlendMode blendMode) => new()
    {
        priority = priority,
        opacity = opacity,
        velocity = velocity,
        keep = keep,
        blendMode = blendMode,
        channelMask = channelMask,
    };

    public readonly VelocityLayer WithChannelMask(ChannelMask channelMask) => new()
    {
        priority = priority,
        opacity = opacity,
        velocity = velocity,
        keep = keep,
        blendMode = blendMode,
        channelMask = channelMask,
    };


}