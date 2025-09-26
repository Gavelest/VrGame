We need to add:
VR Origin
GAD Manager
On the plane, add the ChopGame script
Create a 'knife' (a cube, with a rigidbody)
On the knife, add a Draggable
On the knife, add a CollisionDetection script:
	- looking for COLLIDER collisions
	- with Clubs tags
	- call 'ChopGame.ChopCarrot'