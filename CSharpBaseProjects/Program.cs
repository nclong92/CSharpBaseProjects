using System;
using System.Linq;
using System.Text;

namespace CSharpBaseProjects
{
    class Program
    {
        //Nhập vào 1 chuỗi, sau đó
        //    1. Đếm xem chuỗi có bao nhiêu in HOA, in thường, số
        //    2. Đếm số khoảng trắng trong chuỗi
        static void XuLyChuoi()
        {
            Console.WriteLine("Chương trình xử lý chuỗi");
            Console.WriteLine("Nhập vào 1 chuỗi bất kỳ: ");
            string chuoiDaNhap = Console.ReadLine();
            char[] chuoiDaNhapArr = chuoiDaNhap.ToCharArray();

            int soKyTuInHoa = 0;
            int soKyTuThuong = 0;
            int soKyTuSo = 0;
            int soKhoangTrang = 0;

            for (int i = 0; i < chuoiDaNhapArr.Length; i++)
            {
                char c = chuoiDaNhapArr[i];
                if (Char.IsUpper(c))
                    soKyTuInHoa++;

                if (Char.IsLower(c))
                    soKyTuThuong++;

                if (Char.IsDigit(c))
                    soKyTuSo++;

                if (Char.IsWhiteSpace(c))
                    soKhoangTrang++;
            }

            Console.WriteLine($"Số ký tự in HOA: {soKyTuInHoa}");
            Console.WriteLine($"Số ký tự thường: {soKyTuThuong}");
            Console.WriteLine($"Số ký tự số: {soKyTuSo}");
            Console.WriteLine($"Số ký tự là khoảng trắng: {soKhoangTrang}");
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine("Hello World!");
            //XuLyChuoi();
            //ToiUuChuoi();
            //Mang1Chieu();
            Mang2Chieu();


            Console.ReadLine();
        }

        /*
         * Khai báo, nhập, xuất mảng 2 chiều
         * 
         */
        private static void Mang2Chieu()
        {
            Console.WriteLine("Mảng 2 chiều.");
            Console.Write("\nNhập vào số dòng: ");
            int soDong = Int32.Parse(Console.ReadLine());

            Console.Write("\nNhập vào số cột: ");
            int soCot = Int32.Parse(Console.ReadLine());

            int[,] M = new int[soDong, soCot];

            Random random = new Random();
            for(int i = 0; i < M.GetLength(0); i++)
            {
                for(int j = 0; j < M.GetLength(1); j++)
                {
                    M[i,j] = random.Next(0, 100);
                }
            }

            Console.WriteLine($"\nMảng 2 chiều ngẫu nhiên với {soDong} dòng và {soCot} là: ");
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    Console.Write(M[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        /*
         * Tạo 1 mảng M có n phần tử, sau đó:
         * 1) Nhập giá trị ngẫu nhiên cho các phần tử trong mảng M
         * 2) Xuất các giá trị trong mảng
         * 3) Đảo ngược mảng
         * 4) Sắp xếp mảng
         * 5) Tính tổng các phần tử trong mảng
         * 6) Tìm kiếm mảng
         */
        private static void Mang1Chieu()
        {
            Console.WriteLine("Tạo mới mảng 1 chiều");
            Console.WriteLine("Nhập số phần tử của mảng: ");
            int n = int.Parse(Console.ReadLine());
            Random random = new Random();
            int[] M = new int[n];

            Console.WriteLine($"\nMảng M có {n} phần tử ngẫu nhiên là:");
            for (int i = 0; i < M.Length; i++)
            {
                M[i] = random.Next(0, 100);
                Console.Write($"{M[i]} \t");
            }

            Console.WriteLine("\n\nMảng M sau khi đảo ngược: ");
            Array.Reverse<int>(M);
            for(int i = 0; i < M.Length; i++)
            {
                Console.Write($"{M[i]} \t");
            }

            Console.WriteLine("\n\nMảng sau khi sắp xếp là: ");
            Array.Sort<int>(M);
            for (int i = 0; i < M.Length; i++)
            {
                Console.Write($"{M[i]} \t");
            }

            int arrSum = 0;
            for (int i = 0; i < M.Length; i++)
            {
                arrSum += M[i];
            }
            Console.WriteLine($"\n\nTổng các phần tử trong mảng là: {arrSum}");

            Console.WriteLine("\n\nNhập vào số muốn tìm kiếm: ");
            int soCanTim = Int16.Parse(Console.ReadLine());

            /*
            int kq = Array.BinarySearch(M, soCanTim);
            if (kq == -1)
                Console.WriteLine($"Không tìm thấy số {soCanTim} trong mảng");
            else
                Console.WriteLine($"Số {soCanTim} được tìm thấy ở vị trí {kq}");
            */
            int kq = -1;
            for(int i = 0; i < M.Length; i++)
            {
                if(M[i] == soCanTim) { 
                    Console.WriteLine($"Số {soCanTim} được tìm thấy ở vị trí {i}");
                    kq = i;
                    break;
                }
            }

            if(kq == -1)
                Console.WriteLine($"Không tìm thấy số {soCanTim} trong mảng");
        }

        /*
        Cho 1 chuỗi gốc, yêu cầu:
            Xóa các khoảng trăng dư thừa bên trái, phải chuỗi, các từ cách nhau bằng 1 khoảng trắng,
            ký tự đầu tiên viết hoa
            ví dụ: Nguyễn công lonG quân
            sau khi tối ưu: Nguyễn Công Long Quân
        */
        private static void ToiUuChuoi()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào 1 tên bất kỳ: ");
            string strInput = Console.ReadLine();
            strInput.Trim();

            // Get Array 
            // arrInput[0]="Nguyễn"
            // arrInput[1]="công"
            // arrInput[2]="lonG"
            // arrInput[3]="quân"
            string[] arrInput = strInput.Split(
                new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            string strOutput = "";

            for (int i = 0; i < arrInput.Length; i++)
            {
                string word = arrInput[i];
                word = word.ToLower();
                char[] wordArr = word.ToCharArray();
                wordArr[0] = char.ToUpper(wordArr[0]);
                string newWord = new string(wordArr);
                strOutput += newWord + " ";
            }

            Console.WriteLine($"Chuỗi ban đầu là: {strInput}");
            Console.WriteLine($"Chuỗi kết quả là: {strOutput}");

        }
    }
}
