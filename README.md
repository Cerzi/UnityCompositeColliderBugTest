# UnityCompositeColliderBugTest
Demonstration of a problem with using Composite Collider + Tilemap Collider.

TriggerExit is called as soon as the moving square is fully inside the tilemap collider, rather than when the square has fully left the tilemap collider's bounds as one would expect.

![demo gif](https://i.imgur.com/R70inl2.gif)

![inspector](https://i.imgur.com/FvJyce1.png)
