Console.Write("Введите число, для которого мы ищем квадрат: ");

int num = Convert.ToInt32(Console.ReadLine()); // Ридлайн читает строчку, необходимо конвертировать в Инт32 (работаем в основном в нем)

int result = num * num;

Console.WriteLine("Квадрат от числа: " + num + " - равен " + result);