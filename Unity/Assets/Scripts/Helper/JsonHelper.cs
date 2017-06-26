﻿using System;

namespace Model
{
	public static class JsonHelper
	{
		public static string ToJson(object obj)
		{
			return MongoHelper.ToJson(obj);
		}

		public static T FromJson<T>(string str)
		{
			return MongoHelper.FromJson<T>(str);
		}

		public static object FromJson(Type type, string str)
		{
			return MongoHelper.FromJson(type, str);
		}

		public static T FromJson<T>(byte[] bytes, int index, int count)
		{
			string str = bytes.ToStr();
			return MongoHelper.FromJson<T>(str);
		}

		public static object FromJson(Type type, byte[] bytes, int index, int count)
		{
			string str = bytes.ToStr(index, count);
			return MongoHelper.FromJson(type, str);
		}
	}
}