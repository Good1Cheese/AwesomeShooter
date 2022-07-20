using Unigine;

[Component(PropertyGuid = "221da2eaafb375411c9ccdac4023ed1bf65dbfbe")]
public class VerticalRotate : Component
{
    [ShowInEditor] private Node _object;

    [ShowInEditor] private float _min;
    [ShowInEditor] private float _max;

    private float _rotation;
    private vec3 _cameraRotation;

    private void Update()
    {
        _rotation -= Input.MouseDelta.y;
        _rotation = MathLib.Clamp(_rotation, _min, _max);

        RotateCamera();
    }

    private void RotateCamera()
    {
        quat cameraRotation = _object.GetRotation();

        _cameraRotation.x = _rotation;
        cameraRotation.Euler = _cameraRotation;

        _object.SetRotation(cameraRotation);
    }
}