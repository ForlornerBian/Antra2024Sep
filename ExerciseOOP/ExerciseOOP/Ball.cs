namespace ExerciseOOP;

public class Ball
{
    public int Size { get; private set; }
    public Color BallColor { get; private set; }
    private int _throwCount;

    public Ball(int size, Color color)
    {
        Size = size;
        BallColor = color;
        _throwCount = 0;
    }

    public void Pop()
    {
        Size = 0;
    }

    public void Throw()
    {
        if (Size > 0)
        {
            _throwCount++;
        }
    }

    public int GetThrowCount()
    {
        return _throwCount;
    }
}
