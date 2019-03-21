using UnityEngine;
using System.Collections;
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.IO;

public class KMeans : MonoBehaviour 
{
	public static double[] X = new double[142];
	public static double[] Y = new double[142];
	public static double[] Z = new double[142];
	public static List<int> kume1 = new List<int>();
	public static List<int> kume2 = new List<int>();
	public static List<int> kume3 = new List<int>();
	public static List<int> kume4 = new List<int>();
	public static List<int> kume5 = new List<int>();
	
	void Start ()
	{
		List<String> Merkezler = new List<String>();
		#region
		Merkezler.Add("CD5C5C");
		Merkezler.Add("F08080");
		Merkezler.Add("FA8072");
		Merkezler.Add("E9967A");
		Merkezler.Add("FFA07A");
		Merkezler.Add("DC143C");
		Merkezler.Add("FF0000");
		Merkezler.Add("B22222");
		Merkezler.Add("8B0000");
		Merkezler.Add("FFC0CB");
		Merkezler.Add("FFB6C1");
		Merkezler.Add("FF69B4");
		Merkezler.Add("FF1493");
		Merkezler.Add("C71585");
		Merkezler.Add("DB7093");
		Merkezler.Add("ADFF2F");
		Merkezler.Add("7FFF00");
		Merkezler.Add("7CFC00");
		Merkezler.Add("00FF00");
		Merkezler.Add("32CD32");
		Merkezler.Add("98FB98");
		Merkezler.Add("90EE90");
		Merkezler.Add("00FA9A");
		Merkezler.Add("00FF7F");
		Merkezler.Add("3CB371");
		Merkezler.Add("2E8B57");
		Merkezler.Add("228B22");
		Merkezler.Add("008000");
		Merkezler.Add("006400");
		Merkezler.Add("9ACD32");
		Merkezler.Add("6B8E23");
		Merkezler.Add("808000");
		Merkezler.Add("556B2F");
		Merkezler.Add("66CDAA");
		Merkezler.Add("8FBC8F");
		Merkezler.Add("20B2AA");
		Merkezler.Add("008B8B");
		Merkezler.Add("008080");
		Merkezler.Add("FFA07A");
		Merkezler.Add("FF7F50");
		Merkezler.Add("FF6347");
		Merkezler.Add("FF4500");
		Merkezler.Add("FF8C00");
		Merkezler.Add("FFA500");
		Merkezler.Add("FFD700");
		Merkezler.Add("FFFF00");
		Merkezler.Add("FFFFE0");
		Merkezler.Add("FFFACD");
		Merkezler.Add("FAFAD2");
		Merkezler.Add("FFEFD5");
		Merkezler.Add("FFE4B5");
		Merkezler.Add("FFDAB9");
		Merkezler.Add("EEE8AA");
		Merkezler.Add("F0E68C");
		Merkezler.Add("BDB76B");
		Merkezler.Add("00FFFF");
		Merkezler.Add("00FFFF");
		Merkezler.Add("E0FFFF");
		Merkezler.Add("AFEEEE");
		Merkezler.Add("7FFFD4");
		Merkezler.Add("40E0D0");
		Merkezler.Add("48D1CC");
		Merkezler.Add("00CED1");
		Merkezler.Add("5F9EA0");
		Merkezler.Add("4682B4");
		Merkezler.Add("B0C4DE");
		Merkezler.Add("B0E0E6");
		Merkezler.Add("ADD8E6");
		Merkezler.Add("87CEEB");
		Merkezler.Add("87CEFA");
		Merkezler.Add("00BFFF");
		Merkezler.Add("1E90FF");
		Merkezler.Add("6495ED");
		Merkezler.Add("7B68EE");
		Merkezler.Add("4169E1");
		Merkezler.Add("0000FF");
		Merkezler.Add("0000CD");
		Merkezler.Add("00008B");
		Merkezler.Add("000080");
		Merkezler.Add("191970");
		Merkezler.Add("E6E6FA");
		Merkezler.Add("D8BFD8");
		Merkezler.Add("DDA0DD");
		Merkezler.Add("EE82EE");
		Merkezler.Add("DA70D6");
		Merkezler.Add("FF00FF");
		Merkezler.Add("FF00FF");
		Merkezler.Add("BA55D3");
		Merkezler.Add("9370DB");
		Merkezler.Add("8A2BE2");
		Merkezler.Add("9400D3");
		Merkezler.Add("9932CC");
		Merkezler.Add("8B008B");
		Merkezler.Add("800080");
		Merkezler.Add("4B0082");
		Merkezler.Add("6A5ACD");
		Merkezler.Add("483D8B");
		Merkezler.Add("FFF8DC");
		Merkezler.Add("FFEBCD");
		Merkezler.Add("FFE4C4");
		Merkezler.Add("FFDEAD");
		Merkezler.Add("F5DEB3");
		Merkezler.Add("DEB887");
		Merkezler.Add("D2B48C");
		Merkezler.Add("BC8F8F");
		Merkezler.Add("F4A460");
		Merkezler.Add("DAA520");
		Merkezler.Add("B8860B");
		Merkezler.Add("CD853F");
		Merkezler.Add("D2691E");
		Merkezler.Add("8B4513");
		Merkezler.Add("A0522D");
		Merkezler.Add("A52A2A");
		Merkezler.Add("800000");
		Merkezler.Add("FFFFFF");
		Merkezler.Add("FFFAFA");
		Merkezler.Add("F0FFF0");
		Merkezler.Add("F5FFFA");
		Merkezler.Add("F0FFFF");
		Merkezler.Add("F0F8FF");
		Merkezler.Add("F8F8FF");
		Merkezler.Add("F5F5F5");
		Merkezler.Add("FFF5EE");
		Merkezler.Add("F5F5DC");
		Merkezler.Add("FDF5E6");
		Merkezler.Add("FFFAF0");
		Merkezler.Add("FFFFF0");
		Merkezler.Add("FAEBD7");
		Merkezler.Add("FAF0E6");
		Merkezler.Add("FFF0F5");
		Merkezler.Add("FFE4E1");
		Merkezler.Add("DCDCDC");
		Merkezler.Add("D3D3D3");
		Merkezler.Add("C0C0C0");
		Merkezler.Add("A9A9A9");
		Merkezler.Add("808080");
		Merkezler.Add("696969");
		Merkezler.Add("778899");
		Merkezler.Add("708090");
		Merkezler.Add("2F4F4F");
		Merkezler.Add("000000");
		Merkezler.Add("000000");
		#endregion
		
		List<String> Renkler = new List<String>();
		#region
		Renkler.Add("CD 5C 5C");
		Renkler.Add("F0 80 80");
		Renkler.Add("FA 80 72");
		Renkler.Add("E9 96 7A");
		Renkler.Add("FF A0 7A");
		Renkler.Add("DC 14 3C");
		Renkler.Add("FF 00 00");
		Renkler.Add("B2 22 22");
		Renkler.Add("8B 00 00");
		Renkler.Add("FF C0 CB");
		Renkler.Add("FF B6 C1");
		Renkler.Add("FF 69 B4");
		Renkler.Add("FF 14 93");
		Renkler.Add("C7 15 85");
		Renkler.Add("DB 70 93");
		Renkler.Add("AD FF 2F");
		Renkler.Add("7F FF 00");
		Renkler.Add("7C FC 00");
		Renkler.Add("00 FF 00");
		Renkler.Add("32 CD 32");
		Renkler.Add("98 FB 98");
		Renkler.Add("90 EE 90");
		Renkler.Add("00 FA 9A");
		Renkler.Add("00 FF 7F");
		Renkler.Add("3C B3 71");
		Renkler.Add("2E 8B 57");
		Renkler.Add("22 8B 22");
		Renkler.Add("00 80 00");
		Renkler.Add("00 64 00");
		Renkler.Add("9A CD 32");
		Renkler.Add("6B 8E 23");
		Renkler.Add("80 80 00");
		Renkler.Add("55 6B 2F");
		Renkler.Add("66 CD AA");
		Renkler.Add("8F BC 8F");
		Renkler.Add("20 B2 AA");
		Renkler.Add("00 8B 8B");
		Renkler.Add("00 80 80");
		Renkler.Add("FF A0 7A");
		Renkler.Add("FF 7F 50");
		Renkler.Add("FF 63 47");
		Renkler.Add("FF 45 00");
		Renkler.Add("FF 8C 00");
		Renkler.Add("FF A5 00");
		Renkler.Add("FF D7 00");
		Renkler.Add("FF FF 00");
		Renkler.Add("FF FF E0");
		Renkler.Add("FF FA CD");
		Renkler.Add("FA FA D2");
		Renkler.Add("FF EF D5");
		Renkler.Add("FF E4 B5");
		Renkler.Add("FF DA B9");
		Renkler.Add("EE E8 AA");
		Renkler.Add("F0 E6 8C");
		Renkler.Add("BD B7 6B");
		Renkler.Add("00 FF FF");
		Renkler.Add("00 FF FF");
		Renkler.Add("E0 FF FF");
		Renkler.Add("AF EE EE");
		Renkler.Add("7F FF D4");
		Renkler.Add("40 E0 D0");
		Renkler.Add("48 D1 CC");
		Renkler.Add("00 CE D1");
		Renkler.Add("5F 9E A0");
		Renkler.Add("46 82 B4");
		Renkler.Add("B0 C4 DE");
		Renkler.Add("B0 E0 E6");
		Renkler.Add("AD D8 E6");
		Renkler.Add("87 CE EB");
		Renkler.Add("87 CE FA");
		Renkler.Add("00 BF FF");
		Renkler.Add("1E 90 FF");
		Renkler.Add("64 95 ED");
		Renkler.Add("7B 68 EE");
		Renkler.Add("41 69 E1");
		Renkler.Add("00 00 FF");
		Renkler.Add("00 00 CD");
		Renkler.Add("00 00 8B");
		Renkler.Add("00 00 80");
		Renkler.Add("19 19 70");
		Renkler.Add("E6 E6 FA");
		Renkler.Add("D8 BF D8");
		Renkler.Add("DD A0 DD");
		Renkler.Add("EE 82 EE");
		Renkler.Add("DA 70 D6");
		Renkler.Add("FF 00 FF");
		Renkler.Add("FF 00 FF");
		Renkler.Add("BA 55 D3");
		Renkler.Add("93 70 DB");
		Renkler.Add("8A 2B E2");
		Renkler.Add("94 00 D3");
		Renkler.Add("99 32 CC");
		Renkler.Add("8B 00 8B");
		Renkler.Add("80 00 80");
		Renkler.Add("4B 00 82");
		Renkler.Add("6A 5A CD");
		Renkler.Add("48 3D 8B");
		Renkler.Add("FF F8 DC");
		Renkler.Add("FF EB CD");
		Renkler.Add("FF E4 C4");
		Renkler.Add("FF DE AD");
		Renkler.Add("F5 DE B3");
		Renkler.Add("DE B8 87");
		Renkler.Add("D2 B4 8C");
		Renkler.Add("BC 8F 8F");
		Renkler.Add("F4 A4 60");
		Renkler.Add("DA A5 20");
		Renkler.Add("B8 86 0B");
		Renkler.Add("CD 85 3F");
		Renkler.Add("D2 69 1E");
		Renkler.Add("8B 45 13");
		Renkler.Add("A0 52 2D");
		Renkler.Add("A5 2A 2A");
		Renkler.Add("80 00 00");
		Renkler.Add("FF FF FF");
		Renkler.Add("FF FA FA");
		Renkler.Add("F0 FF F0");
		Renkler.Add("F5 FF FA");
		Renkler.Add("F0 FF FF");
		Renkler.Add("F0 F8 FF");
		Renkler.Add("F8 F8 FF");
		Renkler.Add("F5 F5 F5");
		Renkler.Add("FF F5 EE");
		Renkler.Add("F5 F5 DC");
		Renkler.Add("FD F5 E6");
		Renkler.Add("FF FA F0");
		Renkler.Add("FF FF F0");
		Renkler.Add("FA EB D7");
		Renkler.Add("FA F0 E6");
		Renkler.Add("FF F0 F5");
		Renkler.Add("FF E4 E1");
		Renkler.Add("DC DC DC");
		Renkler.Add("D3 D3 D3");
		Renkler.Add("C0 C0 C0");
		Renkler.Add("A9 A9 A9");
		Renkler.Add("80 80 80");
		Renkler.Add("69 69 69");
		Renkler.Add("77 88 99");
		Renkler.Add("70 80 90");
		Renkler.Add("2F 4F 4F");
		Renkler.Add("00 00 00");
		Renkler.Add("00 00 00");
		#endregion
		
		
		double[] M = new double[142];
		
		int m = 0;
		foreach (String renk in Merkezler)
		{
			double RGB = 0;
			int i = 0;
			string[] OndalikDegerleriAyir = renk.Split(' ');
			
			foreach (String ondalik in OndalikDegerleriAyir)
			{
				double deger = Convert.ToInt32(ondalik, 16);
				RGB = deger;
				i++;
			}
			
			M[m] = RGB;
			m++;
		}
		
		int r = 0;
		foreach (String renk in Renkler)
		{
			double R = 0, G = 0, B = 0;
			int i = 0;
			string[] OndalikDegerleriAyir = renk.Split(' ');
			
			foreach (String ondalik in OndalikDegerleriAyir)
			{
				double deger = Convert.ToInt32(ondalik, 16);
				if (i == 0)
				{
					R = deger;
				}
				else if (i == 1)
				{
					G = deger;
				}
				else if (i == 2)
				{
					B = deger;
				}
				i++;
			}
			
			X[r] = R;
			Y[r] = G;
			Z[r] = B;
			r++;
		}

		if (Top.level == 1) 
		{
			System.Random random = new System.Random();
			
			int sayi1 = random.Next(0, 142);
			int sayi2 = random.Next(0, 142);
			int sayi3 = random.Next(0, 142);
			
			double randomM1M = M[sayi1];
			double randomM2M = M[sayi2];
			double randomM3M = M[sayi3];
			
			double merkez1M = 0;
			double merkez2M = 0;
			double merkez3M = 0;
			
			double eskimerkez1M = 0;
			double eskimerkez2M = 0;
			double eskimerkez3M = 0;
			
			double uzaklik1 = 0, uzaklik2 = 0, uzaklik3 = 0;
			int adimSayac = 0;
			bool kontrol = true;
			
			while (kontrol)
			{
				kume1.Clear();
				kume2.Clear();
				kume3.Clear();
				
				for (int i = 0; i < 142; i++)
				{
					uzaklik1 = Math.Abs(randomM1M - M[i]);
					uzaklik2 = Math.Abs(randomM2M - M[i]);
					uzaklik3 = Math.Abs(randomM3M - M[i]);
					
					if (uzaklik1 <= uzaklik2 && uzaklik1 <= uzaklik3)
					{
						kume1.Add(i);
						merkez1M = merkez1M + M[i];
					}
					
					else if (uzaklik2 < uzaklik1 && uzaklik2 <= uzaklik3)
					{
						kume2.Add(i);
						merkez2M = merkez2M + M[i];
					}
					
					else if (uzaklik3 < uzaklik2 && uzaklik3 < uzaklik1)
					{
						kume3.Add(i);
						merkez3M = merkez3M + M[i];
					}
					
				}
				
				eskimerkez1M = randomM1M;
				eskimerkez2M = randomM2M;
				eskimerkez3M = randomM3M;
				
				randomM1M = (merkez1M / kume1.Count);
				randomM2M = (merkez2M / kume2.Count);
				randomM3M = (merkez3M / kume3.Count);
				
				adimSayac++;
				
				merkez1M = 0;
				merkez2M = 0;
				merkez3M = 0;
				
				kontrol = eskimerkez1M != randomM1M ||
						eskimerkez2M != randomM2M ||
						eskimerkez3M != randomM3M;
				
			}

			StreamWriter dosya1 = new StreamWriter("Assets/Resources/Kümeler/Kolay.txt");
			
			dosya1.Write("1. kume {0} elemandan oluşmaktadır. = ",kume1.Count);
			foreach (int eleman in kume1)
			{
				dosya1.Write("{0},", eleman);
			}
			dosya1.WriteLine("");

			dosya1.Write("2. kume {0} elemandan oluşmaktadır. = ",kume2.Count);
			foreach (int eleman in kume2)
			{
				dosya1.Write("{0},", eleman);
			}
			dosya1.WriteLine("");

			dosya1.Write("3. kume {0} elemandan oluşmaktadır. = ",kume3.Count);
			foreach (int eleman in kume3)
			{
				dosya1.Write("{0},", eleman);
			}
			dosya1.WriteLine("");

			dosya1.Close();
		}

		if (Top.level == 2)
		{
			System.Random random = new System.Random();
			
			int sayi1 = random.Next(0, 142);
			int sayi2 = random.Next(0, 142);
			int sayi3 = random.Next(0, 142);
			int sayi4 = random.Next(0, 142);
			
			double randomM1M = M[sayi1];
			double randomM2M = M[sayi2];
			double randomM3M = M[sayi3];
			double randomM4M = M[sayi4];
			
			double merkez1M = 0;
			double merkez2M = 0;
			double merkez3M = 0;
			double merkez4M = 0;
			
			double eskimerkez1M = 0;
			double eskimerkez2M = 0;
			double eskimerkez3M = 0;
			double eskimerkez4M = 0;
			
			double uzaklik1 = 0, uzaklik2 = 0, uzaklik3 = 0, uzaklik4 = 0;
			int adimSayac = 0;
			bool kontrol = true;
			
			while (kontrol)
			{
				kume1.Clear();
				kume2.Clear();
				kume3.Clear();
				kume4.Clear();
				
				for (int i = 0; i < 142; i++)
				{
					uzaklik1 = Math.Abs(randomM1M - M[i]);
					uzaklik2 = Math.Abs(randomM2M - M[i]);
					uzaklik3 = Math.Abs(randomM3M - M[i]);
					uzaklik4 = Math.Abs(randomM4M - M[i]);
					
					if (uzaklik1 <= uzaklik2 && uzaklik1 <= uzaklik3 && uzaklik1 <= uzaklik4)
					{
						kume1.Add(i);
						merkez1M = merkez1M + M[i];
					}
					
					else if (uzaklik2 < uzaklik1 && uzaklik2 <= uzaklik3 && uzaklik2 <= uzaklik4)
					{
						kume2.Add(i);
						merkez2M = merkez2M + M[i];
					}
					
					else if (uzaklik3 < uzaklik2 && uzaklik3 < uzaklik1 && uzaklik3 <= uzaklik4)
					{
						kume3.Add(i);
						merkez3M = merkez3M + M[i];
					}
					
					else if (uzaklik4 < uzaklik2 && uzaklik4 < uzaklik1 && uzaklik4 < uzaklik3)
					{
						kume4.Add(i);
						merkez4M = merkez4M + M[i];
					}
					
				}
				
				eskimerkez1M = randomM1M;
				eskimerkez2M = randomM2M;
				eskimerkez3M = randomM3M;
				eskimerkez4M = randomM4M;
				
				randomM1M = (merkez1M / kume1.Count);
				randomM2M = (merkez2M / kume2.Count);
				randomM3M = (merkez3M / kume3.Count);
				randomM4M = (merkez4M / kume4.Count);
				
				adimSayac++;
				
				merkez1M = 0;
				merkez2M = 0;
				merkez3M = 0;
				merkez4M = 0;
				
				kontrol = eskimerkez1M != randomM1M ||
						eskimerkez2M != randomM2M ||
						eskimerkez3M != randomM3M ||
						eskimerkez4M != randomM4M;
				
			}

			StreamWriter dosya2 = new StreamWriter("Assets/Resources/Kümeler/Orta.txt");
			
			dosya2.Write("1. kume {0} elemandan oluşmaktadır. = ",kume1.Count);
			foreach (int eleman in kume1)
			{
				dosya2.Write("{0},", eleman);
			}
			dosya2.WriteLine("");
			
			dosya2.Write("2. kume {0} elemandan oluşmaktadır. = ",kume2.Count);
			foreach (int eleman in kume2)
			{
				dosya2.Write("{0},", eleman);
			}
			dosya2.WriteLine("");
			
			dosya2.Write("3. kume {0} elemandan oluşmaktadır. = ",kume3.Count);
			foreach (int eleman in kume3)
			{
				dosya2.Write("{0},", eleman);
			}
			dosya2.WriteLine("");

			dosya2.Write("4. kume {0} elemandan oluşmaktadır. = ",kume4.Count);
			foreach (int eleman in kume4)
			{
				dosya2.Write("{0},", eleman);
			}
			dosya2.WriteLine("");
			
			dosya2.Close();

		}

		if(Top.level == 3)
		{
			System.Random random = new System.Random();
			
			int sayi1 = random.Next(0, 142);
			int sayi2 = random.Next(0, 142);
			int sayi3 = random.Next(0, 142);
			int sayi4 = random.Next(0, 142);
			int sayi5 = random.Next(0, 142);
			
			double randomM1M = M[sayi1];
			double randomM2M = M[sayi2];
			double randomM3M = M[sayi3];
			double randomM4M = M[sayi4];
			double randomM5M = M[sayi5];
			
			double merkez1M = 0;
			double merkez2M = 0;
			double merkez3M = 0;
			double merkez4M = 0;
			double merkez5M = 0;
			
			double eskimerkez1M = 0;
			double eskimerkez2M = 0;
			double eskimerkez3M = 0;
			double eskimerkez4M = 0;
			double eskimerkez5M = 0;
			
			double uzaklik1 = 0, uzaklik2 = 0, uzaklik3 = 0, uzaklik4 = 0, uzaklik5 = 0;
			int adimSayac = 0;
			bool kontrol = true;
			
			while (kontrol)
			{
				kume1.Clear();
				kume2.Clear();
				kume3.Clear();
				kume4.Clear();
				kume5.Clear();
				
				for (int i = 0; i < 142; i++)
				{
					uzaklik1 = Math.Abs(randomM1M - M[i]);
					uzaklik2 = Math.Abs(randomM2M - M[i]);
					uzaklik3 = Math.Abs(randomM3M - M[i]);
					uzaklik4 = Math.Abs(randomM4M - M[i]);
					uzaklik5 = Math.Abs(randomM5M - M[i]);
					
					if (uzaklik1 <= uzaklik2 && uzaklik1 <= uzaklik3 && uzaklik1 <= uzaklik4 && uzaklik1 <= uzaklik5)
					{
						kume1.Add(i);
						merkez1M = merkez1M + M[i];
					}
					
					else if (uzaklik2 < uzaklik1 && uzaklik2 <= uzaklik3 && uzaklik2 <= uzaklik4 && uzaklik2 <= uzaklik5)
					{
						kume2.Add(i);
						merkez2M = merkez2M + M[i];
					}
					
					else if (uzaklik3 < uzaklik2 && uzaklik3 < uzaklik1 && uzaklik3 <= uzaklik4 && uzaklik3 <= uzaklik5)
					{
						kume3.Add(i);
						merkez3M = merkez3M + M[i];
					}
					
					else if (uzaklik4 < uzaklik2 && uzaklik4 < uzaklik1 && uzaklik4 < uzaklik3 && uzaklik4 <= uzaklik5)
					{
						kume4.Add(i);
						merkez4M = merkez4M + M[i];
					}
					else if (uzaklik5 < uzaklik2 && uzaklik5 < uzaklik1 && uzaklik5 < uzaklik3 && uzaklik5 < uzaklik4)
					{
						kume5.Add(i);
						merkez5M = merkez5M + M[i];
					}
					
				}
				
				eskimerkez1M = randomM1M;
				eskimerkez2M = randomM2M;
				eskimerkez3M = randomM3M;
				eskimerkez4M = randomM4M;
				eskimerkez5M = randomM5M;
				
				randomM1M = (merkez1M / kume1.Count);
				randomM2M = (merkez2M / kume2.Count);
				randomM3M = (merkez3M / kume3.Count);
				randomM4M = (merkez4M / kume4.Count);
				randomM5M = (merkez5M / kume5.Count);
				
				adimSayac++;
				
				merkez1M = 0;
				merkez2M = 0;
				merkez3M = 0;
				merkez4M = 0;
				merkez5M = 0;
				
				kontrol = eskimerkez1M != randomM1M ||
						eskimerkez2M != randomM2M ||
						eskimerkez3M != randomM3M ||
						eskimerkez4M != randomM4M ||
						eskimerkez5M != randomM5M;
				
			}

			StreamWriter dosya3 = new StreamWriter("Assets/Resources/Kümeler/Zor.txt");
			
			dosya3.Write("1. kume {0} elemandan oluşmaktadır. = ",kume1.Count);
			foreach (int eleman in kume1)
			{
				dosya3.Write("{0},", eleman);
			}
			dosya3.WriteLine("");
			
			dosya3.Write("2. kume {0} elemandan oluşmaktadır. = ",kume2.Count);
			foreach (int eleman in kume2)
			{
				dosya3.Write("{0},", eleman);
			}
			dosya3.WriteLine("");
			
			dosya3.Write("3. kume {0} elemandan oluşmaktadır. = ",kume3.Count);
			foreach (int eleman in kume3)
			{
				dosya3.Write("{0},", eleman);
			}
			dosya3.WriteLine("");
			
			dosya3.Write("4. kume {0} elemandan oluşmaktadır. = ",kume4.Count);
			foreach (int eleman in kume4)
			{
				dosya3.Write("{0},", eleman);
			}
			dosya3.WriteLine("");

			dosya3.Write("5. kume {0} elemandan oluşmaktadır. = ",kume5.Count);
			foreach (int eleman in kume5)
			{
				dosya3.Write("{0},", eleman);
			}
			dosya3.WriteLine("");
			
			dosya3.Close();
		}
	}
	
	void Update () {
		
	}
}
