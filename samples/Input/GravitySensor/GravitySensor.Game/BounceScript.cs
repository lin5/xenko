// Copyright (c) Xenko contributors (https://xenko.com) and Silicon Studio Corp. (https://www.siliconstudio.co.jp)
// Distributed under the MIT license. See the LICENSE.md file in the project root for more information.
using Xenko.Engine;

namespace GravitySensor
{
    /// <summary>
    /// This script will set the restitution of each rigidbody element to 1.0f to allow the entity to bounce
    /// </summary>
    public class BounceScript : StartupScript
    {
        public override void Start()
        {
            foreach (var physicsElement in Entity.GetAll<PhysicsComponent>())
            {
                physicsElement.Restitution = 0.9f;
            }
        }
    }
}
