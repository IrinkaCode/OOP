public class Keyboard
{
    public event EventHandler<char> KeyPressed;
    public void SimulateKeyPress(char key)
    {
        OnKeyPressed(key);
    }
    protected virtual void OnKeyPressed(char key)
    {
        KeyPressed?.Invoke(this, key);
    }
}