# Rotator

`Rotator` adds "extension" methods to `Transform` and `Quaternion` to make quaternion rotation both accurate and intuitive.

### Setup

You can add `Rotator` to your project in one of two ways:

1. Import `Rotator.unitypackage`. You'll get:
    - `Rotator.cs`
    - Example code
    - Example scene
2. Add `Rotator.cs` to your project. 

### The Problem

In Unity3D, there are two ways to rotate objects:

1. **Use Euler angles**  `(x, y, z)`. While at first this might seem highly intuitive, as soon as you rotate around any axis more than 180 degrees, it is possible to achieve [gimbal lock](https://www.youtube.com/watch?v=zc8b2Jo7mno). Gimbal lock is unavoidable, and the resulting Euler angles won't be useful.

```c#
// This might flip the object the wrong way. Or not! Who knows!
transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, 
                                         transform.localEulerAngles.y + 185, 
                                         transform.localEulerAngles.z);
```

2. **Use Quaternions** `(x, y, z, w)`. Quaternions are the only accurate way to describe a rotation. But since fourth-dimensional structures with three real axes and one imaginary axis... they're not the easiest to work with.

```c#
// Good luck guessing what any of this actually means.
transform.rotation = new Quaternion(25, -30, 0.5f, 2.7f);
```

### The Solution

**`Rotator` is both accurate _and_ intuitive.** It's accurate because under the hood, it's still using quaternions. It's intuitive because by clamping the rotation to one axis at a time, it's possible to imagine the expected result.

```c#
// Rotate the object "up" by 30 degrees.
transform.Pitch(30);
```

# API

**`public class Rotator`**

Rotate a quaternion or object by an angle around an axis.

## Quaternion Extension Methods

```c#
using SubalternGames;


public class MyClass : MonoBehaviour
{
    private void Start()
    {
        transform.rotation = transform.rotation.Pitch(45);
    }
}
```

### Quaternion Pitch

`Quaternion Pitch (float angle)`

Pitch (nod your head "yes") by an angle.

| Name    | Type  | Description                       |
| ------- | ----- | --------------------------------- |
| `angle` | float | The angle of rotation in degrees. |

### Quaternion Roll

`Quaternion Roll (float angle)`

Roll (put your ear to your shoulder) by an angle.

| Name    | Type  | Description                       |
| ------- | ----- | --------------------------------- |
| `angle` | float | The angle of rotation in degrees. |

### Quaternion Yaw

`Quaternion Yaw (float angle)`

Yaw (shake your head "no") by an angle.

| Name    | Type  | Description                       |
| ------- | ----- | --------------------------------- |
| `angle` | float | The angle of rotation in degrees. |

## Transform Extension Methods

```c#
using SubalternGames;


public class MyClass : MonoBehaviour
{
    private void Start()
    {
        transform.Pitch(45);
    }
}
```

### void Pitch

`void Pitch (float angle)`

Pitch (nod your head "yes") by an angle.

| Name | Type | Description |
| --- | --- | --- |
| `angle` | float | The angle of rotation in degrees. |

### void Roll

`void Roll (float angle)`

Roll (put your ear to your shoulder) by an angle.

| Name | Type | Description |
| --- | --- | --- |
| `angle` | float | The angle of rotation in degrees. |

### void Yaw

`void Yaw (float angle)`

Yaw (shake your head "no") by an angle.

| Name | Type | Description |
| --- | --- | --- |
| `angle` | float | The angle of rotation in degrees. |
