This Unity package contains a First-Person Character Controller with crouching, looking & jumping behaviours preconfigured.
Uses the new input system & rigidbody physics.

At the heart of this package lies the ``VelocityController`` component, which is being driven by the ``WalkingController`` and ``Jump`` components.

The 'FPSController' Prefab is preconfigured with all the necessary components and values.

Requires: https://github.com/Umbrason/UmbrasonsUtils


The VelocityController can be used to overwrite or modify the players movement either in an immediate mode fashion by adding temporary effects each FixedUpdate or by adding a more permanent effect with an expiration condition.

A simple example usage of the VelocityController could look like this:
```cs
[SerializeField] private VelocityController VC;

void FixedUpdate() {
  //'wind-like' effect
  VC.AddLayer(velocity: Vector3.forward, priority: 1, blend: VelocityLayer.BlendMode.Additive);

  //'slowed' effect
  VC.AddLayer(velocity: Vector3.one * .5f, channelMask: VelocityLayer.ChannelMask.XZ, priority: 2, blend: VelocityLayer.BlendMode.Multiplicative);
}
```
Adds a new velocity effect to the VelocityController, that adds a forward velocity to the Z axis and another effect on top of that, which halves all motion on the XZ axis.
