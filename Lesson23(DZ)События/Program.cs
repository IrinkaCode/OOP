//Задание: "Симулятор клавиатуры"
//Это практическое задание направлено на создание симулятора клавиатуры с использованием событий в C#. Вам нужно создать класс Keyboard, который имеет событие KeyPressed. После этого вы должны реализовать методы для эмуляции нажатия клавиш клавиатуры и создать обработчик события KeyPressed, который будет выводить информацию о нажатой клавише.

Keyboard keyboard = new Keyboard();
keyboard.KeyPressed += Keyboard_KeyPressedHandler!;

keyboard.SimulateKeyPress('A');
keyboard.SimulateKeyPress('1');
keyboard.SimulateKeyPress('Z');
    
static void Keyboard_KeyPressedHandler(object sender, char key)
{
    Console.WriteLine($"Клавиша '{key}' нажата.");
}