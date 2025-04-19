using System;
internal class Program
{
    private static void Main(string[] args)//LAP1
    {
        int choice;
        do
        {
            Console.WriteLine("\n==== MENU ====");
            Console.WriteLine("1. Nhập tên và tuổi, in lời chào");
            Console.WriteLine("2. Tính diện tích hình chữ nhật");
            Console.WriteLine("3. Chuyển đổi độ C sang độ F");
            Console.WriteLine("4. Kiểm tra số chẵn hay lẻ");
            Console.WriteLine("5. Tính tổng và tích của hai số");
            Console.WriteLine("6. Kiểm tra số âm, dương hay không");
            Console.WriteLine("7. Kiểm tra năm nhuận");
            Console.WriteLine("8. In bảng cửu chương từ 1 đến 10");
            Console.WriteLine("9. Tính giai thừa");
            Console.WriteLine("10. Kiểm tra số nguyên tố");
            Console.WriteLine("0. Thoát");
            Console.Write("Chọn chức năng (0-10): ");

            choice = int.Parse(Console.ReadLine());

            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    Console.Write("Nhập tên: ");
                    string ten = Console.ReadLine();
                    Console.Write("Nhập tuổi: ");
                    int tuoi = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Xin chào {ten}, bạn {tuoi} tuổi!");
                    break;

                case 2:
                    Console.Write("Nhập chiều dài: ");
                    double dai = double.Parse(Console.ReadLine());
                    Console.Write("Nhập chiều rộng: ");
                    double rong = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Diện tích: {dai * rong}");
                    break;

                case 3:
                    Console.Write("Nhập nhiệt độ (°C): ");
                    double c = double.Parse(Console.ReadLine());
                    double f = (c * 9 / 5) + 32;
                    Console.WriteLine($"Nhiệt độ (°F): {f}");
                    break;

                case 4:
                    Console.Write("Nhập số nguyên: ");
                    int n = int.Parse(Console.ReadLine());
                    Console.WriteLine(n % 2 == 0 ? $"{n} là số chẵn" : $"{n} là số lẻ");
                    break;

                case 5:
                    Console.Write("Nhập số thứ nhất: ");
                    double a = double.Parse(Console.ReadLine());
                    Console.Write("Nhập số thứ hai: ");
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Tổng: {a + b}");
                    Console.WriteLine($"Tích: {a * b}");
                    break;

                case 6:
                    Console.Write("Nhập một số: ");
                    double so = double.Parse(Console.ReadLine());
                    if (so > 0)
                        Console.WriteLine("Đây là số dương.");
                    else if (so < 0)
                        Console.WriteLine("Đây là số âm.");
                    else
                        Console.WriteLine("Đây là số không.");
                    break;

                case 7:
                    Console.Write("Nhập năm: ");
                    int nam = int.Parse(Console.ReadLine());
                    if ((nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0))
                        Console.WriteLine($"{nam} là năm nhuận.");
                    else
                        Console.WriteLine($"{nam} không phải là năm nhuận.");
                    break;

                case 8:
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine($"\nBảng cửu chương {i}:");
                        for (int j = 1; j <= 10; j++)
                        {
                            Console.WriteLine($"{i} x {j} = {i * j}");
                        }
                    }
                    break;

                case 9:
                    Console.Write("Nhập số nguyên dương: ");
                    int num = int.Parse(Console.ReadLine());
                    long gt = 1;
                    for (int i = 1; i <= num; i++)
                        gt *= i;
                    Console.WriteLine($"Giai thừa của {num} là {gt}");
                    break;

                case 10:
                    Console.Write("Nhập số nguyên: ");
                    int soNguyen = int.Parse(Console.ReadLine());
                    if (soNguyen < 2)
                    {
                        Console.WriteLine($"{soNguyen} không phải là số nguyên tố.");
                    }
                    else
                    {
                        bool isPrime = true;
                        for (int i = 2; i <= Math.Sqrt(soNguyen); i++)
                        {
                            if (soNguyen % i == 0)
                            {
                                isPrime = false;
                                break;
                            }
                        }
                        Console.WriteLine(isPrime ? $"{soNguyen} là số nguyên tố." : $"{soNguyen} không phải là số nguyên tố.");
                    }
                    break;

                case 0:
                    Console.WriteLine("Đã thoát chương trình.");
                    break;

                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn từ 0 đến 10.");
                    break;
            }

            Console.WriteLine("\n------------------------\n");

        } while (choice != 0);
    }
}
