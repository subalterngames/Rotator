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
        transform.rotation.Pitch(45);
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