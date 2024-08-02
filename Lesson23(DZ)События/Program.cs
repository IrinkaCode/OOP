using Lesson23_DZ_События;

Keyboard keyboard = new Keyboard();
keyboard.KeyPressed += Keyboard_KeyPressedHandler!;

keyboard.SimulateKeyPress('A');
keyboard.SimulateKeyPress('1');
keyboard.SimulateKeyPress('Z');
    
static void Keyboard_KeyPressedHandler(object sender, char key)
{
    Console.WriteLine($"Клавиша '{key}' нажата.");
}