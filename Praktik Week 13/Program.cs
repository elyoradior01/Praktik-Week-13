using System;

public class Program
{

	public static void Main()
	{
		Console.WriteLine("Berapa Data: ");
		int jumlah = Convert.ToInt32(Console.ReadLine());
		string[,] data = new string[jumlah, 6];
		string[] nims = new string[jumlah];

		for(int i = 0; i < jumlah; i++)
        {
			Console.WriteLine($"Data ke - {i+1}");
			Console.WriteLine("NIM: ");
			string nim = Console.ReadLine();
            {
				for (int j = 0; j < jumlah; j++)
				{
					if (nim == nims[j])
					{
						Console.WriteLine("NIM SUDAH ADA MASUKKAN NIM LAIN!");
						Console.WriteLine("NIM: ");
						nim = Console.ReadLine();
					}
					nims[j] = nim;
				}
            }
			Console.WriteLine("NAMA: ");
			data[i, 1] = Console.ReadLine();
			Console.WriteLine("JENIS KELAMIN: ");
			data[i, 2] = Console.ReadLine();
			Console.WriteLine("TAHUN MASUK: ");
			data[i, 3] = Console.ReadLine();
			Console.WriteLine("PROGRAM STUDI: ");
			data[i, 4] = Console.ReadLine();
			Console.WriteLine("KELAS: ");
			data[i, 5] = Console.ReadLine();
		}

		Console.WriteLine("PRINT HASIL? (y/n) ");
		string pilih = Convert.ToString(Console.ReadLine());

		if (pilih == "y")
		{
			Console.Clear();


			var coba = new System.Text.StringBuilder();
			coba.Append("No     NIM     NAMA          JENIS KELAMIN     TAHUN MASUK     PROGRAM STUDI      KELAS\n");
			for (int i = 0; i < jumlah; i++)
			{
				coba.Append(String.Format("{0,-7} {1,-8} {2,-11} {3,-18} {4,-15} {5,-18} {6,-5}", (i + 1), nims[i], data[i, 1], data[i, 2], data[i, 3], data[i, 4], data[i, 5] +"\n"));
			}
			Console.WriteLine(coba);

			Console.WriteLine("Tambah Data? (y/n)");
			string choose = Convert.ToString(Console.ReadLine());

			if(choose == "y") // tdk bisa input lebih dr 1 nama lg
            {
				Console.WriteLine("Berapa Data: ");
				jumlah = Convert.ToInt32(Console.ReadLine());
				string[] nimsa = new string[jumlah];

				string[,] datas = new string[jumlah, 6];

				for (int i = 0; i < jumlah; i++)
				{
					Console.WriteLine($"Data ke - {i + 1}");
					Console.WriteLine("NIM: ");
					string nim = Console.ReadLine();
                    {
						for (int j = 0; j < jumlah; j++)
						{
							if (nim == nimsa[j])
							{
								Console.WriteLine("NIM SUDAH ADA MASUKKAN NIM LAIN!");
								Console.WriteLine("NIM: ");
								nim = Console.ReadLine();
							}
							nimsa[j] = nim;
						}
					}
					
					Console.WriteLine("NAMA: ");
					datas[i, 1] = Console.ReadLine();
					Console.WriteLine("JENIS KELAMIN: ");
					datas[i, 2] = Console.ReadLine();
					Console.WriteLine("TAHUN MASUK: ");
					datas[i, 3] = Console.ReadLine();
					Console.WriteLine("PROGRAM STUDI: ");
					datas[i, 4] = Console.ReadLine();
					Console.WriteLine("KELAS: ");
					datas[i, 5] = Console.ReadLine();
				}

				var cobas = new System.Text.StringBuilder();
				
				for (int i = 0; i < jumlah; i++)
				{
					cobas.Append(String.Format("{0,-7} {1,-8} {2,-11} {3,-18} {4,-15} {5,-18} {6,-5}", (i + 1), nimsa[i], datas[i, 1], datas[i, 2], datas[i, 3], datas[i, 4], datas[i, 5] + "\n"));
				}
				Console.Write(coba.Insert(0,cobas));

			}
			else if(choose == "n")
            {
				Environment.Exit(0);
            }
		}
		else if (pilih == "n")
        {
			Environment.Exit(0);
        }

	}

}