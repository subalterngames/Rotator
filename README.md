# API

**`public class Rotator`**

Rotate a quaternion or object by an angle around an axis.

## Quaternion Extension Methods

Example usage:

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

`Quaternion Pitch (this Quaternion quaternion, float angle)`

Pitch (nod your head "yes") by an angle.

| Name         | Type            | Description                       |
| ------------ | --------------- | --------------------------------- |
| `quaternion` | this Quaternion | The quaternion.                   |
| `angle`      | float           | The angle of rotation in degrees. |

### Quaternion Roll

`Quaternion Roll (this Quaternion quaternion, float angle)`

Roll (put your ear to your shoulder) by an angle.

| Name         | Type            | Description                       |
| ------------ | --------------- | --------------------------------- |
| `quaternion` | this Quaternion | The quaternion.                   |
| `angle`      | float           | The angle of rotation in degrees. |

### Quaternion Yaw

`Quaternion Yaw (this Quaternion quaternion, float angle)`

Yaw (shake your head "no") by an angle.

| Name         | Type            | Description                       |
| ------------ | --------------- | --------------------------------- |
| `quaternion` | this Quaternion | The quaternion.                   |
| `angle`      | float           | The angle of rotation in degrees. |

## Transform Extension Methods

```c#
using SubalternGames;


public class MyClass : MonoBehaviour
{
    private void Start()
    {
        transform.rotation.Pitch(45);
    }
}
```

### void Pitch

`void Pitch (this Transform transform, float angle)`

Pitch (nod your head "yes") by an angle.

| Name | Type | Description |
| --- | --- | --- |
| `transform` | this Transform | The transform. |
| `angle` | float | The angle of rotation in degrees. |

### void Roll

`void Roll (this Transform transform, float angle)`

Roll (put your ear to your shoulder) by an angle.

| Name | Type | Description |
| --- | --- | --- |
| `transform` | this Transform | The transform. |
| `angle` | float | The angle of rotation in degrees. |

### void Yaw

`void Yaw (this Transform transform, float angle)`

Yaw (shake your head "no") by an angle.

| Name | Type | Description |
| --- | --- | --- |
| `transform` | this Transform | The transform. |
| `angle` | float | The angle of rotation in degrees. |