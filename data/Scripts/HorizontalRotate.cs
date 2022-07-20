using Unigine;

[Component(PropertyGuid = "1ecb2dec3d18505bdf9249fe1a25e945730a49e0")]
public class HorizontalRotate : Component
{
    [ShowInEditor] private Node _object;

    private void Update()
	{
		_object.Rotate(0, 0, -Input.MouseDelta.x);
	}
}