using System;
using System.Collections.Generic;
using System.Text;

namespace TraCuuTuDien
{
    class Program
    {
        static Dictionary<string, string> dic = new Dictionary<string, string>();
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                menu();

                Console.WriteLine("Bạn có muốn tiếp tục sử dụng Từ điển không? (c/k)?");
                string str = Console.ReadLine();
                if (str.ToLower().Equals("k"))
                    break;
            }
            Console.WriteLine("Ket thuc su dung Tu dien");
        }

        private static void menu()
        {
            Console.WriteLine("1. Nhập từ mới.");
            Console.WriteLine("2. Sửa từ.");
            Console.WriteLine("3. Tra cứu.");
            Console.WriteLine("4. Xóa từ.");
            Console.WriteLine("Lựa chọn chức năng: ");

            Console.WriteLine();

            int cn = int.Parse(Console.ReadLine());
            try
            {
                switch (cn)
                {
                    case 1:
                        TaoTuMoi();
                        break;
                    case 2:
                        SuaTu();
                        break;
                    case 3:
                        TraTu();
                        break;
                    case 4:
                        XoaTu();
                        break;
                    default:
                        Console.WriteLine("Chức năng không tồn tại");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi chương trình. {ex.Message}");
            }

        }

        private static void XoaTu()
        {
            Console.WriteLine("Nhập vào từ muốn xóa: ");
            string deleteWord = Console.ReadLine().ToLower();

            if (dic.ContainsKey(deleteWord))
            {
                Console.WriteLine($"Bạn có chắc chắn muốn xóa từ {deleteWord}? (c/k)?");
                string str = Console.ReadLine();
                if (str.ToLower().Equals("c"))
                    dic.Remove(deleteWord);
            }
            else
            {
                Console.WriteLine($"Từ [{deleteWord}] không có trong từ điển.");
            }
        }

        private static void TraTu()
        {
            Console.WriteLine("Nhập vào từ muốn tìm kiếm nghĩa tiếng Việt: ");
            string searchWord = Console.ReadLine().ToLower();

            if(dic.ContainsKey(searchWord))
            {
                Console.WriteLine($"Nghĩa của từ [{searchWord}] là {dic[searchWord]}");
            } else
            {
                Console.WriteLine($"Từ [{searchWord}] chưa được cập nhật trong từ điển.");
            }
        }

        private static void SuaTu()
        {
            Console.WriteLine("Nhập từ muốn sửa nghĩa: ");
            string enWord = Console.ReadLine().ToLower();

            if (!dic.ContainsKey(enWord))
                Console.WriteLine($"Không tìm thấy từ [{enWord}]");
            else
            {
                Console.WriteLine("Nhập nghĩa tiếng Việt: ");
                string newViWord = Console.ReadLine();
                dic[enWord] = newViWord;
            }
        }

        private static void TaoTuMoi()
        {
            Console.WriteLine("Nhập vào từ tiếng Anh: ");
            string enWord = Console.ReadLine().ToLower();

            if (dic.ContainsKey(enWord))
                Console.WriteLine($"Từ {enWord} đã tồn tại.");
            else
            {
                Console.WriteLine("Nhập vào nghĩa tiếng Việt");
                string viWord = Console.ReadLine();

                dic.Add(enWord, viWord);
            }
        }
    }
}
