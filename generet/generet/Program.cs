using System;

namespace zadaniya1
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] animals = new string[] { "ant", "bison", "camel", "duck", "elephant" };
			ArrayHelper<string>.pray(ArrayHelper<string>.Slice(animals, 2));
			ArrayHelper<string>.pray(ArrayHelper<string>.Slice(animals, 2, 4));
			ArrayHelper<string>.pray(ArrayHelper<string>.Slice(animals, 1, 5));

			Console.ReadKey();
		}
	}

	static class ArrayHelper<T>
	{
		public static T Pop(ref T[] animals)
		{
			T[] arraye = new T[animals.Length - 1];
			for (int i = 0; i < animals.Length - 1; i++)
				arraye[i] = animals[i];
			
			T val = animals[animals.Length - 1];
			animals = arraye;
			return val;
		}
		public static int Push(ref T[] animals, T push)
		{
			T[] arraye = new T[animals.Length + 1];
			for (int i = 0; i < animals.Length; i++)
				arraye[i] = animals[i];
			
			arraye[animals.Length] = push;
			animals = arraye;
			return animals.Length;
		}
		public static T Shift(ref T[] animals)
		{
			T[] arraye = new T[animals.Length - 1];
			for (int i = 0; i < animals.Length; i++)
				arraye[i] = animals[i + 1];
			
			T val = animals[0];
			animals = arraye;
			return val;
		}
		public static int Unshift(ref T[] animals, T unsift)
		{
			T[] arraye = new T[animals.Length + 1];
			for (int i = 0; i < animals.Length; i++)
				arraye[i + 1] = animals[i];
			
			arraye[0] = unsift;
			animals = arraye;
			return animals.Length;
		}
		public static void pray(T[] animals)
		{
			foreach (var trin in animals)
				Console.Write($"{trin} ");
			
			Console.WriteLine();
		}
		public static T[] Slice(T[] animals, int begin = 0, int end = 0)
		{
			if (animals == null)
				throw new ArgumentNullException("ошибка");
			
			if (begin < 0)
				begin = animals.Length + begin;
			
			if (end <= 0)
				end = animals.Length + end;
			
			int Lengn = Math.Abs(end - begin);
			T[] arraye = new T[Lengn];
			for (int i = 0; i < Lengn; i++)
				arraye[i] = animals[begin + i];
			
			return arraye;
		}
	}
}
