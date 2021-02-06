using System;

namespace zadaniya1
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] arr = new string[] { "ant", "bison", "camel", "duck", "elephant" };
			ArrayHelper<string>.Show(ArrayHelper<string>.Slice(arr, 2));
			ArrayHelper<string>.Show(ArrayHelper<string>.Slice(arr, 2, 4));
			ArrayHelper<string>.Show(ArrayHelper<string>.Slice(arr, 1, 5));

			Console.ReadKey();
		}
	}

	static class ArrayHelper<T>
	{
		public static T Pop(ref T[] arr)
		{
			T[] newArr = new T[arr.Length - 1];
			for (int i = 0; i < arr.Length - 1; i++)
			{
				newArr[i] = arr[i];
			}
			T returnVal = arr[arr.Length - 1];
			arr = newArr;
			return returnVal;
		}
		public static int Push(ref T[] arr, T itemToPush)
		{
			T[] newArr = new T[arr.Length + 1];
			for (int i = 0; i < arr.Length; i++)
			{
				newArr[i] = arr[i];
			}
			newArr[arr.Length] = itemToPush;
			arr = newArr;
			return arr.Length;
		}
		public static T Shift(ref T[] arr)
		{
			T[] newArr = new T[arr.Length - 1];
			for (int i = 0; i < arr.Length; i++)
			{
				newArr[i] = arr[i + 1];
			}
			T returnVal = arr[0];
			arr = newArr;
			return returnVal;
		}
		public static int Unshift(ref T[] arr, T itemToUnshift)
		{
			T[] newArr = new T[arr.Length + 1];
			for (int i = 0; i < arr.Length; i++)
			{
				newArr[i + 1] = arr[i];
			}
			newArr[0] = itemToUnshift;
			arr = newArr;
			return arr.Length;
		}
		public static void Show(T[] arr)
		{
			foreach (var item in arr)
			{
				Console.Write($"{item} ");
			}
			Console.WriteLine();
		}
		public static T[] Slice(T[] arr, int begin = 0, int end = 0)
		{
			if (arr == null)
			{
				throw new ArgumentNullException("ошибка");
			}
			if (begin < 0)
			{
				begin = arr.Length + begin;
			}
			if (end <= 0)
			{
				end = arr.Length + end;
			}
			int newLength = Math.Abs(end - begin);
			T[] newArr = new T[newLength];
			for (int i = 0; i < newLength; i++)
			{
				newArr[i] = arr[begin + i];
			}
			return newArr;
		}
	}
}