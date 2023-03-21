// +++++++++++++++++ ЗАДАНИЕ №1 ++++++++++++++++++++++++++++++++++++++
// Console.Write("ВВЕДИТЕ ЧИСЛО (5тизначное) : ");
// String A = Console.ReadLine();
// if ( A.Length != 5 ) {
//     Console.WriteLine("Число содержит не 5 символов");
// }
// else if ( (A[0] == A[4]) && (A[1]==A[3]) ){
//     Console.WriteLine("Число полиндром");
// }
//     else {
//         Console.WriteLine("Число НЕ полиндром");
//     } 

// +++++++++++++++++ ЗАДАНИЕ №2 ++++++++++++++++++++++++++++++++++++++

// Console.WriteLine("Введите координаты первой точки: ");
// Console.Write("Введите координату X1: ");
// Double x1 = Double.Parse(Console.ReadLine()!);
// Console.Write("Введите координату y1: ");
// Double y1 = Double.Parse(Console.ReadLine()!);
// Console.Write("Введите координату z1: ");
// Double z1 = Double.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите координаты второй точки: ");
// Console.Write("Введите координату X2: ");
// Double x2 = Double.Parse(Console.ReadLine()!);
// Console.Write("Введите координату y2: ");
// Double y2 = Double.Parse(Console.ReadLine()!);
// Console.Write("Введите координату z2: ");
// Double z2 = Double.Parse(Console.ReadLine()!);
// Double dist = 0;
// dist = Math.Pow(((Math.Pow(x1-x2, 2))+(Math.Pow(y1-y2, 2))+(Math.Pow(z1-z2, 2))), 0.5);
// Console.WriteLine("расстояние: ");
// Console.WriteLine(dist);

// +++++++++++++++++ ЗАДАНИЕ №3 ++++++++++++++++++++++++++++++++++++++
Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine()!);
for (int i = 1; i <= N; i++ ) {
    Console.Write( $"{Math.Pow(i,3)}, " );
}
